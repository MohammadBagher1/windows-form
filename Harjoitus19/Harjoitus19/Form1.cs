namespace Harjoitus19
{
    public partial class RuokalistaForm : Form
    {
        public RuokalistaForm()
        {
            InitializeComponent();
        }

        private void RuokalistaForm_load(object sender, EventArgs e)
        {
            meistaLB.Text = "Keudan oppilaskunnan kahvilla palvelee luokassa 281 v‰lituntisin \n";
            meistaLB.Text += "9:00 - 15:00 joka p‰iv‰‰ maanantaista perjantaisin\n";
            meistaLB.Text += "9:00 - 13:00 \n\n Keudan oppilaskunna kahvilasta saa l‰mpinen\n";
            meistaLB.Text += "juomien lis‰ksi virvokkeita sek‰ pient‰ purtavaa ja makeisia\n";
            meistaLB.Text += "Tervetuola\n";
            meistaLB.Font = new Font("Arial", 12);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = true;
            juomatPL.Visible = false;
            ruoatPL.Visible = false;
            koriPL.Visible = false;
            herkutPL.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            juomatPL.Visible = false;
            ruoatPL.Visible = true;
            koriPL.Visible = false;
            herkutPL.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            juomatPL.Visible = true;
            ruoatPL.Visible = false;
            koriPL.Visible = false;
            herkutPL.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            juomatPL.Visible = false;
            ruoatPL.Visible = false;
            koriPL.Visible = false;
            herkutPL.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            juomatPL.Visible = false;
            ruoatPL.Visible = false;
            koriPL.Visible = true;
            herkutPL.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();         
        }
    }
}