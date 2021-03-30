using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Resepti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Resepti kanaPasta = new Resepti();
            kanaPasta.asetaNimi("Kanapasta");
            kanaPasta.asetaKuva(Tiedot.kanapasta);
            kanaPasta.asetaAinekset(Tiedot.ainekset_kanapasta);
            kanaPasta.asetaOhje(Tiedot.ohje_kanapasta);
            nopeaKana.Add(kanaPasta);

            Resepti kanaKeitto = new Resepti();
            kanaKeitto.asetaNimi("Kanakeitto");
            kanaKeitto.asetaKuva(Tiedot.kanakeitto);
            kanaKeitto.asetaAinekset(Tiedot.ainekset_kanakeitto);
            kanaKeitto.asetaOhje(Tiedot.ohje_kanakeitto);
            nopeaKana.Add(kanaKeitto);

            Resepti broileriGratiini = new Resepti();
            broileriGratiini.asetaNimi("Broilerigratiini");
            broileriGratiini.asetaKuva(Tiedot.broilerigratiini);
            broileriGratiini.asetaAinekset(Tiedot.ainekset_broilerigratiini);
            broileriGratiini.asetaOhje(Tiedot.ohje_broilerigratiini);
            hidasKana.Add(broileriGratiini);

            Resepti sitruunaKana = new Resepti();
            sitruunaKana.asetaNimi("Sitruunakana");
            sitruunaKana.asetaKuva(Tiedot.sitruunakana);
            sitruunaKana.asetaAinekset(Tiedot.ainekset_sitruunakana);
            sitruunaKana.asetaOhje(Tiedot.ohje_sitruunakana);
            hidasKana.Add(sitruunaKana);

            Resepti yrttiPullat = new Resepti();
            yrttiPullat.asetaNimi("Yrtti-fetalihapullat");
            yrttiPullat.asetaKuva(Tiedot.yrttipullat);
            yrttiPullat.asetaAinekset(Tiedot.ainekset_yrttipullat);
            yrttiPullat.asetaOhje(Tiedot.ohje_yrttipullat);
            nopeaLiha.Add(yrttiPullat);

            Resepti lihaPasta = new Resepti();
            lihaPasta.asetaNimi("Kermainen tomaatti-chorizopasta");
            lihaPasta.asetaKuva(Tiedot.lihapasta);
            lihaPasta.asetaAinekset(Tiedot.ainekset_lihapasta);
            lihaPasta.asetaOhje(Tiedot.ohje_lihapasta);
            nopeaLiha.Add(lihaPasta);

            Resepti intiaPata = new Resepti();
            intiaPata.asetaNimi("Intialainen lihapata");
            intiaPata.asetaKuva(Tiedot.intiapata);
            intiaPata.asetaAinekset(Tiedot.ainekset_intiapata);
            intiaPata.asetaOhje(Tiedot.ohje_intiapata);
            hidasLiha.Add(intiaPata);

            Resepti bataattiVuoka = new Resepti();
            bataattiVuoka.asetaNimi("Bataattijauhelihavuoka");
            bataattiVuoka.asetaKuva(Tiedot.bataattivuoka);
            bataattiVuoka.asetaAinekset(Tiedot.ainekset_bataattivuoka);
            bataattiVuoka.asetaOhje(Tiedot.ohje_bataattivuoka);
            hidasLiha.Add(bataattiVuoka);

            Resepti kesäPihvit = new Resepti();
            kesäPihvit.asetaNimi("Kesäkurpitsapihvit");
            kesäPihvit.asetaKuva(Tiedot.kesäpihvit);
            kesäPihvit.asetaAinekset(Tiedot.ainekset_kesäpihvit);
            kesäPihvit.asetaOhje(Tiedot.ohje_kesäpihvit);
            nopeaKasvis.Add(kesäPihvit);

            Resepti sieniKeitto = new Resepti();
            sieniKeitto.asetaNimi("Kantarellikeitto");
            sieniKeitto.asetaKuva(Tiedot.sienikeitto);
            sieniKeitto.asetaAinekset(Tiedot.ainekset_sienikeitto);
            sieniKeitto.asetaOhje(Tiedot.ohje_sienikeitto);
            nopeaKasvis.Add(sieniKeitto);

            Resepti lasagne = new Resepti();
            lasagne.asetaNimi("Mascarponelasagne");
            lasagne.asetaKuva(Tiedot.lasagne);
            lasagne.asetaAinekset(Tiedot.ainekset_lasagne);
            lasagne.asetaOhje(Tiedot.ohje_lasagne);
            hidasKasvis.Add(lasagne);
            
            Resepti perunaVuoka = new Resepti();
            perunaVuoka.asetaNimi("Perunaparsakaalipaistos");
            perunaVuoka.asetaKuva(Tiedot.perunavuoka);
            perunaVuoka.asetaAinekset(Tiedot.ainekset_perunavuoka);
            perunaVuoka.asetaOhje(Tiedot.ohje_perunavuoka);
            hidasKasvis.Add(perunaVuoka);
        }

        public object TextFile1 { get; private set; }

        private List<Resepti> nopeaKana = new List<Resepti>();
        private List<Resepti> hidasKana = new List<Resepti>();
        private List<Resepti> nopeaLiha = new List<Resepti>();
        private List<Resepti> hidasLiha = new List<Resepti>();
        private List<Resepti> nopeaKasvis = new List<Resepti>();
        private List<Resepti> hidasKasvis = new List<Resepti>();
        private void asetaResepti(Resepti r)
        {
            pictureBox1.Image = r.palautaKuva();
            label2.Text = r.palautaNimi();
            
            var str = r.palautaAinekset();
            richTextBox1.Text = str;

            var str2 = r.palautaOhje();
            richTextBox2.Text = str2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Resepti r1 = new Resepti();

            if (radioButton1.Checked == true)
            {
                //nopeat kanareseptit
                int randomNumber = rnd.Next(0, nopeaKana.Count());
                r1 = nopeaKana[randomNumber];
            }
            else
            {
                //hitaammat kanareseptit
                int randomNumber = rnd.Next(0, hidasKana.Count());
                r1 = hidasKana[randomNumber];
            }
            asetaResepti(r1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Resepti r1 = new Resepti();

            if (radioButton1.Checked == true)
            {
                //nopeat lihareseptit
                int randomNumber = rnd.Next(0, nopeaLiha.Count());
                r1 = nopeaLiha[randomNumber];
            }
            else
            {
                //hitaammat lihareseptit
                int randomNumber = rnd.Next(0, hidasLiha.Count());
                r1 = hidasLiha[randomNumber];
            }
            asetaResepti(r1);
        }
        private void button6_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            Resepti r1 = new Resepti();

            if (radioButton1.Checked == true)
            {
                //nopeat kasvisreseptit
                int randomNumber = rnd.Next(0, nopeaKasvis.Count());
                r1 = nopeaKasvis[randomNumber];
            }
            else
            {
                //hitaammat kasvisreseptit
                int randomNumber = rnd.Next(0, hidasKasvis.Count());
                r1 = hidasKasvis[randomNumber];
            }
            asetaResepti(r1);
        }
    }
}
