using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelli_tehtava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `username`=@usn AND `password`=@pass";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = kayttajaTB.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = SalasanaTB.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // if the username and the password exists
            if (table.Rows.Count > 0)
            {
                // show the main form
                this.Hide();
                Main_Form mform = new Main_Form();
                mform.Show();
            }
            else
            {
                if (kayttajaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (SalasanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username Or Password Doesn't Exists", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)

{

    Application.Exit();

}



private void manageClientsToolStripMenuItem_Click(object sender, EventArgs e)

{

    ManageClientsForm manageCF = new ManageClientsForm();

    manageCF.ShowDialog();

}



private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)

{

    ManageRoomsForm manageRF = new ManageRoomsForm();

    manageRF.ShowDialog();

}



private void manageReservationsToolStripMenuItem_Click(object sender, EventArgs e)

{

    ManageReservationsForm manageRSVF = new ManageReservationsForm();

    manageRSVF.ShowDialog();

}

    