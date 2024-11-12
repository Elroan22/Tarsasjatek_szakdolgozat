using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class Sereg
    {
        Int32 utanpotlas;
        Int32 seregnagysag;

        Dictionary<Egysegtipus, Int32> sereg = new Dictionary<Egysegtipus, Int32>();
        
        #region Properties
        public Int32 SzabadUtanPotlas { get { return utanpotlas - seregnagysag; } }

        public Int32 UtanPotlas { get { return utanpotlas; } }
        #endregion

        public Sereg()
        {
            utanpotlas = 0;
            seregnagysag = 0;
        }

        public void Hozzaad(Egysegtipus egyseg)
        {
            seregnagysag += Egysegfajta.getPeldany(egyseg).Utanpotlas;
            if (sereg.ContainsKey(egyseg))
                sereg[egyseg]++;
            else
                sereg.Add(egyseg, 1);
        }

        public void UtanpotlasNovel(Int32 utanpotlas)
        {
            this.utanpotlas += utanpotlas;
        }

        public void UtanpotlasCsokken(Int32 utanpotlas)
        {
            this.utanpotlas -= utanpotlas;
        }

        public void Elvesz(Egysegtipus egyseg)
        {
            seregnagysag -= Egysegfajta.getPeldany(egyseg).Utanpotlas;
            sereg[egyseg]--;
        }

        public void SetUtan (Int32 utanpotlas)  //Új játék esetén
        {
            this.utanpotlas = utanpotlas;
            seregnagysag = 0;
            Dictionary<Egysegtipus, Int32> sereg = new Dictionary<Egysegtipus, Int32>();
            Hozzaad(Egysegtipus.Gyalogos);
            Hozzaad(Egysegtipus.Lovag);
        }
    }
}
