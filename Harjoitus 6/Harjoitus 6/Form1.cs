namespace Harjoitus_6
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "M" && SalasanaTB.Text == "MB")
            {
                SalasanaOikeinPanel.Visible = true;
                SalasanaPanel.Visible = false;
            }
            else
            {
                VirheviestiLB.Text = "käyttäjätunnus tai salasana virhellinen!";
                VirheviestiLB.Visible = true;
            }
        }
    }
}