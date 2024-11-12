using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class Mezo
    {
        private String name;
        Int32 aranypkor;
        Int32 utanpotlas;
        Egyseg allegyseg;
        Jatekos tulajdonos;
        List<Mezo> mezok;
        Csata mezocsata = null!;
        JatekModel jatek;
        Boolean szabad = true;


        public Csata MezoCsata { get {
                if (mezocsata == null)
                {
                    mezocsata = new Csata(this, jatek);
                    jatek.ParancsFelvesz(MezoCsata);
                }
                return mezocsata;
            }
        }

        public Csata RMezoCsata { get { return mezocsata; } }

        public Boolean Szabad { get { return szabad; } }
        public Int32 Aranypkor { get { return aranypkor; } }
        public Int32 Utanpotlas { get { return utanpotlas; } }

        public Egyseg Allegyseg { get { return allegyseg; } }

        public Jatekos Tulajdonos { get { return tulajdonos; } }

        public List<Mezo> Mezok { get { return mezok; } }

        public String Name { get { return name; } }

        public Mezo(Int32 arany, Int32 utanpot, JatekModel jatek, string name)  //Nincs tulaja
        {
            this.jatek = jatek;
            mezok = new List<Mezo>();
            aranypkor = arany;
            utanpotlas = utanpot;
            tulajdonos = null!;
            allegyseg = new Egyseg();
            this.name = name;
        }

        public Mezo(Int32 arany, Int32 utanpot, JatekModel jatek, string name, Jatekos jatekos) //Van tulaja
        {
            this.jatek = jatek;
            mezok = new List<Mezo>();
            aranypkor = arany;
            utanpotlas = utanpot;
            tulajdonos = jatekos;
            allegyseg = new Egyseg(jatekos);
            this.name = name;
        }

        public void Ellep(Egyseg egyseg)
        {
            allegyseg.Subtract(egyseg);
        }

        public void egyseghozzaad(Egysegtipus egyseg)
        {
            allegyseg.Addegyseg(egyseg);
        }

        public Mezo legkozelebb(Jatekos jatekos)  //Legközelebbib saját mező keresése
        {
            Queue<Mezo> queue = new Queue<Mezo>();
            HashSet<Mezo> visited = new HashSet<Mezo>();

            visited.Add(this);
            
            queue.Enqueue(this);
            while (queue.Count != 0)
            {
                Mezo currentNode = queue.Dequeue();
                if(currentNode.Tulajdonos == jatekos)
                {
                    return currentNode;
                }
                foreach (Mezo neighbor in mezok)
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }
            return null!;
        }

        public void ralep(Egyseg egyseg)
        {
            allegyseg.Merge(egyseg);
        }

        public void AddMezo(Mezo mezo)
        {
            mezok.Add(mezo);
        }

        public void Elfoglalas(Jatekos jatekos)
        {
            tulajdonos = jatekos;
            
        }

        public void EgysegVedekez()
        {
            allegyseg.Vedekez();
        }

        public void CsataTorol()
        {
            mezocsata = null;
        }

        public void Cseleked()
        {
            szabad = false;
        }

        public void FelSzabadit()
        {
            szabad = true;
        }
    }
}
