using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Játék
{
    public class JatekModel
    {
        Int32 korokSzama;
        PriorityQueue<Parancs, int> parancssor;
        private Palya palya;
        private List<Jatekos> jatekosok;
        private Int32 currentPlayer;
        private Int32 stage;
        private String gyoztes = "";

        #region Properties
        public Palya Palya { get { return palya; } }
        public Jatekos Jatekos1 { get { return jatekosok[0]; } }
        public Jatekos Jatekos2 { get { return jatekosok[1]; } }
        public Jatekos Jatekos3 { get { return jatekosok[2]; } }

        public Int32 Index { get { return currentPlayer; } }

        public Int32 Stage { get { return stage; } }

        public Jatekos CurrentPlayer { get { return jatekosok[currentPlayer]; } }

        public Int32 KorokSzama { get { return korokSzama; } }

        public String Gyoztes { get { return gyoztes; } }
        #endregion
        public JatekModel()
        {     
            parancssor = new PriorityQueue<Parancs, int>();
            jatekosok = new List<Jatekos>();
            jatekosok.Add(new Jatekos(5, 1, 4));
            jatekosok.Add(new Jatekos(5, 1, 4));
            jatekosok.Add(new Jatekos(5, 1, 4));
            currentPlayer = 0;
            korokSzama = 1;
            stage = 0;
            palya = new Palya(this);
        }

        public Boolean IsVege()
        {
            if (KorokSzama > 15)
            {
                return true;
            }
            return false;
        }
        public void GameOver()
        {
            if (Jatekos1.Mezoszam > Jatekos2.Mezoszam && Jatekos1.Mezoszam > Jatekos3.Mezoszam)
                gyoztes = "1. játékos ";
            else if(Jatekos2.Mezoszam > Jatekos1.Mezoszam && Jatekos2.Mezoszam > Jatekos3.Mezoszam)
                gyoztes = "2. játékos ";
            else if (Jatekos3.Mezoszam > Jatekos1.Mezoszam && Jatekos3.Mezoszam > Jatekos2.Mezoszam)
                gyoztes = "3. játékos ";
            else if (Jatekos2.Mezoszam == Jatekos1.Mezoszam && Jatekos2.Mezoszam > Jatekos3.Mezoszam)
                gyoztes = "1. és 2. játékos ";
            else if (Jatekos1.Mezoszam == Jatekos3.Mezoszam && Jatekos1.Mezoszam > Jatekos2.Mezoszam)
                gyoztes = "1. és 3. játékos ";
            else if (Jatekos2.Mezoszam == Jatekos3.Mezoszam && Jatekos2.Mezoszam > Jatekos1.Mezoszam)
                gyoztes = "2. és 3. játékos ";
            else
            {
                gyoztes = "Mindenki ";
            }
        }

        public void ParancsFelvesz(Parancs parancs)
        {
            parancssor.Enqueue(parancs, parancs.Sorrend);
        }

        public void Korvegrehajt()
        {
            while (parancssor.Count > 0 && parancssor.Peek().Sorrend == Stage)
            {
                parancssor.Dequeue().Vegrehajt();
            }

        }

        public void Leptet()  //Itt haladunk a játékmenettel
        {
           
            if (Stage == 0)
            {
                currentPlayer++;
                if(currentPlayer !=3 && CurrentPlayer.Mezoszam == 0)
                    currentPlayer++;
                if (currentPlayer == 3)
                {
                    if (parancssor.Count == 0)
                    {
                        currentPlayer = 0;
                        stage = 0;
                        Jatekos1.Kincstar.aranytermel();
                        Jatekos2.Kincstar.aranytermel();
                        Jatekos3.Kincstar.aranytermel();
                        Jatekos1.VToboroz();
                        Jatekos2.VToboroz();
                        Jatekos3.VToboroz();
                        for (int i = 0; i < 13; i++)
                        {
                            palya.MezoList[i].FelSzabadit();
                        }
                        korokSzama++;
                    }
                    else
                    {
                        stage = parancssor.Peek().Sorrend;
                        Korvegrehajt();
                    }
                }
            }
            else if (parancssor.Count > 0)
            {
                stage = parancssor.Peek().Sorrend;
                Korvegrehajt();
            }
            else if (parancssor.Count == 0)
            {
                currentPlayer = 0;
                stage = 0;
                Jatekos1.Kincstar.aranytermel();
                Jatekos2.Kincstar.aranytermel();
                Jatekos3.Kincstar.aranytermel();
                Jatekos1.VToboroz();
                Jatekos2.VToboroz();
                Jatekos3.VToboroz();
                for (int i = 0; i < 13; i ++) 
                {
                    palya.MezoList[i].FelSzabadit();
                }
                korokSzama++;
            }
            if (IsVege())
                GameOver();
        }


        public void Ujjatek()  //Új játék létrehozzása
        {
            stage = 0;
            korokSzama = 1;
            Egyseg ugyseg = new Egyseg();
            currentPlayer = 0;
            Jatekos1.Kincstar.setarany(5, 1);
            Jatekos2.Kincstar.setarany(5, 1);
            Jatekos3.Kincstar.setarany(5, 1);
            Jatekos1.Sereg.SetUtan(4);
            Jatekos2.Sereg.SetUtan(4);
            Jatekos3.Sereg.SetUtan(4);
            Jatekos1.VToboroz();
            Jatekos2.VToboroz();
            Jatekos3.VToboroz();
            parancssor = new PriorityQueue<Parancs, int>();
            for (int i = 0; i < 13; i ++)
            {
                palya.MezoList[i].FelSzabadit();
                palya.MezoList[i].Elfoglalas(null!);
                palya.MezoList[i].Allegyseg.TeremEgyseg(Egysegtipus.Gyalogos, 0);
                palya.MezoList[i].Allegyseg.TeremEgyseg(Egysegtipus.Lovag, 0);
                palya.MezoList[i].ralep(ugyseg);
            }
            palya.MezoList[0].Elfoglalas(Jatekos1);
            Egyseg egyseg1 = new Egyseg(Jatekos1);
            Egyseg egyseg2 = new Egyseg(Jatekos2);
            Egyseg egyseg3 = new Egyseg(Jatekos3);
            palya.MezoList[0].Elfoglalas(Jatekos1);
            palya.MezoList[0].ralep(egyseg1);
            palya.MezoList[8].Elfoglalas(Jatekos2);
            palya.MezoList[8].ralep(egyseg2);
            palya.MezoList[12].Elfoglalas(Jatekos3);
            palya.MezoList[12].ralep(egyseg3);
        }
    }
}
