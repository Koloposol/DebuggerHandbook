using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace DebuggerHandbook
{
    internal class DataBase
    {
        //static string connectionString = @"Data Source=DESKTOP-UGDHEEM;Initial Catalog=kursovaya;Integrated Security=True;TrustServerCertificate=True";
        //static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\kursovaya.mdf;Integrated Security=True";
        static string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Егор\source\repos\DebuggerHandbook\bin\Debug\database\kursova.mdf;Integrated Security = True; Connect Timeout = 30";
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
