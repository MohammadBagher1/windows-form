using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotteli
{
    internal class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Csharp_Hotel_DB");

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        private void openConnection()
        {
            if(connection.State == ConnectionState.Closed) 
            {
                connection.Open();
            }
        }

        private void closedConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
