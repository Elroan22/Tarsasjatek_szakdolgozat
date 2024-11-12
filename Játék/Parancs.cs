using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public abstract class Parancs
    {
        protected int sorrend;
        public JatekModel jatek;
        public int Sorrend { get { return sorrend; } }
        public abstract void Vegrehajt();
        public Parancs(JatekModel jatek)
        {
            this.jatek = jatek;
        }
      
    }
}
