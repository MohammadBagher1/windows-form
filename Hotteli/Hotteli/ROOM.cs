using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotteli
{
    class ROOM
    {
        CONNECT conn = new CONNECT();

        public DataTable roomtypeList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms_category`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public DataTable roomBytype(int type)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms` WHERE `type`=@typ", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            //@typ
            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = type;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }


        //ADD room ----------------------------------------------------------------------------------------------------
        public bool addRoom(int number, int type, string phone, string free)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO `rooms`(`number`, `type`, `phone`, `free`) VALUES (@num,@tp,@phn,@fr)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            //(@num,@tp,@phn,@fr)
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;
            

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



        public DataTable getRooms()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }


        //Edit room--------------------------------------------------------------------------------------
        public bool editRoom(int number, int type, string phone, string free)
        {
            MySqlCommand command = new MySqlCommand();
            string editQuery = "UPDATE `rooms` SET ,`type`=@tp,`phone`=@phn,`free`=@fr WHERE 1 `number`=@num";
;
            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();

            //(@num,@tp,@phn,@fr)
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

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




        //remove room---------------------------------------------------------------------------
        public bool removeRoom(int number)
        {
            MySqlCommand command = new MySqlCommand();
            string removeQuery = "DELETE FROM `rooms` WHERE `number`=@num";
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
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

        internal object roomTypeList()
        {
            throw new NotImplementedException();
        }
    }
}
