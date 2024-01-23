namespace harjoitus_10
{
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
        }

        private void TulosLB_Click(object sender, EventArgs e)
        {

        }

        private void buttonBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0, painoindeksi;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            painoindeksi = Math.Round( paino / (pituus * pituus ), 2 );
            if(painoindeksi < 18.5)
            {
                VastausLB.Text = "painoindeksi on " + painoindeksi;
                VastausLB.ForeColor = Color.Blue;
                TulosLB.Text = "alipaino";
                TulosLB.ForeColor = Color.Blue;
                VastausLB.Visible = true;
                TulosLB.Visible = true;
            }
            else if (painoindeksi < 25)
            {
                VastausLB.Text = "painoindeksi on " + painoindeksi;
                VastausLB.ForeColor = Color.Green;
                TulosLB.Text = "Normalipaino";
                TulosLB.ForeColor = Color.Green;
                VastausLB.Visible = true;
                TulosLB.Visible = true;
            }
            else if (painoindeksi < 40)
            {
                VastausLB.Text = "painoindeksi on " + painoindeksi;
                VastausLB.ForeColor = Color.Yellow;
                TulosLB.Text = "Ylipaino";
                TulosLB.ForeColor = Color.Yellow;
                VastausLB.Visible = true;
                TulosLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "painoindeksi on " + painoindeksi;
                VastausLB.ForeColor = Color.Red;
                TulosLB.Text = "Huomattava ylipaino";
                TulosLB.ForeColor = Color.Red;
                VastausLB.Visible = true;
                TulosLB.Visible = true;
            }


        }
    }
}