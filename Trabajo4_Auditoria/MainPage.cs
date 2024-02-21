using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Trabajo4_Auditoria.Data;

namespace Trabajo4_Auditoria
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Define your connection string
            string connectionString = ConnectionString.connectionString;

            // Define your SQL query
            string query = @"
                SELECT 
                    t.name AS tabla,
                    c.name AS columna,
                    fk.name AS nombre_relacion,
                    rt.name AS tabla_referencia,
                    rc.name AS columna_referencia
                FROM 
                    sys.tables t
                INNER JOIN 
                    sys.foreign_keys fk ON t.object_id = fk.parent_object_id
                INNER JOIN 
                    sys.foreign_key_columns fkc ON fk.object_id = fkc.constraint_object_id
                INNER JOIN 
                    sys.columns c ON fkc.parent_column_id = c.column_id AND fkc.parent_object_id = c.object_id
                INNER JOIN 
                    sys.columns rc ON fkc.referenced_column_id = rc.column_id AND fkc.referenced_object_id = rc.object_id
                INNER JOIN 
                    sys.tables rt ON fk.referenced_object_id = rt.object_id";


            try
            {
                // Create a new connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a new SqlDataAdapter to fetch the data
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Create a new DataTable to hold the data
                        DataTable table = new DataTable();

                        // Fill the DataTable with the data from the SQL query
                        adapter.Fill(table);

                        // Bind the DataTable to the DataGridView
                        dataResultsGridTable.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Define your connection string
            string connectionString = ConnectionString.connectionString;

            // Define your SQL query
            string query = @"
                DECLARE @constraint_name NVARCHAR(100)
                DECLARE @sql NVARCHAR(MAX)
                DECLARE cur_constraints CURSOR FOR
                SELECT name
                FROM sys.foreign_keys
                OPEN cur_constraints
                FETCH NEXT FROM cur_constraints INTO @constraint_name
                WHILE @@FETCH_STATUS = 0
                BEGIN
                 SET @sql = 'DBCC CHECKCONSTRAINTS (''' + @constraint_name + ''')'
                 EXEC sp_executesql @sql

                 FETCH NEXT FROM cur_constraints INTO @constraint_name
                END
                CLOSE cur_constraints
                DEALLOCATE cur_constraints";
            try
            {
                // Create a new connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a new SqlDataAdapter to fetch the data
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Create a new DataTable to hold the data
                        DataTable table = new DataTable();

                        // Fill the DataTable with the data from the SQL query
                        adapter.Fill(table);

                        // Bind the DataTable to the DataGridView
                        dataResultsGridTable.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void nuevaBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBD inputBD = new();
            inputBD.ShowDialog();
        }

        private void cerrarBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionString.connectionString = "";
            MessageBox.Show("Conexión con la base de datos cerrada");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
