namespace harjoitus_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void VastausLB_Click(object sender, EventArgs e)
        {

        }

        private void buttonBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(numeroTB.Text);
            if (CelciusRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                VastausLB.Text = asteet + " celcius on " + vastaus + " fahrenheit astetta ";
                VastausLB.Visible = true;
            }
            else if(FahrenheitRB.Checked)
            {
                vastaus = (asteet - 32) / 1.8;
                VastausLB.Text = asteet + " fahrenheit on " + vastaus + " cilsius astetta";
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = " et antanut lukua tai annoit v‰‰rn astetta ";
                VastausLB.Visible = true;
            }
        }
    }
}