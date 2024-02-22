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
            panel1.Controls.Clear();
            // Define your connection string
            string connectionString = ConnectionString.connectionString;

            // Define your SQL query
            string query = @"
            SELECT
                FK.name AS 'Nombre_Clave_Foranea',
                TP.name AS 'Tabla_Parent',
                CP.name AS 'Columna_Parent',
                TR.name AS 'Tabla_Referenciada',
                CR.name AS 'Columna_Referenciada',
                FK.delete_referential_action_desc AS 'Acción_Al_Eliminar',
                FK.update_referential_action_desc AS 'Acción_Al_Actualizar'
            FROM 
                sys.foreign_keys AS FK
            INNER JOIN 
                sys.tables AS TP ON FK.parent_object_id = TP.object_id
            INNER JOIN 
                sys.foreign_key_columns AS FKC ON FKC.constraint_object_id = FK.object_id
            INNER JOIN 
                sys.columns AS CP ON FKC.parent_object_id = CP.object_id AND FKC.parent_column_id = CP.column_id
            INNER JOIN 
                sys.tables AS TR ON FKC.referenced_object_id = TR.object_id
            INNER JOIN 
                sys.columns AS CR ON FKC.referenced_object_id = CR.object_id AND FKC.referenced_column_id = CR.column_id";
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
                        string logMessage = "Resultado de la identificación de integridad referencial";
                        AddGridTableInResults(adapter); 
                        LogDataTable(adapter, logMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Logs.LOG("Error durante la identificación de la integridad referencial" + ex.Message);
            }

        }
        private void LogDataTable(SqlDataAdapter adapter, string logMessage)
        {
            DataTable table = new DataTable();
            adapter.Fill(table);
            string message = logMessage + "\n";
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    message += $"{col.ColumnName}: {row[col]}\n";
                }
                message += "\n";
            }
            Logs.LOG(message);
        }


        private void AddGridTableInResults(SqlDataAdapter adapter)
        {
            DataTable table = new();
            adapter.Fill(table);
            DataGridView dataGridView = new()
            {
                DataSource = table,
                Dock = DockStyle.Top,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
                Height = (table.Rows.Count + 2) * 30,
            };
            panel1.Controls.Add(dataGridView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Define your connection string
            string connectionString = ConnectionString.connectionString;
            List<string> fkNames = BDConnection.GetForeignKeyNames();
            foreach (string fkName in fkNames)
            {
                string query = @"
                    DECLARE @constraint_name NVARCHAR(100)
                    DECLARE @sql NVARCHAR(MAX)

                    SET @constraint_name = '" + fkName + @"'
                    SET @sql = 'DBCC CHECKCONSTRAINTS (''' + @constraint_name + ''')'
                    EXEC sp_executesql @sql";
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
                            DataTable table = new();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                DataGridView dataGridView = new()
                                {
                                    DataSource = table,
                                    Dock = DockStyle.Top,
                                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                                    Height = (table.Rows.Count + 2) * 30,
                                };
                                panel1.Controls.Add(dataGridView);
                            }
                            string logMessage = "Resultado de chequear anomalias: ";
                            LogDataTable(adapter, logMessage);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
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

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Define your connection string
            string connectionString = ConnectionString.connectionString;

            // Define your SQL query
            string query = @"
                SELECT
                OBJECT_NAME(fkc.parent_object_id) AS Tabla,
                COL_NAME(fkc.parent_object_id, fkc.parent_column_id) AS Columna_Foranea,
                OBJECT_NAME(fkc.referenced_object_id) AS Tabla_Referenciada,
                COL_NAME(fkc.referenced_object_id, fkc.referenced_column_id) AS Columna_Referenciada
            FROM 
                sys.foreign_key_columns AS fkc
            WHERE 
                NOT EXISTS (
                    SELECT 1
                    FROM 
                        sys.indexes AS i
                    INNER JOIN 
                        sys.index_columns AS ic ON i.object_id = ic.object_id AND i.index_id = ic.index_id
                    INNER JOIN 
                        sys.columns AS c ON ic.object_id = c.object_id AND ic.column_id = c.column_id
                    WHERE 
                        i.is_primary_key = 1
                        AND c.object_id = fkc.parent_object_id
                        AND c.column_id = fkc.parent_column_id
                )";

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
                        string logMessage = "Resultado de anomalias que no dependen de los datos ";
                        AddGridTableInResults(adapter);
                        LogDataTable(adapter, logMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Define your connection string
            string connectionString = ConnectionString.connectionString;

            // Define your SQL query
            string query = @"
                SELECT 
                    OBJECT_NAME(c.object_id) AS Tabla,
                    c.name AS Columna
                FROM 
                    sys.indexes i
                INNER JOIN 
                    sys.index_columns ic ON i.object_id = ic.object_id AND i.index_id = ic.index_id
                INNER JOIN 
                    sys.columns c ON ic.object_id = c.object_id AND ic.column_id = c.column_id
                WHERE 
                    i.is_primary_key = 1;";

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
                        string logMessage = "Resultado de extraer las claves primarias: ";
                        AddGridTableInResults(adapter);
                        LogDataTable(adapter, logMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Define your connection string
            string connectionString = ConnectionString.connectionString;

            // Define your SQL query
            string query = @"
                SELECT 
                    PK.TABLE_NAME AS PrimaryTable,
                    PK.COLUMN_NAME AS PrimaryColumn,
                    PK.DATA_TYPE AS PrimaryDataType,
                    FK.TABLE_NAME AS ForeignTable,
                    FK.COLUMN_NAME AS ForeignColumn,
                    FK.DATA_TYPE AS ForeignDataType
                FROM 
                    INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS PK_CONSTRAINTS
                INNER JOIN 
                    INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS PK_USAGE
                ON 
                    PK_CONSTRAINTS.CONSTRAINT_NAME = PK_USAGE.CONSTRAINT_NAME
                AND 
                    PK_CONSTRAINTS.TABLE_NAME = PK_USAGE.TABLE_NAME
                INNER JOIN 
                    INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS AS FK_CONSTRAINTS
                ON 
                    PK_CONSTRAINTS.CONSTRAINT_NAME = FK_CONSTRAINTS.UNIQUE_CONSTRAINT_NAME
                INNER JOIN 
                    INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS FK_USAGE
                ON 
                    FK_CONSTRAINTS.CONSTRAINT_NAME = FK_USAGE.CONSTRAINT_NAME
                AND 
                    PK_USAGE.ORDINAL_POSITION = FK_USAGE.ORDINAL_POSITION
                INNER JOIN 
                    INFORMATION_SCHEMA.COLUMNS AS PK
                ON 
                    PK_USAGE.TABLE_NAME = PK.TABLE_NAME
                AND 
                    PK_USAGE.COLUMN_NAME = PK.COLUMN_NAME
                INNER JOIN 
                    INFORMATION_SCHEMA.COLUMNS AS FK
                ON 
                    FK_USAGE.TABLE_NAME = FK.TABLE_NAME
                AND 
                    FK_USAGE.COLUMN_NAME = FK.COLUMN_NAME
                WHERE 
                    PK_CONSTRAINTS.CONSTRAINT_TYPE = 'PRIMARY KEY';";

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
                        string logMessage = "Resultado de la identificacion  del tipo de dato en clave primaria y clave foranea sean compatibles: ";
                        AddGridTableInResults(adapter);
                        LogDataTable(adapter, logMessage);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Define your connection string
            string connectionString = ConnectionString.connectionString;

            // Define your SQL query
            string query = @"
                DECLARE @FKName NVARCHAR(128),
                        @ParentTableID INT,
                        @ParentSchemaName NVARCHAR(128), -- Nuevo: Nombre del esquema para la tabla padre
                        @ParentColumnName NVARCHAR(128),
                        @ReferencedTableID INT,
                        @ReferencedSchemaName NVARCHAR(128), -- Nuevo: Nombre del esquema para la tabla referenciada
                        @ReferencedColumnName NVARCHAR(128),
                        @SQL NVARCHAR(MAX);

                DECLARE FK_Columns CURSOR FOR
                SELECT 
                    fk.name AS 'Nombre_FK',
                    OBJECT_SCHEMA_NAME(fk.parent_object_id) AS 'ParentSchemaName', -- Obtener el esquema de la tabla padre
                    fk.parent_object_id AS 'ParentTableID',
                    c1.name AS 'Columna_Origen',
                    OBJECT_SCHEMA_NAME(fk.referenced_object_id) AS 'ReferencedSchemaName', -- Obtener el esquema de la tabla referenciada
                    fk.referenced_object_id AS 'ReferencedTableID',
                    c2.name AS 'Columna_Destino'
                FROM 
                    sys.foreign_keys AS fk
                INNER JOIN 
                    sys.foreign_key_columns AS fkc ON fk.object_id = fkc.constraint_object_id
                INNER JOIN 
                    sys.columns AS c1 ON fkc.parent_object_id = c1.object_id AND fkc.parent_column_id = c1.column_id
                INNER JOIN 
                    sys.columns AS c2 ON fkc.referenced_object_id = c2.object_id AND fkc.referenced_column_id = c2.column_id;

                CREATE TABLE #FK_NullCounts (
                    FKName NVARCHAR(128), 
                    ParentTableName NVARCHAR(128), 
                    ParentColumnName NVARCHAR(128), 
                    ReferencedTableName NVARCHAR(128), 
                    ReferencedColumnName NVARCHAR(128), 
                    NullCount INT
                )

                OPEN FK_Columns
                FETCH NEXT FROM FK_Columns INTO @FKName, @ParentSchemaName, @ParentTableID, @ParentColumnName, @ReferencedSchemaName, @ReferencedTableID, @ReferencedColumnName

                WHILE @@FETCH_STATUS = 0
                BEGIN
                    -- Resolviendo los nombres de las tablas y esquemas
                    DECLARE @ParentTableName NVARCHAR(128) = OBJECT_SCHEMA_NAME(@ParentTableID) + '.' + OBJECT_NAME(@ParentTableID);
                    DECLARE @ReferencedTableName NVARCHAR(128) = OBJECT_SCHEMA_NAME(@ReferencedTableID) + '.' + OBJECT_NAME(@ReferencedTableID);

                    SET @SQL = N'INSERT INTO #FK_NullCounts (FKName, ParentTableName, ParentColumnName, ReferencedTableName, ReferencedColumnName, NullCount) 
                                 SELECT ''' + @FKName + ''', ''' + @ParentTableName + ''', ''' + @ParentColumnName + ''', ''' + @ReferencedTableName + ''', ''' + @ReferencedColumnName + ''', COUNT(*) 
                                 FROM ' + QUOTENAME(@ParentSchemaName) + '.' + QUOTENAME(OBJECT_NAME(@ParentTableID)) + ' WHERE ' + QUOTENAME(@ParentColumnName) + ' IS NULL'
                    EXEC sp_executesql @SQL

                    FETCH NEXT FROM FK_Columns INTO @FKName, @ParentSchemaName, @ParentTableID, @ParentColumnName, @ReferencedSchemaName, @ReferencedTableID, @ReferencedColumnName
                END

                CLOSE FK_Columns
                DEALLOCATE FK_Columns

                SELECT * FROM #FK_NullCounts
                DROP TABLE #FK_NullCounts
                ";

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
                        string logMessage = "Resultado de revisar valores nulos en Claves Primarias: ";
                        AddGridTableInResults(adapter);
                        LogDataTable(adapter, logMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Define your connection string
            string connectionString = ConnectionString.connectionString;

            // Define your SQL query
            string query = @"
                DECLARE @FKName NVARCHAR(128)
                DECLARE @ParentTableName NVARCHAR(128)
                DECLARE @ParentColumnName NVARCHAR(128)
                DECLARE @ReferencedTableName NVARCHAR(128)
                DECLARE @ReferencedColumnName NVARCHAR(128)
                DECLARE @ParentSchema NVARCHAR(128)
                DECLARE @ReferencedSchema NVARCHAR(128)
                DECLARE @SQL NVARCHAR(MAX)

                DECLARE FK_Columns CURSOR FOR
                SELECT 
                    fk.name AS 'Nombre_FK',
                    SCHEMA_NAME(t1.schema_id) AS 'Esquema_Tabla_Origen',
                    t1.name AS 'Tabla_Origen',
                    c1.name AS 'Columna_Origen',
                    SCHEMA_NAME(t2.schema_id) AS 'Esquema_Tabla_Destino',
                    t2.name AS 'Tabla_Destino',
                    c2.name AS 'Columna_Destino'
                FROM 
                    sys.foreign_keys AS fk
                INNER JOIN 
                    sys.foreign_key_columns AS fkc ON fk.object_id = fkc.constraint_object_id
                INNER JOIN 
                    sys.columns AS c1 ON fkc.parent_object_id = c1.object_id AND fkc.parent_column_id = c1.column_id
                INNER JOIN 
                    sys.columns AS c2 ON fkc.referenced_object_id = c2.object_id AND fkc.referenced_column_id = c2.column_id
                INNER JOIN 
                    sys.tables AS t1 ON fk.parent_object_id = t1.object_id
                INNER JOIN 
                    sys.tables AS t2 ON fk.referenced_object_id = t2.object_id;

                CREATE TABLE #FK_RepeatedCounts (FKName NVARCHAR(128), ParentSchema NVARCHAR(128), ParentTableName NVARCHAR(128), ParentColumnName NVARCHAR(128), ReferencedSchema NVARCHAR(128), ReferencedTableName NVARCHAR(128), ReferencedColumnName NVARCHAR(128), RepeatedCount INT)

                OPEN FK_Columns
                FETCH NEXT FROM FK_Columns INTO @FKName, @ParentSchema, @ParentTableName, @ParentColumnName, @ReferencedSchema, @ReferencedTableName, @ReferencedColumnName

                WHILE @@FETCH_STATUS = 0
                BEGIN
                    SET @SQL = 'INSERT INTO #FK_RepeatedCounts (FKName, ParentSchema, ParentTableName, ParentColumnName, ReferencedSchema, ReferencedTableName, ReferencedColumnName, RepeatedCount) SELECT ''' + @FKName + ''', ''' + @ParentSchema + ''', ''' + @ParentTableName + ''', ''' + @ParentColumnName + ''', ''' + @ReferencedSchema + ''', ''' + @ReferencedTableName + ''', ''' + @ReferencedColumnName + ''', COUNT(*) - COUNT(DISTINCT ' + @ParentColumnName + ') FROM ' + @ParentSchema + '.' + @ParentTableName
                    EXEC sp_executesql @SQL

                    FETCH NEXT FROM FK_Columns INTO @FKName, @ParentSchema, @ParentTableName, @ParentColumnName, @ReferencedSchema, @ReferencedTableName, @ReferencedColumnName
                END

                CLOSE FK_Columns
                DEALLOCATE FK_Columns

                SELECT * FROM #FK_RepeatedCounts WHERE RepeatedCount > 0
                DROP TABLE #FK_RepeatedCounts
                ";

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
                        string logMessage = "Resultado de monitorear valores repetidos: " ;
                        AddGridTableInResults(adapter);
                        LogDataTable(adapter, logMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Define your connection string
            string connectionString = ConnectionString.connectionString;

            // Define your SQL query
            string query = @"
                DECLARE @FKName NVARCHAR(128)
                DECLARE @ParentTableName NVARCHAR(128)
                DECLARE @ParentColumnName NVARCHAR(128)
                DECLARE @ReferencedTableName NVARCHAR(128)
                DECLARE @ReferencedColumnName NVARCHAR(128)
                DECLARE @SQL NVARCHAR(MAX)

                DECLARE FK_Columns CURSOR FOR
                SELECT 
                    fk.name AS 'Nombre_FK',
                    OBJECT_NAME(fk.parent_object_id) AS 'Tabla_Origen',
                    c1.name AS 'Columna_Origen',
                    OBJECT_NAME(fk.referenced_object_id) AS 'Tabla_Destino',
                    c2.name AS 'Columna_Destino'
                FROM 
                    sys.foreign_keys AS fk
                INNER JOIN 
                    sys.foreign_key_columns AS fkc ON fk.object_id = fkc.constraint_object_id
                INNER JOIN 
                    sys.columns AS c1 ON fkc.parent_object_id = c1.object_id AND fkc.parent_column_id = c1.column_id
                INNER JOIN 
                    sys.columns AS c2 ON fkc.referenced_object_id = c2.object_id AND fkc.referenced_column_id = c2.column_id;

                CREATE TABLE #FK_NullRecords (FKName NVARCHAR(128), ParentTableName NVARCHAR(128), ParentPK NVARCHAR(MAX), ReferencedTableName NVARCHAR(128), ReferencedColumnName NVARCHAR(128))

                OPEN FK_Columns
                FETCH NEXT FROM FK_Columns INTO @FKName, @ParentTableName, @ParentColumnName, @ReferencedTableName, @ReferencedColumnName

                WHILE @@FETCH_STATUS = 0
                BEGIN
                    SET @SQL = 'INSERT INTO #FK_NullRecords (FKName, ParentTableName, ParentPK, ReferencedTableName, ReferencedColumnName) SELECT ''' + @FKName + ''', ''' + @ParentTableName + ''', CONVERT(NVARCHAR(MAX), ' + @ParentTableName + '.' + (SELECT name FROM sys.columns WHERE object_id = OBJECT_ID(@ParentTableName) AND column_id = 1) + '), ''' + @ReferencedTableName + ''', ''' + @ReferencedColumnName + ''' FROM ' + @ParentTableName + ' WHERE ' + @ParentColumnName + ' IS NULL'
                    EXEC sp_executesql @SQL

                    FETCH NEXT FROM FK_Columns INTO @FKName, @ParentTableName, @ParentColumnName, @ReferencedTableName, @ReferencedColumnName
                END

                CLOSE FK_Columns
                DEALLOCATE FK_Columns

                SELECT * FROM #FK_NullRecords
                DROP TABLE #FK_NullRecords
                ";

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
                        string logMessage = "Resultado de detectar valores nulos o repetidos: ";
                        AddGridTableInResults(adapter);
                        LogDataTable(adapter, logMessage);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Define your connection string
            string connectionString = ConnectionString.connectionString;

            string query = "SELECT\n" + "\tQUOTENAME(SCHEMA_NAME(t.schema_id)) + '.' + QUOTENAME(t.name) AS 'Table',\n" + "\tc.name AS 'Check Constraint'\n" + "FROM sys.tables t\n" + "JOIN sys.foreign_keys c ON t.object_id = c.parent_object_id\n" + "WHERE c.is_disabled = 1;\n";
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
                        string logMessage = "Resultado de revisar claves foraneas desactivadas: ";
                        AddGridTableInResults(adapter);
                        LogDataTable(adapter, logMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
