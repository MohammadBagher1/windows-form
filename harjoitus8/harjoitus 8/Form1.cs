namespace harjoitus_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {


            if (int.TryParse(RoomaTB.Text, out int luku) && luku >= 1 && luku <= 3999)
            {
                string roomalainenNumero = MuunnaRoomalaiseksi(luku);
                VastausLB.Text = $"Roomalainen numero: {roomalainenNumero}";
            }
            else
            {
                VastausLB.Text = "Virheliinen syöte anna numero 0-3999";
            }
        }

        private string MuunnaRoomalaiseksi(int luku)
        {
            string[] roomalaisetSymbolit = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            int[] arvot = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

            string roomalainenNumero = "";

            for (int i = arvot.Length - 1; i >= 0; i--)
            {
                while (luku >= arvot[i])
                {
                    roomalainenNumero += roomalaisetSymbolit[i];
                    luku -= arvot[i];
                }
            }

            VastausLB.Visible = true;

            return roomalainenNumero;
        }
    }
}
    
