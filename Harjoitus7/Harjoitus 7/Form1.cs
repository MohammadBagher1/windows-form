namespace Harjoitus_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                double laina, neste, vakutus, Muutkulut, Poltoneste, Pesut, Huollot, Renkat, VuosiKM, Kustannuket;
                neste = Convert.ToDouble(NesteTB.Text);
                vakutus = Convert.ToDouble(VakutusTB.Text);
                Muutkulut = Convert.ToDouble(MuutkulutTB.Text);
                Poltoneste = Convert.ToDouble(PoltonesteTB.Text);
                Pesut = Convert.ToDouble(PesutTB.Text);
                Huollot = Convert.ToDouble(HuollotTB.Text);
                Renkat = Convert.ToDouble(RenkatTB.Text);
                VuosiKM = Convert.ToDouble(VuosiKMTB.Text);
                laina = Convert.ToDouble(LainaTB.Text);
                Kustannuket = (laina + neste + vakutus + Muutkulut + Poltoneste + Pesut + Huollot + Renkat) / (VuosiKM / 12);
                VastausLB.Text = "Kustannukset kilometrit kohti ovat: " + Kustannuket;
                VastausLB.Visible = true;
            
        }
        
    }
}