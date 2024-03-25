using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotteli
{
    class RESERVATION
    {
        CONNECT conn = new CONNECT();

        public DataTable getAllReserv() 
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservations`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }


        //ADD Reserv-------------------------------------------------------------------------
        public bool addResevation(int number, int clientId, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO `reservations`(`roomNumber`, `clientId`, `DateIn`, `DateOut`) VALUES (@rnm,@cid,@din,@dout)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            //@rnm,@cid,@din,@dout
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;


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

        //edit reserv---------------------------------------------------
        public bool editReservation(int reservId, int number, int clientId, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            string editQuery = "UPDATE `reservations` SET`roomNumber`=@rnm,`clientId`=@cid,`DateIn`=@din,`DateOut`=@dout WHERE 1 `reservId`= @rvid";
            ;
            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();

            //@rnm,@cid,@din,@dout
            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reservId;
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;

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


        //remov reserv---------------------------------------------------------------
        public bool removeReserv(int rsv_id)
        {
            MySqlCommand command = new MySqlCommand();
            string removeQuery = "DELETE FROM `reservations` WHERE `reservId`=@rvid";
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = rsv_id;
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
}
