using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class Mozgatas : Parancs
    {
        Mezo hova;
        Mezo honnan;
        Egyseg megyseg;

        public Mozgatas(Mezo honnan, Mezo hova, Egyseg megyseg, JatekModel jatek) : base(jatek)
        {
            sorrend = 3;
            this.hova = hova;
            this.honnan = honnan;
            this.megyseg = megyseg;
        }
        public override void Vegrehajt()
        {
            honnan.Ellep(megyseg);
            if (hova.Tulajdonos != megyseg.Jatekos)
            {
                Csata cs = hova.MezoCsata;
                Tamadoegyseg tegyseg = new Tamadoegyseg(megyseg.Jatekos, megyseg.Egysegek, honnan, megyseg.Vedekezo);
                cs.Egysegfelvesz(tegyseg);
            }
            else
            {
                hova.ralep(megyseg);
            }
        }
    }
}
