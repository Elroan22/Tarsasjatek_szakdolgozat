using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class Toborzas : Parancs
    {
        Jatekos toborJatekos;
        Egysegtipus toboregyseg;
        Mezo celmezo;

        public Toborzas(Jatekos jatekos , Egysegtipus egyseg, JatekModel jatek, Mezo mezo) : base(jatek)
        {
            sorrend = 2;
            toborJatekos = jatekos;
            toboregyseg = egyseg;
            celmezo = mezo;
        }
        public override void Vegrehajt()
        {
            Egysegfajta fajta = Egysegfajta.getPeldany(toboregyseg);
            Kincstar kincstar = toborJatekos.Kincstar;
            Sereg sereg = toborJatekos.Sereg;
            int arany = kincstar.Arany;
            int utan = sereg.SzabadUtanPotlas;
            if(fajta.Ararany <= arany && fajta.Utanpotlas <= utan) 
            {
                kincstar.aranykolt(fajta.Ararany);
                sereg.Hozzaad(toboregyseg);
                celmezo.egyseghozzaad(toboregyseg);
            }
        }
    }
}
