using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace quanlyThuQuan.DAL
{
    internal class DBHelper
    {
        private static string connectionString = "server=localhost;user=root;password=;database=qlythuquan;";
        private static MySqlConnection connection;

        public static MySqlConnection GetConnection()
        {
            if (connection == null || connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }

            return connection;
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}
