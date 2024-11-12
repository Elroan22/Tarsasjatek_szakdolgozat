using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class Visszavonulas : Parancs
    {
        Tamadoegyseg visszegyseg;
        public Visszavonulas(Tamadoegyseg tegyseg, JatekModel jatek) : base(jatek)
        {
            sorrend = 6;
            visszegyseg = tegyseg;
        }

        public override void Vegrehajt()
        {
            if (visszegyseg.Jatekos != null)
            {
                Mezo iranymezo = visszegyseg.Visszamezo;
                Egyseg vesztes = visszegyseg.Egysegrealakit();
                Jatekos tulaj = vesztes.Jatekos;
                Mezo visszmezo = iranymezo.legkozelebb(tulaj);
                if (visszmezo != null)
                    visszmezo.ralep(vesztes);
            }
        }
    }
}
