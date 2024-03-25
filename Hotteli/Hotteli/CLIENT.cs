using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Hotteli
{
    class CLIENT
    {
        CONNECT conn = new CONNECT();



        //ADD----------------------------------------------------------------------------------------------
        public bool insertClient(string fname, string lname, string phone, string country, int id)
        {
            MySqlCommand command = new MySqlCommand();
        string insertQuery = "UPDATE `clients` SET ,`first_name`=@fnm,`last_name`=@lnm,`phone`=@phn,`country`=@cnt";
        command.CommandText= insertQuery;
            command.Connection = conn.GetConnection();

            //@fnm,@lnm,@phn,@cnt,@cid
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value= fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = country;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        public DataTable getclients()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }


        //REMOVE-----------------------------------------------------------------------------------------------
        public bool removeClient(int id)
        {
            MySqlCommand command = new MySqlCommand();
            string removeQuery = "DELETE FROM `clients` WHERE `id`=@cid";
            command.CommandText= removeQuery;
            command.Connection= conn.GetConnection();

            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }


        //EDIT--------------------------------------------------------------------------------------------------------
        public bool editClient(string fname, string lname, string phone, string country, int id)
        {
            MySqlCommand command = new MySqlCommand();
            string editQuery = "UPDATE `clients` SET `id`=@cid,`first_name`=@fnm,`last_name`=@lnm,`phone`=@phn,`country`=@cnt";
            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();

            //@fnm,@lnm,@phn,@cnt,@cid
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = country;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        //
    }
}
