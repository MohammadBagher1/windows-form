using System.Drawing.Design;

namespace Harjoitus_4_
{
    public partial class IkaForm : Form
    {
        public IkaForm()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SyntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuosinaLB.Text=Math.Ceiling(erotus / 365.25) + "vuotta";
            KuukausinaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + "kuukauta";
            PaivinaLB.Text = (erotus + "p�iv��");
            TunteinaLB.Text = (erotus * 24 + "tuntia");
            MinuteinaLB.Text = (erotus * 24 * 60 + "minuutteina");
            SekunteinaLB.Text = (erotus * 24 * 60 * 60 + "sekunteina");
            VuosinaLB.Visible= true;
            KuukausinaLB.Visible= true;
            PaivinaLB.Visible = true;
            TunteinaLB.Visible= true;
            MinuteinaLB.Visible= true;
            SekunteinaLB.Visible = true;


        }
    }
}