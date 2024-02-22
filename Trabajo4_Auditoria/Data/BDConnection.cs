using System;
using System.Data.SqlClient;

namespace Trabajo4_Auditoria.Data
{
    class BDConnection
    {
        static public List<string> GetForeignKeyNames()
        {
            //Select de nombres de foreign keys
            string query = "SELECT \r\n    fk.name AS 'Nombre_ForeignKey',\r\n    SCHEMA_NAME(t.schema_id) AS 'Schema_Tabla_Origen'\r\nFROM \r\n    sys.foreign_keys fk\r\nINNER JOIN \r\n    sys.tables t ON fk.parent_object_id = t.object_id;";
            List<string> foreignKeyListNames = new();
            try
            {
                // Crear una nueva conexión
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
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
                                string foreignKeyName = reader["Nombre_ForeignKey"].ToString();
                                string schemaName = reader["Schema_Tabla_Origen"].ToString();
                                foreignKeyListNames.Add($"{schemaName}.{foreignKeyName}");   
                            }
                        }
                    }
                }
                return foreignKeyListNames;
            }
            catch (SqlException ex)
            {
                // Ocurrió un error al intentar establecer la conexión
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
            
        }
    }
}
