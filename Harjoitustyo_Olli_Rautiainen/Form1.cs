using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitustyo_Olli_Rautiainen
{
    //Sovellus pitää kirjaa palloilulajin (jalkapallo, jääkiekko, salibandy) erien ja peliajan kulusta sekä pelin tilanteesta.
    //tilastot otteluista ja joukkueen tilasto tallennetaan sovelluksen bin\debug\ kansioon (.json)

    public partial class Form1 : Form
    {
        public string aika = DateTime.Today.ToShortDateString();
        public OtteluTilasto peli;
        public JoukkueTilasto j;
        public int maalitKoti;
        public int maalitVieras;
        public int syototKoti;
        public int syototVieras;
        public int eraSekuntti;
        public int eraMinuutti;
        public int kokonaisAikaSekuntti;
        public int kokonaisAikaMinuutti;
        MessageBoxButtons buttonsYesNo = MessageBoxButtons.YesNo;
        MessageBoxButtons buttonsYesNoCancel = MessageBoxButtons.YesNoCancel;
        DialogResult result;
        public string normaalinopeus = "Normaali nopeus";

        public string otteluFile = "Ottelu";// tallennetaan harjoitustyön bin\debug\Ottelu+aloitusaika.json
        public string joukkueTilastoFile = "Joukkuetilastot"; // tallennetaan harjoitustyön bin\debug\Joukkuetilastot.json

        public List<OtteluTilasto> ottelu;
        public List<JoukkueTilasto> joukkuetilasto;
        

        public Form1()
        {
            InitializeComponent();

            Aloitus();
        }

        //joukkueiden tilastot ladataan ohjelman käynnistyksessä
        private void Aloitus()
        {
            try
            {
                if (File.Exists(joukkueTilastoFile))
                {
                    joukkuetilasto = LueJoukkueTilastoJSON();
                    dgvTilastot.DataSource = joukkuetilasto;

                }
                else
                {
                    joukkuetilasto = new List<JoukkueTilasto>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ottelu = new List<OtteluTilasto>();
            dgvOttelu.DataSource = ottelu;

            dtpAloitusAika.CustomFormat = "dd.MM.yyy-HH.mm";
            dtpAloitusAika.Format = DateTimePickerFormat.Custom;
            tsStatuslbl.Text = "Aloita valitsemalla laji ja joukkueet";
        }


        //ottelun tilastojen tallennus
        public void TallennaOttelunJSON(List<OtteluTilasto> input)
        {
            string json = JsonConvert.SerializeObject(input);
            System.IO.File.WriteAllText(otteluFile +dtpAloitusAika.Text +".json", json);
        }

        //joukkueen tilastojen tallennus
        public void TallennaJoukkueTilastoJSON(List<JoukkueTilasto> input)
        {
            string json = JsonConvert.SerializeObject(input);
            System.IO.File.WriteAllText(joukkueTilastoFile, json);
        }

        //joukkueiden tilastot ladataan ohjelman käynnistyksessä
        public List<JoukkueTilasto> LueJoukkueTilastoJSON()
        {
            if (File.Exists(joukkueTilastoFile))
            {
                using (StreamReader r = new StreamReader(joukkueTilastoFile))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<JoukkueTilasto>>(json);
                }
            }
            else
            {
                return null;
            }
        }


        //HUOM! TilastoStructit.cs
        //tilastojen tallennukseen
        public void OtteluTilastot()
        {
            peli.aika = tbMaaliAika.Text;
            peli.joukkue = cbMaaliJoukkue.Text;
            peli.maali = lblMaalitKoti.Text + "-" + lblMaalitVieras.Text;
            peli.etunimi = tbMaalintekijaEtunimi.Text;
            peli.sukunimi = tbMaalintekijaSukunimi.Text;
            peli.numero = tbMaalintekijaNro.Text;
            peli.syottaja1 = "1. Syöttäjä";
            peli.s1etunimi = tbSyottaja1Etunimi.Text;
            peli.s1sukunimi = tbSyottaja1Sukunimi.Text;
            peli.s1numero = tbSyottaja1Nro.Text;
            peli.syottaja2 = "2. Syöttäjä";
            peli.s2etunimi = tbSyottaja2Etunimi.Text;
            peli.s2sukunimi = tbSyottaja2Sukunimi.Text;
            peli.s2numero = tbSyottaja2Nro.Text;
            peli.alkuaika = dtpAloitusAika.Text;
        }

        public void JoukkueTilastot(string kumpi)
        {
            string tulos;

            if (rbtnJalkapallo.Checked == true)
            {
                j.laji = "Jalkapallo";
            }
            else if (rbtnJaakiekko.Checked == true)
            {
                j.laji = "Jääkiekko";
            }
            else if (rbtnSalibandy.Checked == true)
            {
                j.laji = "Salibandy";
            }

            if (kumpi == "koti")
            {
                j.joukkue = cbJoukkue1.Text;
                tulos = Tulos();
                if (tulos == "1")
                {
                    j.tulos = "Voitto";
                }
                else if (tulos == "x")
                {
                    j.tulos = "Tasapeli";
                }
                else if (tulos ==  "2")
                {
                    j.tulos = "Häviö";
                }
                j.maalit = lblMaalitKoti.Text;
                j.syotot = syototKoti.ToString();
                j.aika = dtpAloitusAika.Text;
            }

            if (kumpi == "vieras")
            {
                j.joukkue = cbJoukkue2.Text;
                tulos = Tulos();
                if (tulos == "1")
                {
                    j.tulos = "Häviö";
                }
                else if (tulos == "x")
                {
                    j.tulos = "Tasapeli";
                }
                else if (tulos == "2")
                {
                    j.tulos = "Voitto";
                }

                j.maalit = lblMaalitVieras.Text;
                j.syotot = syototVieras.ToString();
                j.aika = dtpAloitusAika.Text;
            }
        }

        //palauttaa pelin tuloksen: voitto, tasapeli, häviö
        private string Tulos()
        {

            int koti = int.Parse(lblMaalitKoti.Text);
            int vieras = int.Parse(lblMaalitVieras.Text);
            string lopputulos = "Ei tulosta";

            if (koti > vieras)
            {
                lopputulos = "1";
            }
            else if (koti == vieras)
            {
                lopputulos = "x";
            }
            else if (koti < vieras)
            {
                lopputulos = "2";
            }
            return lopputulos;
        }

        //koti ja vierasjoukkueen tilastojen tallentaminen
        public void JoukkuetilastonKutsu()
        {
            string kumpi = "koti";
            JoukkueTilastot(kumpi);
            joukkuetilasto.Add(j);
            kumpi = "vieras";
            JoukkueTilastot(kumpi);
            joukkuetilasto.Add(j);
        }

        //pelin ajan päättyessä tallennetaan ottelun ja joukkueen tilastot
        public void Loppuaika()
        {

            peli.loppuaika = DateTime.Now.ToString();
            ottelu.Add(peli);
            TallennaOttelunJSON(ottelu);//tiedostoon

            JoukkuetilastonKutsu();
            TallennaJoukkueTilastoJSON(joukkuetilasto);
        }

        //lajin valinta alustaa kellot ja voit valita joukkueet
        private void rbtnLaji_CheckedChanged(object sender, EventArgs e)
        {
                if (rbtnJalkapallo.Checked)
                {
                    eraMinuutti = 0;
                    eraSekuntti = 0;
                    lblEraAika.Text = "00:00";
                    kokonaisAikaMinuutti = 0;
                    kokonaisAikaSekuntti = 0;
                    lblKokonaisaika.Text = "00:00";
                    cbJoukkue1.Enabled = true;
                    cbJoukkue2.Enabled = true;
                }
                else if (rbtnJaakiekko.Checked)
                {
                    eraMinuutti = 20;
                    eraSekuntti = 0;
                    lblEraAika.Text = "20:00";
                    kokonaisAikaMinuutti = 60;
                    kokonaisAikaSekuntti = 0;
                    lblKokonaisaika.Text = "60:00";
                    cbJoukkue1.Enabled = true;
                    cbJoukkue2.Enabled = true;
                }
                else if (rbtnSalibandy.Checked)
                {
                    eraMinuutti = 15;
                    eraSekuntti = 0;
                    lblEraAika.Text = "15:00";
                    kokonaisAikaMinuutti = 45;
                    kokonaisAikaSekuntti = 0;
                    lblKokonaisaika.Text = "45:00";
                    cbJoukkue1.Enabled = true;
                    cbJoukkue2.Enabled = true;
                }
        }


            //Kun joukkueet ovat valittuna, play,pause ja stop painikkeet aktivoituvat
            private void cbJoukkueet_TextChanged(object sender, EventArgs e)
            {
                if (cbJoukkue1.Text != "Valitse joukkue" && cbJoukkue2.Text != "Valitse joukkue")
                {
                    btnPlay.Enabled = true;
                    btnPause.Enabled = true;
                    btnStop.Enabled = true;
                    lblEra.Text = "1";
                    tsStatuslbl.Text = "Paina Play aloittaaksesi pelin";
                }
            }

        //Play painallus käynnistää valitun lajin timerin ja ottelu alkaa.
        
        
        

        //Valitaan timer sen mukaan mikä laji valittu
        private void timer_Tick(object sender, EventArgs e)
        {
            if (rbtnJalkapallo.Checked == true)
            {
                JalkapalloTimer();
            }
            else if (rbtnJaakiekko.Checked == true)
            {
                JaakiekkoTimer();
            }
            else if (rbtnSalibandy.Checked == true)
            {
                SalibandyTimer();
            }
        }

        //lajienmukaiset timerit. Erien välissä voi valita jatketaanko seuraavaa erää heti.

        //Jalkapallo: kaksi (2) 45 minuutin erää, otteluaika yhteensä 90 minuuttia, aika kasvaa.
        private void JalkapalloTimer()
        {
                eraSekuntti++;
                kokonaisAikaSekuntti = eraSekuntti;

                if (eraSekuntti == 60)
                {
                    eraMinuutti++;
                    kokonaisAikaMinuutti++;
                    eraSekuntti = 0;
                }

                kokonaisAikaSekuntti = eraSekuntti;

                lblEraAika.Text = eraMinuutti.ToString("00") + ":" + eraSekuntti.ToString("00");
                lblKokonaisaika.Text = kokonaisAikaMinuutti.ToString("00") + ":" + kokonaisAikaSekuntti.ToString("00");

                if (kokonaisAikaMinuutti == 45 && eraSekuntti == 0)
                {
                    timer.Enabled = false;
                    lblEra.Text = "2";
                    DialogResult result;
                    result = MessageBox.Show("Ensimmäinen puoliaika päättyi!", "Aloitetaanko toinen puoliaika heti?", buttonsYesNo);
                    eraSekuntti = 0;
                    eraMinuutti = 0;
                    timer.Interval = 1000;
                    btnKelaa.Text = normaalinopeus;
                    if (result == DialogResult.Yes)
                    {
                        timer.Enabled = true;
                    }
                }
                if (kokonaisAikaMinuutti == 90)
                {
                    timer.Enabled = false;
                    string lopputulos = "Tulos: " + cbJoukkue1.Text + " " + lblMaalitKoti.Text + " - " + lblMaalitVieras.Text + " " + cbJoukkue2.Text;
                    Loppuaika();
                    MessageBox.Show(lopputulos, "Peli päättyi!");
                }
        }

        //Jääkiekko: kolme(3) 20 minuutin erää, otteluaika yhteensä 60 minuuttia, aika pienenee.
        private void JaakiekkoTimer()
            {
                eraSekuntti--;

                if (eraSekuntti == -1)
                {
                    eraSekuntti = 59;
                    eraMinuutti--;
                    kokonaisAikaMinuutti--;
                }

                kokonaisAikaSekuntti = eraSekuntti;

                lblEraAika.Text = eraMinuutti.ToString("00") + ":" + eraSekuntti.ToString("00");
                lblKokonaisaika.Text = kokonaisAikaMinuutti.ToString("00") + ":" + kokonaisAikaSekuntti.ToString("00");

                if (kokonaisAikaMinuutti == 40 && eraSekuntti == 0)
                {
                    timer.Enabled = false;
                    lblEra.Text = "2";
                    DialogResult result;
                    result = MessageBox.Show("Ensimmäinen erä päättyi!", "Aloitetaanko toinen erä heti?", buttonsYesNo);
                    eraSekuntti = 0;
                    eraMinuutti = 20;
                    timer.Interval = 1000;
                    btnKelaa.Text = normaalinopeus;
                    if (result == DialogResult.Yes)
                    {
                        timer.Enabled = true;
                    }
                }

                if (kokonaisAikaMinuutti == 20 && eraSekuntti == 0)
                {
                    timer.Enabled = false;
                    lblEra.Text = "3";
                    DialogResult result;
                    result = MessageBox.Show("Toinen erä päättyi!", "Aloitetaanko kolmas erä heti?", buttonsYesNo);
                    eraSekuntti = 0;
                    eraMinuutti = 20;
                    timer.Interval = 1000;
                    btnKelaa.Text = normaalinopeus;
                    if (result == DialogResult.Yes)
                    {
                        timer.Enabled = true;
                    }
                }

                if (kokonaisAikaMinuutti == 0 && eraSekuntti == 0)
                {
                    timer.Enabled = false;
                    string lopputulos = "Tulos: " + cbJoukkue1.Text +" " + lblMaalitKoti.Text + " - " + lblMaalitVieras.Text +" " + cbJoukkue2.Text;
                    Loppuaika();
                    MessageBox.Show(lopputulos,"Peli päättyi!");
                }
            }

        //Salibandy(divari - tasolla): kolme(3) 15 minuutin erää, otteluaika yhteensä 45 minuuttia, aika pienenee.
        private void SalibandyTimer()
        {
                eraSekuntti--;

                if (eraSekuntti == -1)
                {
                    eraSekuntti = 59;
                    eraMinuutti--;
                    kokonaisAikaMinuutti--;
                }

                kokonaisAikaSekuntti = eraSekuntti;

                lblEraAika.Text = eraMinuutti.ToString("00") + ":" + eraSekuntti.ToString("00");
                lblKokonaisaika.Text = kokonaisAikaMinuutti.ToString("00") + ":" + kokonaisAikaSekuntti.ToString("00");

                if (kokonaisAikaMinuutti == 30 && eraSekuntti == 0)
                {
                    timer.Enabled = false;
                    lblEra.Text = "2";
                    DialogResult result;
                    result = MessageBox.Show("Ensimmäinen erä päättyi!", "Aloitetaanko toinen erä heti?", buttonsYesNo);
                    eraSekuntti = 0;
                    eraMinuutti = 15;
                    timer.Interval = 1000;
                    btnKelaa.Text = normaalinopeus;
                    if (result == DialogResult.Yes)
                    {
                        timer.Enabled = true;
                    }
                }

                if (kokonaisAikaMinuutti == 15 && eraSekuntti == 0)
                {
                    timer.Enabled = false;
                    lblEra.Text = "3";
                    DialogResult result;
                    result = MessageBox.Show("Toinen erä päättyi!", "Aloitetaanko kolmas erä heti?", buttonsYesNo);
                    eraSekuntti = 0;
                    eraMinuutti = 15;
                    timer.Interval = 1000;
                    btnKelaa.Text = normaalinopeus;
                    if (result == DialogResult.Yes)
                    {
                        timer.Enabled = true;
                    }
                }

                if (kokonaisAikaMinuutti == 0 && eraSekuntti == 0)
                {
                    timer.Enabled = false;
                    string lopputulos = "Tulos: " + cbJoukkue1.Text + " " + lblMaalitKoti.Text + " - " + lblMaalitVieras.Text + " " + cbJoukkue2.Text;
                    Loppuaika();
                    MessageBox.Show(lopputulos, "Peli päättyi!");
                }
        }
        
        //Play painike estää päivämäärän, joukkueiden ja lajin muuttamisen pelin aikana ja käynnistää halutun lajin timerin
            private void btnPlay_Click(object sender, EventArgs e)
            {
                cbJoukkue1.Enabled = false;
                cbJoukkue2.Enabled = false;
                rbtnJalkapallo.Enabled = false;
                rbtnJaakiekko.Enabled = false;
                rbtnSalibandy.Enabled = false;
                dtpAloitusAika.Enabled = false;
                btnSyotaTilasto.Enabled = true;
                btnKelaa.Enabled = true;
                timer.Enabled = true;
                tsStatuslbl.Text = "Peli käynnissä";
            }

            //pause pysäyttää kellon ja asettaa nopeuden normaaliksi. Uudelleenpainallus jatkaa peliä.
            private void btnPause_Click(object sender, EventArgs e)
            {
            if (timer.Enabled == true)
            {
                timer.Enabled = false;
                timer.Interval = 1000;
                btnKelaa.Text = normaalinopeus;
                tsStatuslbl.Text = "Pysäytetty";
                btnKelaa.Enabled = false;
            }
            else
            {
                timer.Interval = 1000;
                timer.Enabled = true;
                btnKelaa.Enabled = true;
                tsStatuslbl.Text = "Peli käynnissä";
            }
            }

            //Kelaa ottelunopeutta 2, 4, 8, 16 tai 32 kertaisena.
            private void btnKelaa_Click(object sender, EventArgs e)
            {
                timer.Interval /= 2;

                if (timer.Enabled == true)
                {
                    if (btnKelaa.Text == normaalinopeus)
                    {
                        btnKelaa.Text = "X2";
                    tsStatuslbl.Text = "Peli Käynnissä, nopeutettu";
                    }
                    else if (btnKelaa.Text == "X2")
                    {
                        btnKelaa.Text = "X4";
                    }
                    else if (btnKelaa.Text == "X4")
                    {;
                        btnKelaa.Text = "X8";
                    }
                    else if (btnKelaa.Text == "X8")
                    {
                        btnKelaa.Text = "X16";
                    }
                    else if (btnKelaa.Text == "X16")
                    {
                        btnKelaa.Text = "X32";
                    }
                    else
                    {
                        timer.Interval = 1000;
                        btnKelaa.Text = normaalinopeus;
                    tsStatuslbl.Text = "Peli käynnissä";
                    }
                }
            }

            //Stop painike pysäyttää kellon ja tuo näkyville messageboxin. Voit valita tallennetaanko tiedot (Kyllä), vai ei (Ei), vai jatketaanko peliä (Peruuta).
            private void btnStop_Click(object sender, EventArgs e)
            {
                timer.Enabled = false;
            tsStatuslbl.Text = "Pysäytetty";
                result = MessageBox.Show("Haluatko tallentaa tilastot? Jatka ottelua painamalla Peruuta.", "Ottelu lopetetaan!", buttonsYesNoCancel);
                if (result == DialogResult.Yes)
                {
                    Loppuaika();
                    Nollaus();
                }
                if (result == DialogResult.No)
                {
                    Nollaus();
                }
                if (result == DialogResult.Cancel)
                {
                    timer.Enabled = true;
                }
            }


            //maalintekijän ja kahden syöttäjän tiedot
            private void btnMaalinTiedot_Click(object sender, EventArgs e)
            {
                timer.Enabled = false;
                tsStatuslbl.Text = "Syötä maalintekijä ja syöttäjät";
                
                tbMaaliAika.Text = lblKokonaisaika.Text;

                cbMaaliJoukkue.Enabled = true;
                cbMaaliJoukkue.Items.Add(cbJoukkue1.Text);
                cbMaaliJoukkue.Items.Add(cbJoukkue2.Text);

                tbMaalintekijaEtunimi.Enabled = true;
                tbMaalintekijaSukunimi.Enabled = true;
                tbMaalintekijaNro.Enabled = true;
                btnTallenna.Enabled = true;
                btnPeruuta.Enabled = true;
                btnSyottaja1.Enabled = true;
                btnSyottaja2.Enabled = true;

            }

            private void btnSyottaja1_Click(object sender, EventArgs e)
            {
                tbSyottaja1Etunimi.Enabled = true;
                tbSyottaja1Sukunimi.Enabled = true;
                tbSyottaja1Nro.Enabled = true;
            }

            private void btnSyottaja2_Click(object sender, EventArgs e)
            {
                tbSyottaja2Etunimi.Enabled = true;
                tbSyottaja2Sukunimi.Enabled = true;
                tbSyottaja2Nro.Enabled = true;
            }

        //Tallenna painike lisää maalin sovellukseen
        //Lisätään maalintekijän ja syöttäjän tiedot listaan sekä tiedostoon
        //tyhjentää kentät ja voit jatkaa peliä.
        private void btnTallenna_Click(object sender, EventArgs e)
        {
            if (cbMaaliJoukkue.Text == cbJoukkue1.Text)
            {
                maalitKoti++;
                lblMaalitKoti.Text = maalitKoti.ToString();
                if (tbSyottaja1Nro.Text != "")
                {
                    syototKoti++;
                }
            }
            else if (cbMaaliJoukkue.Text == cbJoukkue2.Text)
            {
                maalitVieras++;
                lblMaalitVieras.Text = maalitVieras.ToString();
                if (tbSyottaja2Nro.Text != "")
                {
                    syototVieras++;
                }
            }

            OtteluTilastot();
            ottelu.Add(peli);
            TallennaOttelunJSON(ottelu);
            dgvOttelu.DataSource = null;
            dgvOttelu.DataSource = ottelu;
            Tyhjenna();
            tsStatuslbl.Text = "Tallennettu, paina Play jatkaaksesi peliä";
        }

        //tyhjentää maalintekijän ja syöttäjien kentät
        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            Tyhjenna();
            tsStatuslbl.Text = "Peruutettu, paina Play jatkaaksesi peliä";
        }

        void Tyhjenna()
        {
            tbMaaliAika.Text = "";
            tbMaaliAika.Enabled = false;
            cbMaaliJoukkue.Text = "";
            cbMaaliJoukkue.Enabled = false;
            cbMaaliJoukkue.Items.Clear();
            tbMaalintekijaEtunimi.Text = "";
            tbMaalintekijaEtunimi.Enabled = false;
            tbMaalintekijaSukunimi.Text = "";
            tbMaalintekijaSukunimi.Enabled = false;
            tbMaalintekijaNro.Text = "";
            tbMaalintekijaNro.Enabled = false;
            tbSyottaja1Etunimi.Text = "";
            tbSyottaja1Etunimi.Enabled = false;
            tbSyottaja1Sukunimi.Text = "";
            tbSyottaja1Sukunimi.Enabled = false;
            tbSyottaja1Nro.Text = "";
            tbSyottaja1Nro.Enabled = false;
            tbSyottaja2Etunimi.Text = "";
            tbSyottaja2Etunimi.Enabled = false;
            tbSyottaja2Sukunimi.Text = "";
            tbSyottaja2Sukunimi.Enabled = false;
            tbSyottaja2Nro.Text = "";
            tbSyottaja2Nro.Enabled = false;
            btnTallenna.Enabled = false;
            btnPeruuta.Enabled = false;
        }

        //lomakkeen nollaus
        private void Nollaus()
        {
            timer.Enabled = false;
            lblMaalitKoti.Text = "0";
            lblMaalitVieras.Text = "0";
            dgvOttelu.DataSource = null;
            this.Controls.Clear();
            this.InitializeComponent();
            Aloitus();
        }

        //Sulkee sovelluksen
        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("","Haluatko varmasti sulkea?", buttonsYesNo);
            if (result == DialogResult.Yes)
            {
                Form1.ActiveForm.Close();
            }
            
        }

        //Alustaa sovelluksen ja voi aloittaa uuden pelin
        private void aloitaUusiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("", "Aloitetaanko uusi peli?", buttonsYesNo);
            if (result == DialogResult.Yes)
            {
                Nollaus();
            }
        }

    }

}
