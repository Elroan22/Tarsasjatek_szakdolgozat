using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class Kincstar
    {
        private Int32 arany = 0;
        private Int32 arany_kor = 0;

        #region Properties
        public Int32 Arany { get { return arany; } }
        public Int32 Arany_kor { get {  return arany_kor; } }

        public Kincstar(Int32 arany) 
        {
            this.arany = arany;
        }
        #endregion

        public void aranykolt(Int32 arany)
        {
            this.arany -= arany;
        }

        public void aranytermel()
        {
            this.arany += this.arany_kor;
        }
        public void aranytermelesnovel(Int32 arany)
        {
            this.arany_kor += arany;
        }

        public void aranytermelescsokkent(Int32 arany)
        {
            this.arany_kor -= arany;
        }

        public void setarany(Int32 arany, Int32 aranykor)  //Új játék esetén
        {
            this.arany = arany;
            this.arany_kor = aranykor;
        }
    }
}
