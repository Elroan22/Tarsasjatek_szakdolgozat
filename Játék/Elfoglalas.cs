using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class Elfoglalas : Parancs
    {
        private Mezo fogMezo;
        private Tamadoegyseg fogegyseg;


        public Elfoglalas(Mezo mezo, Tamadoegyseg egyseg, JatekModel jatek) : base(jatek)
        {
            sorrend = 5;
            fogMezo = mezo;
            fogegyseg = egyseg;
        }

        public override void  Vegrehajt()
        {
            Egyseg egyseg = fogegyseg.Egysegrealakit();
            fogMezo.ralep(egyseg);
            Jatekos fogjatekos = egyseg.Jatekos;
            Jatekos tulajdonos = fogMezo.Tulajdonos;
            if(fogjatekos != tulajdonos) 
            {
                fogMezo.Elfoglalas(fogjatekos);
                int arany = fogMezo.Aranypkor;
                int utanpotlas = fogMezo.Utanpotlas;
                Kincstar fogkincs = fogjatekos.Kincstar;
                Sereg fogsereg = fogjatekos.Sereg;              
                fogkincs.aranytermelesnovel(arany);
                fogsereg.UtanpotlasNovel(utanpotlas);
                fogjatekos.MezoKap();
                if (tulajdonos != null)  //Ha a tulajdonos egy igazi játékos
                {
                    Kincstar tulkincs = tulajdonos.Kincstar;
                    Sereg tulsereg = tulajdonos.Sereg;
                    tulkincs.aranytermelescsokkent(arany);
                    tulsereg.UtanpotlasCsokken(utanpotlas);
                    tulajdonos.MezoVeszit();
                }
            }
        }
    }
}
