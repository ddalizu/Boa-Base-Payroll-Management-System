using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PayrollManagementSystem
{
    internal class Services
    {
        private static readonly string connectionString = "Server=localhost;Database=boapayrolldb;Uid=root;Pwd=;";    

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);

        }
        public static void TestConnection()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Try to open the connection
                    MessageBox.Show("Database connection successful!", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database connection failed: {ex.Message}", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close(); // Ensure the connection is closed
                }
            }
        }

    }
}
