using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DebuggerHandbook
{
    internal class DataBase
    {
        static string connectionString = @"Data Source=DESKTOP-UGDHEEM;Initial Catalog=users_db;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connectionString);

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }

        public void closeConnection() 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
