using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{

    public enum Egysegtipus {Lovag, Gyalogos}
    public class Egysegfajta
    {
        private Int32 ero;
        private Int32 utanpotlas;
        private Int32 ararany;

        #region Properties
        public Int32 Ero { get { return ero; } }
        public Int32 Utanpotlas { get { return utanpotlas; } }
        public Int32 Ararany { get { return ararany; } }
        #endregion

        private Egysegfajta(int ero, int utanpotlas, int ararany)
        {
            this.ero = ero;
            this.utanpotlas = utanpotlas;
            this.ararany = ararany;
        }

        static public Egysegfajta getPeldany(Egysegtipus tipus)
        {
            if(tipus == Egysegtipus.Lovag)
            {
                return new Egysegfajta(2, 2, 10);
            }
            else if (tipus == Egysegtipus.Gyalogos)
            {
                return new Egysegfajta(1, 1, 5);
            }
            else
            {
                throw new Exception("Nem érvényes típus");
            }
        }
    }
}
