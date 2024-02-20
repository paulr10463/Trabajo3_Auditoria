using System;
using System.Data.SqlClient;

namespace Trabajo4_Auditoria.Data
{
    class BDConnection
    {
        // Cadena de conexión a la base de datos
        string connectionString = "Data Source=LAPTOPPAUL\\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True";

        public void ObtenerRelacionesIntegridadReferencial()
        {
            // Consulta para obtener las relaciones que requieren integridad referencial
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
                // Crear una nueva conexión
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar la consulta
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Ejecutar la consulta y obtener un lector de datos
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Iterar sobre los resultados y mostrarlos en la consola
                            while (reader.Read())
                            {
                                string tabla = reader["tabla"].ToString();
                                string columna = reader["columna"].ToString();
                                string nombreRelacion = reader["nombre_relacion"].ToString();
                                string tablaReferencia = reader["tabla_referencia"].ToString();
                                string columnaReferencia = reader["columna_referencia"].ToString();

                                MessageBox.Show($"Tabla: {tabla}, Columna: {columna}, Nombre Relación: {nombreRelacion}, Tabla Referencia: {tablaReferencia}, Columna Referencia: {columnaReferencia}");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Ocurrió un error al intentar establecer la conexión
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }
    }
}
