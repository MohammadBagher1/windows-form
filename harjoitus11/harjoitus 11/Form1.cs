namespace harjoitus_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBT_Click(object sender, EventArgs e)
        {
            PNoppa(Nopa1PB);
            PNoppa(Nopa2PB);
        }
        private void PNoppa(PictureBox NoppaBox)
        {
            Random satunnainen = new Random ();
            int noppa  = satunnainen.Next (1, 7);
            switch (noppa)
            {
                case 0:
                    NoppaBox.Image = Properties.Resources.dice01;
                    break;
                    case 1:
                    NoppaBox.Image = Properties.Resources.dice02;
                    break;
                    case 2:
                    NoppaBox.Image = Properties.Resources.dice03;
                    break;
                    case 3:
                    NoppaBox.Image = Properties.Resources.dice04;
                    break;  
                    case 4:
                    NoppaBox.Image = Properties.Resources.dice05;
                    break;
                    case 5:
                    NoppaBox.Image = Properties.Resources.dice06;
                    break;
                    
                    
            }
        }
    }
}