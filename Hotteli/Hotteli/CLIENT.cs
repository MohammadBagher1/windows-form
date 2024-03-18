using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotteli
{
    class CLIENT
    {
        CONNECT conn = new CONNECT();
        public bool insertClient(string fname, string lname, string phone, string country); 
        {
            MySqlCommand command = new MySqlCommand();
        string insertQuery = "INSERT INTO `clients`(`first_name`, `last_name`, `phone`, `country`) VALUES (@fnm,@lnm,@phn,@cnt)";
        command.CommandText= insertQuery;
            command.Connection = conn.getVonnection();

            //@fnm,@lnm,@phn,@cnt
            command.Parameters.ADD("@fnm", MySqlDbType.VarChar).value= fname;
            command.Parameters.ADD("@lnm", MySqlDbType.VarChar).value= lname;
            command.Parameters.ADD("@fnm", MySqlDbType.VarChar).value= phone;
            command.Parameters.ADD("@fnm", MySqlDbType.VarChar).value= country;


            conn.openConnection();


            if(commandt.ExcuteNonQuery()==1)
            {
                conn.closeConnection();
                return true   
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
    }
}
