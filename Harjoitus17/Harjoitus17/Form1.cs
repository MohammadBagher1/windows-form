using System;
using System.IO;
using System.Windows.Forms;

namespace Harjoitus17
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UusiTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text))
                {
                    MessageBox.Show("Sinun tulee tallentaa ensin!");
                }
                else
                {
                    TekstiTB.Text = string.Empty;
                    Text = "Nimetön";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void TallennaTiedosto()
        {
            try
            {
                if (string.IsNullOrEmpty(Text)) // Check if the file has been saved before
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Tekstitiedosto (*.txt)|*.txt|Rikas tekstiformaatti (*.rtf)|*.rtf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, TekstiTB.Text);
                        Text = saveFileDialog.FileName; // Set the form's title to the saved file name
                    }
                }
                else
                {
                    // File has already been saved, so just save changes
                    File.WriteAllText(Text, TekstiTB.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }


        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UusiTiedosto();
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UusiTiedosto();
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tekstitiedosto (*.txt)|*.txt|Rikas tekstiformaatti (*.rtf)|*.rtf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TekstiTB.Text = File.ReadAllText(openFileDialog.FileName);
                Text = openFileDialog.FileName;
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TallennaTiedosto();
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                TekstiTB.Font = fontDialog.Font;
            }
        }
    }
}
