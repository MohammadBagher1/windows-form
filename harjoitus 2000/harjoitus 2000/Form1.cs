using harjoitus_2000;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace CRUDNET
{

    public partial class YllapitoForm : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();
        public YllapitoForm()
        {
            InitializeComponent();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            etunimiTB.Text = "";
            sukunimiTB.Text = "";
            puhelinTB.Text = "";
            sahkopostiTB.Text = "";
            opiskelijanroTB.Text = "";
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String puh = puhelinTB.Text;
            String email = sahkopostiTB.Text;
            int oNro = Int32.Parse(opiskelijanroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, Puhelin, Sähköposti ja Opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaOpiskelija = opiskelija.lisaaOpiskelija(enimi, snimi, puh, email, oNro);
                if (lisaaOpiskelija)
                {
                    MessageBox.Show("Uusi opiskelijaa lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void paivitaBT_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String puh = puhelinTB.Text;
            String email = sahkopostiTB.Text;
            int oNro = Int32.Parse(opiskelijanroTB.Text);
            int oid = Int32.Parse(idTB.Text);


            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - OID, Etu- ja sukunimi, Puhelin, Sähköposti ja Opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaOpiskelija = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puh, email, oNro);
                if (muokkaaOpiskelija)
                {
                    MessageBox.Show("Opiskelija muokattu onnistuneesti", "Opiskelijan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty muokkaamaan", "Opiskelijan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            int ktunnus = Int32.Parse(idTB.Text);
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }

        private void YllapitoForm_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
            TietotauluDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 125;
        }

        private void Tietotaulu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            etunimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            sukunimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhelinTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            sahkopostiTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            opiskelijanroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
            idTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}