using System.Diagnostics;
namespace harjoitus15
{
    public partial class SekkariFM : Form
    {
        private Stopwatch sekkari = new Stopwatch();
        public SekkariFM()
        {
            InitializeComponent();
        }

        private void AikaLB_Click(object sender, EventArgs e)
        {

        }

        private void kaynistaBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void LopetaBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }
        private void SekkariFM_Load(object sender, EventArgs e)
        {
            sekkari = new Stopwatch();
        }
        private void AjanottoTM_Tick(object sender, EventArgs e)
        {
            AikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }

        
    }
}