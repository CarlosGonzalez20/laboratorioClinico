using System;
using MySql.Data.MySqlClient;

namespace clinica
{
    public class DatabaseConnection
    {
        private readonly string connectionString;

        public DatabaseConnection()
        {
            // Configura la cadena de conexión para MySQL
            connectionString = "server=localhost;user=root;database=laboratorioclinico;password=12345;";
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                // Maneja excepciones de conexión aquí
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
        }
    }
}
