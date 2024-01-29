namespace Harjoitus16
{
    public partial class CountDownForm : Form
    {
        private int kokonaisaika;

        public CountDownForm()
        {
            InitializeComponent();
            for (int i = 0; i < 60; i++)
            {
                MinuutitCB.Items.Add(i.ToString());
                SekunnitCB.Items.Add(i.ToString());
            }
        }

        private void StartStopButtonToggle(bool startEnabled, bool stopEnabled)
        {
            StartBT.Enabled = startEnabled;
            StopBT.Enabled = stopEnabled;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartStopButtonToggle(false, true);
            kokonaisaika = int.Parse(MinuutitCB.SelectedItem.ToString()) * 60
                            + int.Parse(SekunnitCB.SelectedItem.ToString());
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartStopButtonToggle(true, false);
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika % 60;
                AikaLB.Text = $"{minuutit:D2}:{sekunnit:D2}";
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui");
            }
        }
    }
}
