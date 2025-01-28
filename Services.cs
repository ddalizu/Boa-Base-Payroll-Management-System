using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;

namespace PayrollManagementSystem
{
    internal class Services
    {
        public static readonly string connectionString = "Server=localhost;Database=boapayrolldb;Uid=root;Pwd=;";    

        public static void GetConnection()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Try to open the connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database connection failed: {ex.Message}", 
                        "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }


    }
}
