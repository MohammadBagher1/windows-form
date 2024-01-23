namespace Harjoitus__5
{
    public partial class Form1 : Form
    {
        List<int> jono = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    Int32.Parse(uusiLukuTB.Text);
                    if (uusiLukuTB.Text == "-999")
                    {
                        uusiLukuTB.Text = "";
                        int[] taulukko = jono.ToArray();
                        Array.Sort(taulukko);
                        foreach (var jasen in taulukko)
                        {
                            VastausLB.Text += jasen + " ";
                        }
                        VastausLB.ForeColor = System.Drawing.Color.Black;
                        VastausLB.Visible = true;
                    }
                    else
                    {
                        VastausLB.Text = "";
                        VastausLB.Visible = false;
                        jono.Add(Int32.Parse(uusiLukuTB.Text));
                        uusiLukuTB.Text = "";
                    }
                }
                catch
                {
                    VastausLB.Text = "Virhe!";
                    VastausLB.Visible = true;
                    VastausLB.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}



 

    