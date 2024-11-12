using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class Csata : Parancs
    {
        public Mezo harcMezo;

        #region Properties

        public List<Tamadoegyseg> harcegyseg = new List<Tamadoegyseg>();

        public List<Tamadoegyseg> HarcEgyseg { get { return harcegyseg; } }

        public Csata(Mezo mezocsata, JatekModel jatek) : base(jatek)
        {
            sorrend = 4;
            harcMezo = mezocsata;
        }
        #endregion


        public void Egysegfelvesz(Tamadoegyseg egyseg) //Egyy új egységet vesz fel a csatába
        {
            Boolean letezik = false;
            int index = 0;
            for(int i = 0; i < harcegyseg.Count; i++)
            {
                if (harcegyseg[i].Jatekos == egyseg.Jatekos) //Már csatában létező szövetséges egységhez hozzáadás
                {
                    letezik = true;
                    index = i;
                }
            }
            if (letezik)
                harcegyseg[index].Merge(egyseg);
            else
                harcegyseg.Add(egyseg);
        }

        public override void Vegrehajt()
        {
            Egyseg vedo = harcMezo.Allegyseg;
            if(vedo != null) //Védekező hozzáadása a csatához
            {
                Tamadoegyseg tegyseg = new Tamadoegyseg(vedo.Jatekos, vedo.Egysegek, harcMezo, vedo.Vedekezo);
                harcMezo.Ellep(tegyseg);
                Egysegfelvesz(tegyseg);
            }
            Tamadoegyseg gyozegyseg = Gyoztes();
            foreach (Tamadoegyseg tegyseg in harcegyseg)
            {
                if(tegyseg != null && tegyseg != gyozegyseg) //Vesztes visszavonulás és egység vesztés
                {
                    if (tegyseg.Egysegek[Egysegtipus.Gyalogos] > 0 && tegyseg.Egysegek[Egysegtipus.Lovag] > 0)
                    {
                        Array values = Enum.GetValues(typeof(Egysegtipus));
                        Random random = new Random();
                        Egysegtipus randomBar = (Egysegtipus)values.GetValue(random.Next(values.Length));
                        tegyseg.Removeegyseg(randomBar);
                        tegyseg.Jatekos.Sereg.Elvesz(randomBar);
                    }
                    else if (tegyseg.Egysegek[Egysegtipus.Gyalogos] > 0)
                    {
                        tegyseg.Removeegyseg(Egysegtipus.Gyalogos);
                        tegyseg.Jatekos.Sereg.Elvesz(Egysegtipus.Gyalogos);
                    }
                    else if (tegyseg.Egysegek[Egysegtipus.Lovag] > 0)
                    {
                        tegyseg.Removeegyseg(Egysegtipus.Lovag);
                        tegyseg.Jatekos.Sereg.Elvesz(Egysegtipus.Lovag);
                    }
                    jatek.ParancsFelvesz(new Visszavonulas(tegyseg, jatek));
                }
                else if(tegyseg == gyozegyseg)
                {
                    jatek.ParancsFelvesz(new Elfoglalas(harcMezo, tegyseg, jatek));
                }
            }
            harcMezo.CsataTorol();
        }

        public Tamadoegyseg Gyoztes() // Győztes megkeresése
        {
            int m = 0;
            Tamadoegyseg gyozegyseg = null!;
            foreach(Tamadoegyseg tegyseg in  harcegyseg)
            {
                if(m < tegyseg.Getosszero())
                {
                    m = tegyseg.Getosszero();
                    gyozegyseg = tegyseg;
                } else if( m == tegyseg.Getosszero()) //Egyenlő erő esetén pénzdobás
                {
                    Random random = new Random();
                    int dont = random.Next(2);
                    if (dont == 1)
                    {
                        m = tegyseg.Getosszero(); 
                        gyozegyseg = tegyseg;
                    }
                }
            }
            return gyozegyseg;
        }
    }
}
