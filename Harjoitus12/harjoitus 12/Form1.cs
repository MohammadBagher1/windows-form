using System;
using System.Windows.Forms;

namespace harjoitus_12
{
    public partial class VastausLomakeForm : Form
    {
        int laskuri = 0;
        int oikein = 0;
        string[] vastaukset = new string[11];
        string[] oikeatVastaukset = new string[] {"", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        
        public VastausLomakeForm()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            VastausBRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            VastausCRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            VastausDRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
        }
        private void radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri <= 10)
            {
                RadioButton radioButton= (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                KysymysLB.Text = "vastaus " + (laskuri) + " kysymyksen: ";
                laskuri++;
            }
            else
            {
                VastausLB.Text = "";
                VastausARB.Enabled= false;
                VastausBRB.Enabled= false;
                VastausCRB.Enabled= false;
                VastausDRB.Enabled= false;
                for(int j = 1; j <= 10; j++)
                {
                    if(vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();

        }
        private void TyhjaaVastaus()
        {
            if (VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--;
            }
            if (VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }
            if (VastausCRB.Checked == true) 
            {
                VastausCRB.Checked = false;
                laskuri--;
            }
            if (VastausDRB.Checked == true) 
            {
                VastausDRB.Checked = false;
                laskuri--;
            }
        }
        private void VastausLB_Click(object sender, EventArgs e)
        {

        }
    }
}
