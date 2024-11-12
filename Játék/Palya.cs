using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class Palya
    {
        List<Mezo> mezoList;

        public List<Mezo> MezoList { get { return mezoList; } }
        public Palya(JatekModel jatek) 
        {
            mezoList = new List<Mezo>();
            Mezo mezo1 = new Mezo(1,1, jatek, "mezo1", jatek.Jatekos1);
            Mezo mezo2 = new Mezo(1,1, jatek, "mezo2");
            Mezo mezo3 = new Mezo(1,1, jatek, "mezo3");
            Mezo mezo4 = new Mezo(1, 1, jatek, "mezo4");
            Mezo mezo5 = new Mezo(1, 1, jatek, "mezo5");
            Mezo mezo6 = new Mezo(1, 1, jatek, "mezo6");
            Mezo mezo7 = new Mezo(1, 1, jatek, "mezo7");
            Mezo mezo8 = new Mezo(1, 1, jatek, "mezo8");
            Mezo mezo9 = new Mezo(1, 1, jatek, "mezo9", jatek.Jatekos2);
            Mezo mezo10 = new Mezo(1, 1, jatek, "mezo10");
            Mezo mezo11 = new Mezo(1, 1, jatek, "mezo11");
            Mezo mezo12 = new Mezo(1, 1, jatek, "mezo12");
            Mezo mezo13 = new Mezo(1, 1, jatek, "mezo13", jatek.Jatekos3);


            mezo1.AddMezo(mezo2);
            mezo1.AddMezo(mezo3);
            mezo2.AddMezo(mezo1);
            mezo2.AddMezo(mezo3);
            mezo2.AddMezo(mezo4);
            mezo3.AddMezo(mezo1);
            mezo3.AddMezo(mezo2);
            mezo3.AddMezo(mezo4);
            mezo3.AddMezo(mezo5);
            mezo3.AddMezo(mezo5);
            mezo4.AddMezo(mezo2);
            mezo4.AddMezo(mezo3);
            mezo4.AddMezo(mezo5);
            mezo4.AddMezo(mezo6);
            mezo4.AddMezo(mezo7);
            mezo5.AddMezo(mezo3);
            mezo5.AddMezo(mezo4);
            mezo5.AddMezo(mezo6);
            mezo5.AddMezo(mezo13);
            mezo6.AddMezo(mezo4);
            mezo6.AddMezo(mezo5);
            mezo6.AddMezo(mezo7);
            mezo6.AddMezo(mezo8);
            mezo6.AddMezo(mezo13);
            mezo7.AddMezo(mezo4);
            mezo7.AddMezo(mezo6);
            mezo7.AddMezo(mezo8);
            mezo7.AddMezo(mezo9);
            mezo8.AddMezo(mezo6);
            mezo8.AddMezo(mezo7);
            mezo8.AddMezo(mezo9);
            mezo8.AddMezo(mezo10);
            mezo8.AddMezo(mezo11);
            mezo8.AddMezo(mezo12);
            mezo9.AddMezo(mezo7);
            mezo9.AddMezo(mezo8);
            mezo9.AddMezo(mezo10);
            mezo10.AddMezo(mezo8);
            mezo10.AddMezo(mezo9);
            mezo10.AddMezo(mezo10);
            mezo11.AddMezo(mezo8);
            mezo11.AddMezo(mezo10);
            mezo11.AddMezo(mezo12);
            mezo12.AddMezo(mezo8);
            mezo12.AddMezo(mezo11);
            mezo12.AddMezo(mezo13);
            mezo13.AddMezo(mezo5);
            mezo13.AddMezo(mezo6);
            mezo13.AddMezo(mezo12);
            

            mezoList.Add(mezo1);
            mezoList.Add(mezo2);
            mezoList.Add(mezo3);
            mezoList.Add(mezo4);
            mezoList.Add(mezo5);
            mezoList.Add(mezo6);
            mezoList.Add(mezo7);
            mezoList.Add(mezo8);
            mezoList.Add(mezo9);
            mezoList.Add(mezo10);
            mezoList.Add(mezo11);
            mezoList.Add(mezo12);
            mezoList.Add(mezo13);

        }
    }
}
