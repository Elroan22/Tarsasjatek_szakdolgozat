using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class Vedekezes : Parancs
    {
        private Egyseg vedegyseg;
        public Vedekezes(Egyseg egyseg, JatekModel jatek) : base(jatek) 
        {
            sorrend = 1;
            vedegyseg = egyseg;
        }

        public override void Vegrehajt()
        {
            vedegyseg.Vedekez();
            VedekezesAlap stopvedekez = new VedekezesAlap(vedegyseg, jatek);  //Védekezés leállítása a kör végén
            jatek.ParancsFelvesz(stopvedekez);
        }
    }
}
