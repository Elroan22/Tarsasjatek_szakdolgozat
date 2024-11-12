using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class Jatekos
    {
        private Int32 _mezoszam;
        private Sereg _sereg;
        private Kincstar _kincstar;
        private Int32 _toborzas;

        #region Properties
        public Int32 Mezoszam { get { return _mezoszam; } }
        public Sereg Sereg { get { return _sereg; } }
        public Kincstar Kincstar { get { return _kincstar; } }

        public Int32 Toborzas { get { return _toborzas; } }
        #endregion

        public Jatekos(int arany, int aranynovel, int seregnovel)
        {
            _kincstar = new Kincstar(arany);
            _sereg = new Sereg();
            _kincstar.aranytermelesnovel(aranynovel);
            _sereg.UtanpotlasNovel(seregnovel);
            _sereg.Hozzaad(Egysegtipus.Gyalogos);
            _sereg.Hozzaad(Egysegtipus.Lovag);
            _toborzas = 1;
            _mezoszam = 1;
        }

        public void SetNew()  //Új játék esetén
        {
            _mezoszam = 1;
        }

        public void AranyNovel(Int32 arany)
        {
            Kincstar.aranytermelesnovel(arany);
        }

        public void AranyCsokken(Int32 arany)
        {
            Kincstar.aranytermelescsokkent(arany);
        }

        public void UtanpotNovel(Int32 utanpot)
        {
            Sereg.UtanpotlasNovel(utanpot);
        }

        public void UtanpotCsokken(Int32 utanpot)
        {
            Sereg.UtanpotlasCsokken(utanpot);
        }

        public void AranyTermel()
        {
            Kincstar.aranytermel();
        }

        public Boolean LehetToborozni(Egysegfajta egyseg)
        {
            return Sereg.SzabadUtanPotlas >= egyseg.Utanpotlas;
        }

        public void MezoVeszit()
        {
            _mezoszam--;
        }

        public void MezoKap()
        {
            _mezoszam++;
        }

        public void Toboroz()
        {
            _toborzas = 0;
        }

        public void VToboroz()
        {
            _toborzas = 1;
        }
    }
}
