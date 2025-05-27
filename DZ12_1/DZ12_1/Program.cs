using System;
using MySql.Data.MySqlClient;

namespace DZ12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string connectionString = "Server=localhost;Database=dz12;Uid=root;Pwd=admin;";

            // Create the connection
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Open the connection
                Console.WriteLine("Attempting to connect to database...");
                connection.Open();
                Console.WriteLine("Connection successful!");

                // SQL command to insert a new user
                string sql = "INSERT INTO Korisnik (username, password) VALUES ('user123', 'pass456')";

                // Create and execute the command
                MySqlCommand command = new MySqlCommand(sql, connection);
                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine($"{rowsAffected} row(s) inserted successfully.");
            }
            catch (Exception ex)
            {
                // Handle any errors
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // Always close the connection in the finally block
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Connection closed.");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}