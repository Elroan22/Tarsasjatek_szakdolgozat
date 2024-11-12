using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class Egyseg
    {
        private Boolean vedekezo;
        private Jatekos _jatekos;

        Dictionary<Egysegtipus, Int32> egyseg = new Dictionary<Egysegtipus, Int32>();

        #region Properties

        public Jatekos Jatekos { get { return _jatekos; } }

        public Dictionary<Egysegtipus, Int32> Egysegek { get { return  egyseg; } }
        
        public Boolean Vedekezo { get { return vedekezo; } }
        #endregion

        public Egyseg()
        {
            _jatekos = null!;
            egyseg.Add(Egysegtipus.Gyalogos, 0);
            egyseg.Add(Egysegtipus.Lovag, 0);
        }
        public Egyseg(Jatekos jatekos)
        {
            _jatekos = jatekos;
            egyseg.Add(Egysegtipus.Gyalogos, 1);
            egyseg.Add(Egysegtipus.Lovag, 1);
        }

        public Egyseg(Jatekos jatekos, Dictionary<Egysegtipus, Int32> egyseg)
        {
            _jatekos = jatekos;
            this.egyseg.Add(Egysegtipus.Gyalogos, egyseg[Egysegtipus.Gyalogos]);
            this.egyseg.Add(Egysegtipus.Lovag, egyseg[Egysegtipus.Lovag]);
        }

        public int Getosszero() //Összerő visszaadása
        {
            int ero = 0;
            foreach (KeyValuePair<Egysegtipus, Int32> letszam in this.egyseg)
            {
                ero = ero + this.egyseg[letszam.Key] * Egysegfajta.getPeldany(letszam.Key).Ero;
            }
            if (vedekezo)
                ero++;
            return ero;
        } 

        public void Addegyseg(Egysegtipus tipus)  //Hozzáadás
        {
            egyseg[tipus]++;
        }

        public void Removeegyseg(Egysegtipus tipus)  //Kivonás
        {
            if (egyseg[tipus] != 0)
                egyseg[tipus]--;
        }

        public void TeremEgyseg(Egysegtipus tipus, Int32 szam)
        {
            egyseg[tipus] = szam;
        }

        public void Merge(Egyseg newegyseg)  //Két egység összefűzése
        {
            if(newegyseg.Jatekos != _jatekos)
                _jatekos = newegyseg.Jatekos;
            foreach(KeyValuePair<Egysegtipus, Int32> letszam in this.egyseg)
            {
                this.egyseg[letszam.Key] = this.egyseg[letszam.Key] + newegyseg.egyseg[letszam.Key];
            }
        }

        public void Subtract(Egyseg remegyseg) //Egységből kiszedés
        {
            foreach (KeyValuePair<Egysegtipus, Int32> letszam in this.egyseg)
            {
                this.egyseg[letszam.Key] = this.egyseg[letszam.Key] - remegyseg.egyseg[letszam.Key];
            }
        }

        public void Vedekez()
        {
            this.vedekezo = true;
        }

        public void StopVedekez()
        {
            this.vedekezo = false;
        }


    }
}
