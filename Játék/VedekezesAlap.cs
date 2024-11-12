using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class VedekezesAlap : Parancs
    {
        private Egyseg vedegyseg;
        public VedekezesAlap(Egyseg egyseg, JatekModel jatek) : base(jatek)
        {
            vedegyseg = egyseg;
            sorrend = 7;
        }
        public override void Vegrehajt()
        {
            vedegyseg.StopVedekez();
        }
    }
}
