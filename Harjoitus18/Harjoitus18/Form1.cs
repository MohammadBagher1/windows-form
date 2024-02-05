using System.Data;
namespace Harjoitus18
{
    public partial class Form1 : Form
    {
        DataTable oppilaitos = new DataTable();
        DataTable vastuuHenkilot = new DataTable();
        DataTable Yhteys = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void OppilaitosCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string viite = oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OID"].ToString();
            OsoiteLB.Text= oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OKatuosoite"].ToString();
            PostiNumeroLB.Text= oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OPostinumero"].ToString();
            PostitoimipaikkaLB.Text = oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OPostitoimipaikka"].ToString();
            PuhelinLB.Text= oppilaitos.Rows[OppilaitosCB.SelectedIndex]["OPuhelin"].ToString();

            Yhteys= vastuuHenkilot.Select("OID =" + viite ).CopyToDataTable();
            VastuhenkiloCB.DataSource= Yhteys;
            VastuhenkiloCB.DisplayMember = "VNimi";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            taytaoppilaitosTaulukko();
            taytavastuuhenkilotTaulukko();
            OppilaitosCB.DataSource= oppilaitos;
            OppilaitosCB.DisplayMember = "ONimi";
        }
        private void taytaoppilaitosTaulukko()
        {
            oppilaitos.Columns.Add("OID", typeof(int));
            oppilaitos.Columns.Add("ONimi");
            oppilaitos.Columns.Add("OKatuosoite");
            oppilaitos.Columns.Add("Opostinumero");
            oppilaitos.Columns.Add("OPostitoimipaikka");
            oppilaitos.Columns.Add("OPuhelin");

            oppilaitos.Rows.Add(1, "StadinAO", "Hattulantie 2", "00550", "Helsinki", "09 310 8600");
            oppilaitos.Rows.Add(2, "Omnia", "Armas Launiksen katu 9", "02650", "Espoo", "046 877 1371");
            oppilaitos.Rows.Add(3, "Varia", "R�lssitie 13", "01530", "Vantaa", "040 182 4668");
            oppilaitos.Rows.Add(4, "Keuda", "Sibeliuksenv�yl� 55 A", "04400", "J�rvenp��", "09 27 381");

        }
        private void taytavastuuhenkilotTaulukko()
        {
            vastuuHenkilot.Columns.Add("OID", typeof(int));
            vastuuHenkilot.Columns.Add("VNimi");
            vastuuHenkilot.Columns.Add("VTitteli");
            vastuuHenkilot.Columns.Add("VOsasto");
            vastuuHenkilot.Columns.Add("VSahkoposti");
            vastuuHenkilot.Columns.Add("VPuhelin");

            vastuuHenkilot.Rows.Add(1, "Sirpa Lindroos", "Rehtori", "Kampus 1", "sirpa.lindroos@hel.fi", "050 540 4434");
            vastuuHenkilot.Rows.Add(1, "Hanna Laurila", "Rehtori", "Kaupus 2", "hanna.laurila@hel.fi", "040 676 5583");
            vastuuHenkilot.Rows.Add(1, "Annele Ranta", "Rehtori", "Kampus 3", "annele.ranta@hel.fi", "040 631 5667");
            vastuuHenkilot.Rows.Add(1, "Eeva Sahlman", "Rehtori", "Kampus 4", "eeva.sahlman@hel.fi", "040 336 1017");
            vastuuHenkilot.Rows.Add(1, "Marko Aaltonen", "Rehtori", "Kampus 5", "marko.aaltonen@hel.fi", "050 511 8115");
            vastuuHenkilot.Rows.Add(2, "Tuula Antola", "Koulutuskuntayhtym�n johtaja", "Yleishallinto", "tuula.antola@omnia.fi", "");
            vastuuHenkilot.Rows.Add(2, "Tapio Siukonen", "Hallintojohtaja", "Yleishallinto", "tapio.siukonen@omnia.fi", "044 369 6600");
            vastuuHenkilot.Rows.Add(2, "Tuukko Soini", "Kehitt�misjohtaja", "Yleishallinto", "tuukka.soini@omnia.fi", "046 877 2952");
            vastuuHenkilot.Rows.Add(2, "Riikka-Maria Yli-Suomu", "Liiketoimintajohtaja", "Elinvoima- ja ty�llisyyspalvelut", "riikka-maria.yli-suomu@omnia.fi", "050 348 6544");
            vastuuHenkilot.Rows.Add(2, "Maija Aaltola", "Rehtori", "Koulutus- ja opiskelijapalvelut", "maija-aaltola@omnia.fi", "050 384 9354");
            vastuuHenkilot.Rows.Add(2, "Kai Iivari", "Talousjohtaja", "Talous ja hankintapalvelut", "kai.iivari@omnia.fi", "0400 306 691");
            vastuuHenkilot.Rows.Add(2, "P�ivi Korhonen", "Viestint�johtaja", "Viestint�- ja markkinointipalvelut", "paivi.korhonen@omnia.fi", "040 126 7599");
            vastuuHenkilot.Rows.Add(3, "Pekka Tauriainen", "Rehtori", "", "pekka.tauriainen@vantaa.fi", "050 312 4514");
            vastuuHenkilot.Rows.Add(3, "Anne Heinonen", "Ty�el�m�palvelup��llikk�", "", "anne.heinonen@vantaa.fi", "040 524 1242");
            vastuuHenkilot.Rows.Add(3, "Tuula Kiistinen", "Yhteisten palveluiden p��llikk�", "", "tuula.kiiskinen@vantaa.fi", "040 193 9048");
            vastuuHenkilot.Rows.Add(4, "Tiina Halmevuo", "Kuntayhtym�n johtaja", "Hallinto- ja johtamispalvelut", "tiina.halmevuo@keuda.fi", "050 336 9709");
            vastuuHenkilot.Rows.Add(4, "Anna Mari Leinonen", "Rehtori", "Hallinto", "annamari.leinonen@keuda.fi", "040 174 4523");
            vastuuHenkilot.Rows.Add(4, "Anne Vuorinen", "Johtaja", "Yritys- ja elinvoimapalvelut", "anne.vuorinen@keuda.fi", "050 415 0974");
            vastuuHenkilot.Rows.Add(4, "Hanna Nyr�nen", "Viestint�- ja markkinointip��llikk�", "Viestint�palvelut", "hanna.nyronen@keuda.fi", "040 521 8428");
            vastuuHenkilot.Rows.Add(4, "Maarit Flinck", "Asianhallintap��llikk�", "Hallinto- ja johtamispalvelut", "maarit.flinck@keuda.fi", "0500 837 357");
        }

        private void VastuhenkiloCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitteliLB.Text= Yhteys.Rows[VastuhenkiloCB.SelectedIndex]["VTitteli"].ToString();
            OsastoLB.Text = Yhteys.Rows[VastuhenkiloCB.SelectedIndex]["VOsasto"].ToString();
            SahkopostiLB.Text = Yhteys.Rows[VastuhenkiloCB.SelectedIndex]["VSahkoposti"].ToString();
            puhLB.Text = Yhteys.Rows[VastuhenkiloCB.SelectedIndex]["VPuhelin"].ToString();


        }

        private void PostimapaikkaLB_Click(object sender, EventArgs e)
        {

        }
    }
}