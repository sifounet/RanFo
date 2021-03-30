using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resepti
{
    class Resepti
    {
        private String nimi;
        private System.Drawing.Image kuva;
        private String ohje;
        private String ainekset;
        
        public Resepti()
        {

        }
        ~Resepti()
        {

        }

        public void asetaNimi(String n)
        {
            nimi = n;
        }
        public void asetaKuva(System.Drawing.Image k)
        {
            kuva = k;
        }
        public void asetaOhje(String o)
        {
            ohje = o;
        }
        public void asetaAinekset(String a)
        {
            ainekset = a;
        }
        
        public String palautaNimi()
        {
            return nimi;
        }
        public System.Drawing.Image palautaKuva()
        {
            return kuva;
        }
        public String palautaOhje()
        {
            return ohje;
        }
        public String palautaAinekset()
        {
            return ainekset;
        }

    }
}
