using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class Tamadoegyseg : Egyseg
    {
        private Mezo visszamezo;

        public Mezo Visszamezo { get {  return visszamezo; } }

        public Tamadoegyseg(Jatekos jatekos, Dictionary<Egysegtipus, int> egyseg, Mezo vmezo, bool vedekez) : base(jatekos, egyseg)
        {
            visszamezo = vmezo;  //Visszavonulási mező
            if(vedekez)
            {
                this.Vedekez();
            }
        }

        public Egyseg Egysegrealakit()
        {
            return new Egyseg(this.Jatekos, this.Egysegek);
        }
    }
}
