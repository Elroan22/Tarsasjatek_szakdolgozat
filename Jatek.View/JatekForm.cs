using Játék;
using Jatek.View.Properties;
using System.CodeDom.Compiler;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Windows.Forms.Design;
using System.Windows.Forms.VisualStyles;

namespace Jatek
{
    enum ParancsMod { Mozgas, Toborzas, Vedekezes, Semmi }
    public partial class JatekForm : System.Windows.Forms.Form
    {
        private Mezo temp = null!;
        private Mezo AktualisMezo = null!;
        private Mezo Celmezo = null!;
        private Jatekos CurrentJatekos = null!;
        private ParancsMod parancs = ParancsMod.Semmi;
        private JatekModel _jatek = null!;
        private List<Label> _pirosGyal = new List<Label>();
        private List<Label> _pirosLo = new List<Label>();
        private List<Label> _kekGyal = new List<Label>();
        private List<Label> _kekLo = new List<Label>();
        private List<Label> _zoldGyal = new List<Label>();
        private List<Label> _zoldLo = new List<Label>();
        private List<Button> _gombok = new List<Button>();
        private List<PictureBox> _shields = new List<PictureBox>();
        private List<PictureBox> _bpirosGyal = new List<PictureBox>();
        private List<PictureBox> _bpirosLo = new List<PictureBox>();
        private List<PictureBox> _bkekGyal = new List<PictureBox>();
        private List<PictureBox> _bkekLo = new List<PictureBox>();
        private List<PictureBox> _bzoldGyal = new List<PictureBox>();
        private List<PictureBox> _bzoldLo = new List<PictureBox>();
        private Egyseg tmpegyseg;
        public JatekForm()
        {
            InitializeComponent();
            Parancsablak.BringToFront();
            _jatek = new JatekModel();
            CurrentJatekos = _jatek.CurrentPlayer;
            Mezo1Arany.Text = "A: " + _jatek.Palya.MezoList[0].Aranypkor.ToString();
            Mezo1Utan.Text = "U: " + _jatek.Palya.MezoList[0].Utanpotlas.ToString();
            Mezo2Arany.Text = "A: " + _jatek.Palya.MezoList[1].Aranypkor.ToString();
            Mezo2Utan.Text = "U: " + _jatek.Palya.MezoList[1].Utanpotlas.ToString();
            Mezo3Arany.Text = "A: " + _jatek.Palya.MezoList[2].Aranypkor.ToString();
            Mezo3Utan.Text = "U: " + _jatek.Palya.MezoList[2].Utanpotlas.ToString();
            Mezo4Arany.Text = "A: " + _jatek.Palya.MezoList[3].Aranypkor.ToString();
            Mezo4Utan.Text = "U: " + _jatek.Palya.MezoList[3].Utanpotlas.ToString();
            Mezo5Arany.Text = "A: " + _jatek.Palya.MezoList[4].Aranypkor.ToString();
            Mezo5Utan.Text = "U: " + _jatek.Palya.MezoList[4].Utanpotlas.ToString();
            Mezo6Arany.Text = "A: " + _jatek.Palya.MezoList[5].Aranypkor.ToString();
            Mezo6Utan.Text = "U: " + _jatek.Palya.MezoList[5].Utanpotlas.ToString();
            Mezo7Arany.Text = "A: " + _jatek.Palya.MezoList[6].Aranypkor.ToString();
            Mezo7Utan.Text = "U: " + _jatek.Palya.MezoList[6].Utanpotlas.ToString();
            Mezo8Arany.Text = "A: " + _jatek.Palya.MezoList[7].Aranypkor.ToString();
            Mezo8Utan.Text = "U: " + _jatek.Palya.MezoList[7].Utanpotlas.ToString();
            Mezo9Arany.Text = "A: " + _jatek.Palya.MezoList[8].Aranypkor.ToString();
            Mezo9Utan.Text = "U: " + _jatek.Palya.MezoList[8].Utanpotlas.ToString();
            Mezo10Arany.Text = "A: " + _jatek.Palya.MezoList[9].Aranypkor.ToString();
            Mezo10Utan.Text = "U: " + _jatek.Palya.MezoList[9].Utanpotlas.ToString();
            Mezo11Arany.Text = "A: " + _jatek.Palya.MezoList[10].Aranypkor.ToString();
            Mezo11Utan.Text = "U: " + _jatek.Palya.MezoList[10].Utanpotlas.ToString();
            Mezo12Arany.Text = "A: " + _jatek.Palya.MezoList[11].Aranypkor.ToString();
            Mezo12Utan.Text = "U: " + _jatek.Palya.MezoList[11].Utanpotlas.ToString();
            Mezo13Arany.Text = "A: " + _jatek.Palya.MezoList[12].Aranypkor.ToString();
            Mezo13Utan.Text = "U: " + _jatek.Palya.MezoList[12].Utanpotlas.ToString();

            _bpirosGyal.Add(Mezo1PGyal);
            _bpirosGyal.Add(Mezo2PGyal);
            _bpirosGyal.Add(Mezo3PGyal);
            _bpirosGyal.Add(Mezo4PGyal);
            _bpirosGyal.Add(Mezo5PGyal);
            _bpirosGyal.Add(Mezo6PGyal);
            _bpirosGyal.Add(Mezo7PGyal);
            _bpirosGyal.Add(Mezo8PGyal);
            _bpirosGyal.Add(Mezo9PGyal);
            _bpirosGyal.Add(Mezo10PGyal);
            _bpirosGyal.Add(Mezo11PGyal);
            _bpirosGyal.Add(Mezo12PGyal);
            _bpirosGyal.Add(Mezo13PGyal);

            _bpirosLo.Add(Mezo1PLo);
            _bpirosLo.Add(Mezo2PLo);
            _bpirosLo.Add(Mezo3PLo);
            _bpirosLo.Add(Mezo4PLo);
            _bpirosLo.Add(Mezo5PLo);
            _bpirosLo.Add(Mezo6PLo);
            _bpirosLo.Add(Mezo7PLo);
            _bpirosLo.Add(Mezo8PLo);
            _bpirosLo.Add(Mezo9PLo);
            _bpirosLo.Add(Mezo10PLo);
            _bpirosLo.Add(Mezo11PLo);
            _bpirosLo.Add(Mezo12PLo);
            _bpirosLo.Add(Mezo13PLo);

            _bkekGyal.Add(Mezo1KGyal);
            _bkekGyal.Add(Mezo2KGyal);
            _bkekGyal.Add(Mezo3KGyal);
            _bkekGyal.Add(Mezo4KGyal);
            _bkekGyal.Add(Mezo5KGyal);
            _bkekGyal.Add(Mezo6KGyal);
            _bkekGyal.Add(Mezo7KGyal);
            _bkekGyal.Add(Mezo8KGyal);
            _bkekGyal.Add(Mezo9KGyal);
            _bkekGyal.Add(Mezo10KGyal);
            _bkekGyal.Add(Mezo11KGyal);
            _bkekGyal.Add(Mezo12KGyal);
            _bkekGyal.Add(Mezo13KGyal);

            _bkekLo.Add(Mezo1KLo);
            _bkekLo.Add(Mezo2KLo);
            _bkekLo.Add(Mezo3KLo);
            _bkekLo.Add(Mezo4KLo);
            _bkekLo.Add(Mezo5KLo);
            _bkekLo.Add(Mezo6KLo);
            _bkekLo.Add(Mezo7KLo);
            _bkekLo.Add(Mezo8KLo);
            _bkekLo.Add(Mezo9KLo);
            _bkekLo.Add(Mezo10KLo);
            _bkekLo.Add(Mezo11KLo);
            _bkekLo.Add(Mezo12KLo);
            _bkekLo.Add(Mezo13KLo);

            _bzoldGyal.Add(Mezo1ZGyal);
            _bzoldGyal.Add(Mezo2ZGyal);
            _bzoldGyal.Add(Mezo3ZGyal);
            _bzoldGyal.Add(Mezo4ZGyal);
            _bzoldGyal.Add(Mezo5ZGyal);
            _bzoldGyal.Add(Mezo6ZGyal);
            _bzoldGyal.Add(Mezo7ZGyal);
            _bzoldGyal.Add(Mezo8ZGyal);
            _bzoldGyal.Add(Mezo9ZGyal);
            _bzoldGyal.Add(Mezo10ZGyal);
            _bzoldGyal.Add(Mezo11ZGyal);
            _bzoldGyal.Add(Mezo12ZGyal);
            _bzoldGyal.Add(Mezo13ZGyal);

            _bzoldLo.Add(Mezo1ZLo);
            _bzoldLo.Add(Mezo2ZLo);
            _bzoldLo.Add(Mezo3ZLo);
            _bzoldLo.Add(Mezo4ZLo);
            _bzoldLo.Add(Mezo5ZLo);
            _bzoldLo.Add(Mezo6ZLo);
            _bzoldLo.Add(Mezo7ZLo);
            _bzoldLo.Add(Mezo8ZLo);
            _bzoldLo.Add(Mezo9ZLo);
            _bzoldLo.Add(Mezo10ZLo);
            _bzoldLo.Add(Mezo11ZLo);
            _bzoldLo.Add(Mezo12ZLo);
            _bzoldLo.Add(Mezo13ZLo);

            _pirosGyal.Add(Szam1PGyalogos);
            _pirosGyal.Add(Szam2PGyalogos);
            _pirosGyal.Add(Szam3PGyalogos);
            _pirosGyal.Add(Szam4PGyalogos);
            _pirosGyal.Add(Szam5PGyalogos);
            _pirosGyal.Add(Szam6PGyalogos);
            _pirosGyal.Add(Szam7PGyalogos);
            _pirosGyal.Add(Szam8PGyalogos);
            _pirosGyal.Add(Szam9PGyalogos);
            _pirosGyal.Add(Szam10PGyalogos);
            _pirosGyal.Add(Szam11PGyalogos);
            _pirosGyal.Add(Szam12PGyalogos);
            _pirosGyal.Add(Szam13PGyalogos);

            _pirosLo.Add(Szam1PLo);
            _pirosLo.Add(Szam2PLo);
            _pirosLo.Add(Szam3PLo);
            _pirosLo.Add(Szam4PLo);
            _pirosLo.Add(Szam5PLo);
            _pirosLo.Add(Szam6PLo);
            _pirosLo.Add(Szam7PLo);
            _pirosLo.Add(Szam8PLo);
            _pirosLo.Add(Szam9PLo);
            _pirosLo.Add(Szam10PLo);
            _pirosLo.Add(Szam11PLo);
            _pirosLo.Add(Szam12PLo);
            _pirosLo.Add(Szam13PLo);

            _kekGyal.Add(Szam1BGyalogos);
            _kekGyal.Add(Szam2BGyalogos);
            _kekGyal.Add(Szam3BGyalogos);
            _kekGyal.Add(Szam4BGyalogos);
            _kekGyal.Add(Szam5BGyalogos);
            _kekGyal.Add(Szam6BGyalogos);
            _kekGyal.Add(Szam7BGyalogos);
            _kekGyal.Add(Szam8BGyalogos);
            _kekGyal.Add(Szam9BGyalogos);
            _kekGyal.Add(Szam10BGyalogos);
            _kekGyal.Add(Szam11BGyalogos);
            _kekGyal.Add(Szam12BGyalogos);
            _kekGyal.Add(Szam13BGyalogos);

            _kekLo.Add(Szam1BLo);
            _kekLo.Add(Szam2BLo);
            _kekLo.Add(Szam3BLo);
            _kekLo.Add(Szam4BLo);
            _kekLo.Add(Szam5BLo);
            _kekLo.Add(Szam6BLo);
            _kekLo.Add(Szam7BLo);
            _kekLo.Add(Szam8BLo);
            _kekLo.Add(Szam9BLo);
            _kekLo.Add(Szam10BLo);
            _kekLo.Add(Szam11BLo);
            _kekLo.Add(Szam12BLo);
            _kekLo.Add(Szam13BLo);

            _zoldGyal.Add(Szam1ZGyalogos);
            _zoldGyal.Add(Szam2ZGyalogos);
            _zoldGyal.Add(Szam3ZGyalogos);
            _zoldGyal.Add(Szam4ZGyalogos);
            _zoldGyal.Add(Szam5ZGyalogos);
            _zoldGyal.Add(Szam6ZGyalogos);
            _zoldGyal.Add(Szam7ZGyalogos);
            _zoldGyal.Add(Szam8ZGyalogos);
            _zoldGyal.Add(Szam9ZGyalogos);
            _zoldGyal.Add(Szam10ZGyalogos);
            _zoldGyal.Add(Szam11ZGyalogos);
            _zoldGyal.Add(Szam12ZGyalogos);
            _zoldGyal.Add(Szam13ZGyalogos);

            _zoldLo.Add(Szam1ZLo);
            _zoldLo.Add(Szam2ZLo);
            _zoldLo.Add(Szam3ZLo);
            _zoldLo.Add(Szam4ZLo);
            _zoldLo.Add(Szam5ZLo);
            _zoldLo.Add(Szam6ZLo);
            _zoldLo.Add(Szam7ZLo);
            _zoldLo.Add(Szam8ZLo);
            _zoldLo.Add(Szam9ZLo);
            _zoldLo.Add(Szam10ZLo);
            _zoldLo.Add(Szam11ZLo);
            _zoldLo.Add(Szam12ZLo);
            _zoldLo.Add(Szam13ZLo);

            _gombok.Add(ButtonMezo1);
            _gombok.Add(ButtonMezo2);
            _gombok.Add(ButtonMezo3);
            _gombok.Add(ButtonMezo4);
            _gombok.Add(ButtonMezo5);
            _gombok.Add(ButtonMezo6);
            _gombok.Add(ButtonMezo7);
            _gombok.Add(ButtonMezo8);
            _gombok.Add(ButtonMezo9);
            _gombok.Add(ButtonMezo10);
            _gombok.Add(ButtonMezo11);
            _gombok.Add(ButtonMezo12);
            _gombok.Add(ButtonMezo13);

            _shields.Add(Shield1);
            _shields.Add(Shield2);
            _shields.Add(Shield3);
            _shields.Add(Shield4);
            _shields.Add(Shield5);
            _shields.Add(Shield6);
            _shields.Add(Shield7);
            _shields.Add(Shield8);
            _shields.Add(Shield9);
            _shields.Add(Shield10);
            _shields.Add(Shield11);
            _shields.Add(Shield12);
            _shields.Add(Shield13);

            UnrefreshShield();
            RefreshAll();
            RefreshButton();
            RefreshStatus();
            Remove();
        }

        #region MezoGombok
        private void ButtonMezo1_Click(object sender, EventArgs e)
        {
            if (parancs == ParancsMod.Mozgas)
            {
                temp = _jatek.Palya.MezoList[0];
                if (temp.Mezok.Contains(AktualisMezo))
                {
                    Celmezo = _jatek.Palya.MezoList[0];
                    MezoCel.Text = Celmezo.Name;
                }
                else
                {
                    MessageBox.Show("Nem szomtédos mezõ!", "Nem megengedett akció");
                }
            }
            else if (parancs == ParancsMod.Semmi)
            {
                if (_jatek.Palya.MezoList[0].Tulajdonos == CurrentJatekos && _jatek.Palya.MezoList[0].Szabad)
                {
                    temp = _jatek.Palya.MezoList[0];
                    Relocate((Button)sender);
                }
            }
        }

        private void ButtonMezo2_Click(object sender, EventArgs e)
        {
            if (parancs == ParancsMod.Mozgas)
            {
                temp = _jatek.Palya.MezoList[1];
                if (temp.Mezok.Contains(AktualisMezo))
                {
                    Celmezo = _jatek.Palya.MezoList[1];
                    MezoCel.Text = Celmezo.Name;
                }
                else
                {
                    MessageBox.Show("Nem szomtédos mezõ!", "Nem megengedett akció");
                }
            }
            else if (parancs == ParancsMod.Semmi)
            {
                if (_jatek.Palya.MezoList[1].Tulajdonos == CurrentJatekos && _jatek.Palya.MezoList[1].Szabad)
                {
                    temp = _jatek.Palya.MezoList[1];
                    Relocate((Button)sender);
                }
            }
        }





        private void ButtonMezo3_Click(object sender, EventArgs e)
        {
            if (parancs == ParancsMod.Mozgas)
            {
                temp = _jatek.Palya.MezoList[2];
                if (temp.Mezok.Contains(AktualisMezo))
                {
                    Celmezo = _jatek.Palya.MezoList[2];
                    MezoCel.Text = Celmezo.Name;
                }
                else
                {
                    MessageBox.Show("Nem szomtédos mezõ!", "Nem megengedett akció");
                }
            }
            else if (parancs == ParancsMod.Semmi)
            {
                if (_jatek.Palya.MezoList[2].Tulajdonos == CurrentJatekos && _jatek.Palya.MezoList[2].Szabad)
                {
                    temp = _jatek.Palya.MezoList[2];
                    Relocate((Button)sender);
                }
            }
        }

        private void ButtonMezo4_Click(object sender, EventArgs e)
        {
            if (parancs == ParancsMod.Mozgas)
            {
                temp = _jatek.Palya.MezoList[3];
                if (temp.Mezok.Contains(AktualisMezo))
                {
                    Celmezo = _jatek.Palya.MezoList[3];
                    MezoCel.Text = Celmezo.Name;
                }
                else
                {
                    MessageBox.Show("Nem szomtédos mezõ!", "Nem megengedett akció");
                }
            }
            else if (parancs == ParancsMod.Semmi)
            {
                if (_jatek.Palya.MezoList[3].Tulajdonos == CurrentJatekos && _jatek.Palya.MezoList[3].Szabad)
                {
                    temp = _jatek.Palya.MezoList[3];
                    Relocate((Button)sender);
                }
            }
        }

        private void ButtonMezo5_Click(object sender, EventArgs e)
        {
            if (parancs == ParancsMod.Mozgas)
            {
                temp = _jatek.Palya.MezoList[4];
                if (temp.Mezok.Contains(AktualisMezo))
                {
                    Celmezo = _jatek.Palya.MezoList[4];
                    MezoCel.Text = Celmezo.Name;
                }
                else
                {
                    MessageBox.Show("Nem szomtédos mezõ!", "Nem megengedett akció");
                }
            }
            else if (parancs == ParancsMod.Semmi)
            {
                if (_jatek.Palya.MezoList[4].Tulajdonos == CurrentJatekos && _jatek.Palya.MezoList[4].Szabad)
                {
                    temp = _jatek.Palya.MezoList[4];
                    Relocate((Button)sender);
                }
            }
        }

        private void ButtonMezo6_Click(object sender, EventArgs e)
        {
            if (parancs == ParancsMod.Mozgas)
            {
                temp = _jatek.Palya.MezoList[5];
                if (temp.Mezok.Contains(AktualisMezo))
                {
                    Celmezo = _jatek.Palya.MezoList[5];
                    MezoCel.Text = Celmezo.Name;
                }
                else
                {
                    MessageBox.Show("Nem szomtédos mezõ!", "Nem megengedett akció");
                }
            }
            else if (parancs == ParancsMod.Semmi)
            {
                if (_jatek.Palya.MezoList[5].Tulajdonos == CurrentJatekos && _jatek.Palya.MezoList[5].Szabad)
                {
                    temp = _jatek.Palya.MezoList[5];
                    Relocate((Button)sender);
                }
            }
        }

        private void ButtonMezo7_Click(object sender, EventArgs e)
        {
            if (parancs == ParancsMod.Mozgas)
            {
                temp = _jatek.Palya.MezoList[6];
                if (temp.Mezok.Contains(AktualisMezo))
                {
                    Celmezo = _jatek.Palya.MezoList[6];
                    MezoCel.Text = Celmezo.Name;
                }
                else
                {
                    MessageBox.Show("Nem szomtédos mezõ!", "Nem megengedett akció");
                }
            }
            else if (parancs == ParancsMod.Semmi)
            {
                if (_jatek.Palya.MezoList[6].Tulajdonos == CurrentJatekos && _jatek.Palya.MezoList[6].Szabad)
                {
                    temp = _jatek.Palya.MezoList[6];
                    Relocate((Button)sender);
                }
            }
        }

        private void ButtonMezo8_Click(object sender, EventArgs e)
        {
            if (parancs == ParancsMod.Mozgas)
            {
                temp = _jatek.Palya.MezoList[7];
                if (temp.Mezok.Contains(AktualisMezo))
                {
                    Celmezo = _jatek.Palya.MezoList[7];
                    MezoCel.Text = Celmezo.Name;
                }
                else
                {
                    MessageBox.Show("Nem szomtédos mezõ!", "Nem megengedett akció");
                }
            }
            else if (parancs == ParancsMod.Semmi)
            {
                if (_jatek.Palya.MezoList[7].Tulajdonos == CurrentJatekos && _jatek.Palya.MezoList[7].Szabad)
                {
                    temp = _jatek.Palya.MezoList[7];
                    Relocate((Button)sender);
                }
            }
        }

        private void ButtonMezo9_Click(object sender, EventArgs e)
        {
            if (parancs == ParancsMod.Mozgas)
            {
                temp = _jatek.Palya.MezoList[8];
                if (temp.Mezok.Contains(AktualisMezo))
                {
                    Celmezo = _jatek.Palya.MezoList[8];
                    MezoCel.Text = Celmezo.Name;
                }
                else
                    MessageBox.Show("Nem szomtédos mezõ!", "Nem megengedett akció");
            }
            else if (parancs == ParancsMod.Semmi)
            {
                if (_jatek.Palya.MezoList[8].Tulajdonos == CurrentJatekos && _jatek.Palya.MezoList[8].Szabad)
                {
                    temp = _jatek.Palya.MezoList[8];
                    Relocate((Button)sender);
                }
            }
        }

        private void ButtonMezo10_Click(object sender, EventArgs e)
        {
            if (parancs == ParancsMod.Mozgas)
            {
                temp = _jatek.Palya.MezoList[9];
                if (temp.Mezok.Contains(AktualisMezo))
                {
                    Celmezo = _jatek.Palya.MezoList[9];
                    MezoCel.Text = Celmezo.Name;
                }
                else
                    MessageBox.Show("Nem szomtédos mezõ!", "Nem megengedett akció");
            }
            else if (parancs == ParancsMod.Semmi)
            {
                if (_jatek.Palya.MezoList[9].Tulajdonos == CurrentJatekos && _jatek.Palya.MezoList[9].Szabad)
                {
                    temp = _jatek.Palya.MezoList[9];
                    Relocate((Button)sender);
                }
            }
        }

        private void ButtonMezo11_Click(object sender, EventArgs e)
        {
            if (parancs == ParancsMod.Mozgas)
            {
                temp = _jatek.Palya.MezoList[10];
                if (temp.Mezok.Contains(AktualisMezo))
                {
                    Celmezo = _jatek.Palya.MezoList[10];
                    MezoCel.Text = Celmezo.Name;
                }
                else
                    MessageBox.Show("Nem szomtédos mezõ!", "Nem megengedett akció");
            }
            else if (parancs == ParancsMod.Semmi)
            {
                if (_jatek.Palya.MezoList[10].Tulajdonos == CurrentJatekos && _jatek.Palya.MezoList[10].Szabad)
                {
                    temp = _jatek.Palya.MezoList[10];
                    Relocate((Button)sender);
                }
            }
        }

        private void ButtonMezo12_Click(object sender, EventArgs e)
        {
            if (parancs == ParancsMod.Mozgas)
            {
                temp = _jatek.Palya.MezoList[11];
                if (temp.Mezok.Contains(AktualisMezo))
                {
                    Celmezo = _jatek.Palya.MezoList[11];
                    MezoCel.Text = Celmezo.Name;
                }
                else
                    MessageBox.Show("Nem szomtédos mezõ!", "Nem megengedett akció");
            }
            else if (parancs == ParancsMod.Semmi)
            {
                if (_jatek.Palya.MezoList[11].Tulajdonos == CurrentJatekos && _jatek.Palya.MezoList[11].Szabad)
                {
                    temp = _jatek.Palya.MezoList[11];
                    Relocate((Button)sender);
                }
            }
        }

        private void ButtonMezo13_Click(object sender, EventArgs e)
        {
            if (parancs == ParancsMod.Mozgas)
            {
                temp = _jatek.Palya.MezoList[12];
                if (temp.Mezok.Contains(AktualisMezo))
                {
                    Celmezo = _jatek.Palya.MezoList[12];
                    MezoCel.Text = Celmezo.Name;
                }
                else
                    MessageBox.Show("Nem szomszédos mezõ!", "Nem megengedett akció");
            }
            else if (parancs == ParancsMod.Semmi)
            {
                if (_jatek.Palya.MezoList[12].Tulajdonos == CurrentJatekos && _jatek.Palya.MezoList[12].Szabad)
                {
                    temp = _jatek.Palya.MezoList[12];
                    Relocate((Button)sender);
                }
            }
        }

        #endregion

        #region Iranyito gombok
        private void Relocate(Button button)
        {
            if (!Parancsablak.Visible)
                Parancsablak.Visible = true;
            Parancsablak.Location = new Point(button.Location.X + button.Width, button.Location.Y + button.Height);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Parancsablak.Visible = false;
            temp = null!;
        }

        private void Move_Click(object sender, EventArgs e)
        {
            Parancsablak.Visible = false;
            parancs = ParancsMod.Mozgas;
            ParancsTipus.Text = "Mozgás";
            SelectMezo.Text = temp.Name;
            MezoCel.Text = "-";
            AktualisMezo = temp;
            GyalogosSzam.Visible = true;
            TGyalogosSzam.Visible = true;
            LovagSzam.Visible = true;
            TLovagSzam.Visible = true;
            ConfirmMove.Visible = true;
            CancelMove.Visible = true;
            TParancsTipus.Visible = true;
            ParancsTipus.Visible = true;
            TSelectMezo.Visible = true;
            SelectMezo.Visible = true;
            TMezoCel.Visible = true;
            MezoCel.Visible = true;
            GyalogosSzam.Maximum = AktualisMezo.Allegyseg.Egysegek[Egysegtipus.Gyalogos];
            LovagSzam.Maximum = AktualisMezo.Allegyseg.Egysegek[Egysegtipus.Lovag];
            temp = null!;

        }

        private void Defend_Click(object sender, EventArgs e)
        {
            Parancsablak.Visible = false;
            parancs = ParancsMod.Vedekezes;
            ParancsTipus.Text = "Védekezés";
            SelectMezo.Text = temp.Name;
            AktualisMezo = temp;
            ConfirmMove.Visible = true;
            CancelMove.Visible = true;
            TParancsTipus.Visible = true;
            ParancsTipus.Visible = true;
            TSelectMezo.Visible = true;
            SelectMezo.Visible = true;
            temp = null!;
        }

        private void Reinforcement_Click(object sender, EventArgs e)
        {
            if (_jatek.CurrentPlayer.Toborzas != 0)
            {
                Parancsablak.Visible = false;
                parancs = ParancsMod.Toborzas;
                ParancsTipus.Text = "Toborzás";
                SelectMezo.Text = temp.Name;
                AktualisMezo = temp;
                ConfirmMove.Visible = true;
                CancelMove.Visible = true;
                TParancsTipus.Visible = true;
                ParancsTipus.Visible = true;
                TSelectMezo.Visible = true;
                SelectMezo.Visible = true;
                TGyal.Visible = true;
                TLo.Visible = true;
                temp = null!;
            }
            else
            {
                MessageBox.Show("Nem tudsz többet toborozni", "Nem megengedett akció");
            }
        }

        private void CancelMove_Click(object sender, EventArgs e)
        {
            parancs = ParancsMod.Semmi;
            HideEverything();
            Celmezo = null!;
            AktualisMezo = null!;
        }

        private void HideEverything()
        {
            GyalogosSzam.Visible = false;
            TGyalogosSzam.Visible = false;
            LovagSzam.Visible = false;
            TLovagSzam.Visible = false;
            ConfirmMove.Visible = false;
            CancelMove.Visible = false;
            TParancsTipus.Visible = false;
            ParancsTipus.Visible = false;
            TSelectMezo.Visible = false;
            SelectMezo.Visible = false;
            TMezoCel.Visible = false;
            MezoCel.Visible = false;
            TGyal.Visible = false;
            TLo.Visible = false;
        }

        private void ConfirmMove_Click(object sender, EventArgs e)
        {
            switch (parancs)
            {
                case ParancsMod.Toborzas:
                    if (TGyal.Checked == true)
                    {
                        _jatek.ParancsFelvesz(new Toborzas(_jatek.CurrentPlayer, Egysegtipus.Gyalogos, _jatek, AktualisMezo));
                        _jatek.CurrentPlayer.Toboroz();
                    }
                    if (TLo.Checked == true)
                    {
                        _jatek.ParancsFelvesz(new Toborzas(_jatek.CurrentPlayer, Egysegtipus.Lovag, _jatek, AktualisMezo));
                        _jatek.CurrentPlayer.Toboroz();
                    }
                    parancs = ParancsMod.Semmi;
                    break;
                case ParancsMod.Mozgas:
                    if (((int)GyalogosSzam.Value > 0 || (int)LovagSzam.Value > 0) && Celmezo != null)
                    {
                        tmpegyseg = new Egyseg(_jatek.CurrentPlayer);
                        tmpegyseg.TeremEgyseg(Egysegtipus.Gyalogos, (int)GyalogosSzam.Value);
                        tmpegyseg.TeremEgyseg(Egysegtipus.Lovag, (int)LovagSzam.Value);
                        _jatek.ParancsFelvesz(new Mozgatas(AktualisMezo, Celmezo, tmpegyseg, _jatek));
                        parancs = ParancsMod.Semmi;
                        GyalogosSzam.Value = 0;
                        LovagSzam.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Nem választottál katonát vagy nem választottál célmezõt", "Nem megengedett akció");
                    }
                    break;
                case ParancsMod.Vedekezes:
                    _jatek.ParancsFelvesz(new Vedekezes(AktualisMezo.Allegyseg, _jatek));
                    parancs = ParancsMod.Semmi;
                    break;
            }
            if (parancs == ParancsMod.Semmi)
            {
                AktualisMezo.Cseleked();
                HideEverything();
                Celmezo = null!;
                AktualisMezo = null!;
            }
        }

        private void Leptet_Click(object sender, EventArgs e)
        {
            if (_jatek.IsVege())
            {
                MessageBox.Show(_jatek.Gyoztes + " a gyõztes", "Játék vége");
                for (int i = 0; i < 13; i++)
                {
                    _gombok[i].Enabled = false;
                }
                Leptet.Enabled = false;

            }
            if (parancs == ParancsMod.Semmi && !_jatek.IsVege())
            {
                _jatek.Leptet();
                if (_jatek.Index < 3)
                    CurrentJatekos = _jatek.CurrentPlayer;
                if (_jatek.Index < 3 && CurrentJatekos == _jatek.Jatekos1)
                {
                    MessageBox.Show("Új kört kezdõtött", "Kör vége");
                    MessageBox.Show("1. játékos köre", "Kör átadás");
                    Green1.Visible = true;
                    Green2.Visible = false;
                    Green3.Visible = false;
                }
                else if (_jatek.Index < 3 && CurrentJatekos == _jatek.Jatekos2)
                {
                    MessageBox.Show("2. játékos köre", "Kör átadás");
                    Green2.Visible = true;
                    Green3.Visible = false;
                    Green1.Visible = false;
                }
                else if (_jatek.Index < 3 && CurrentJatekos == _jatek.Jatekos3)
                {
                    MessageBox.Show("3. játékos köre", "Kör átadás");
                    Green3.Visible = true;
                    Green2.Visible = false;
                    Green1.Visible = false;
                }
                RefreshTable();
            }
        }
        #endregion

        #region Frissít metódusok
        private void RefreshTable()
        {
            switch (_jatek.Stage)
            {
                case 0:
                    StageName.Text = "Tervezes";
                    RefreshStatus();
                    break;
                case 1:
                    StageName.Text = "Vedekezes";
                    RefreshShield();
                    break;
                case 2:
                    StageName.Text = "Toborzas";
                    RefreshAll();
                    break;
                case 3:
                    StageName.Text = "Mozgas";
                    RefreshBattle();
                    RefreshAll();
                    break;
                case 4:
                    StageName.Text = "Csata";
                    break;
                case 5:
                    StageName.Text = "Elfoglalas";
                    RefreshButton();
                    break;
                case 6:
                    StageName.Text = "Visszavonulas";
                    RefreshZero();
                    RefreshAll();
                    break;
                case 7:
                    StageName.Text = "Vedekezes leáll";
                    UnrefreshShield();
                    break;
            }

        }

        private void RefreshStatus()
        {
            Player1Arany.Text = _jatek.Jatekos1.Kincstar.Arany.ToString();
            Player1Utan.Text = _jatek.Jatekos1.Sereg.UtanPotlas.ToString();
            Player2Arany.Text = _jatek.Jatekos2.Kincstar.Arany.ToString();
            Player2Utan.Text = _jatek.Jatekos2.Sereg.UtanPotlas.ToString();
            Player3Arany.Text = _jatek.Jatekos3.Kincstar.Arany.ToString();
            Player3Utan.Text = _jatek.Jatekos3.Sereg.UtanPotlas.ToString();
            korSzam.Text = _jatek.KorokSzama.ToString();
        }

        private void RefreshZero()
        {
            for (int i = 0; i < 13; i++)
            {
                _kekGyal[i].Visible = false;
                _bkekGyal[i].Visible = false;
                _kekLo[i].Visible = false;
                _bkekLo[i].Visible = false;
                _pirosGyal[i].Visible = false;
                _bpirosGyal[i].Visible = false;
                _pirosLo[i].Visible = false;
                _bpirosLo[i].Visible = false;
                _zoldGyal[i].Visible = false;
                _bzoldGyal[i].Visible = false;
                _zoldLo[i].Visible = false;
                _bzoldLo[i].Visible = false;
            }
        }

        private void RefreshAll()
        {
            for (int i = 0; i < 13; i++)
            {
                Jatekos tmp = _jatek.Palya.MezoList[i].Allegyseg.Jatekos;
                if (_jatek.Palya.MezoList[i].Allegyseg.Egysegek[Egysegtipus.Gyalogos] > 0)
                {
                    String tmpsz = _jatek.Palya.MezoList[i].Allegyseg.Egysegek[Egysegtipus.Gyalogos].ToString();
                    if (tmp == _jatek.Jatekos1)
                    {
                        _kekGyal[i].Visible = true;
                        _bkekGyal[i].Visible = true;
                        _kekGyal[i].Text = ":" + tmpsz;
                    }
                    if (tmp == _jatek.Jatekos2)
                    {
                        _pirosGyal[i].Visible = true;
                        _bpirosGyal[i].Visible = true;
                        _pirosGyal[i].Text = ":" + tmpsz;
                    }
                    if (tmp == _jatek.Jatekos3)
                    {
                        _zoldGyal[i].Visible = true;
                        _bzoldGyal[i].Visible = true;
                        _zoldGyal[i].Text = ":" + tmpsz;
                    }
                }
                else
                {
                    if (tmp == _jatek.Jatekos1)
                    {
                        _bkekGyal[i].Visible = false;
                        _kekGyal[i].Text = "0";
                        _kekGyal[i].Visible = false;
                    }
                    if (tmp == _jatek.Jatekos2)
                    {
                        _bpirosGyal[i].Visible = false;
                        _pirosGyal[i].Visible = false;
                        _pirosGyal[i].Text = "0";
                    }
                    if (tmp == _jatek.Jatekos3)
                    {
                        _bzoldGyal[i].Visible = false;
                        _zoldGyal[i].Visible = false;
                        _zoldGyal[i].Text = "0";
                    }
                }
                if (_jatek.Palya.MezoList[i].Allegyseg.Egysegek[Egysegtipus.Lovag] > 0)
                {
                    String tmpsz = _jatek.Palya.MezoList[i].Allegyseg.Egysegek[Egysegtipus.Lovag].ToString();
                    if (tmp == _jatek.Jatekos1)
                    {
                        _bkekLo[i].Visible = true;
                        _kekLo[i].Visible = true;
                        _kekLo[i].Text = ":" + tmpsz;
                    }
                    if (tmp == _jatek.Jatekos2)
                    {
                        _bpirosLo[i].Visible = true;
                        _pirosLo[i].Visible = true;
                        _pirosLo[i].Text = ":" + tmpsz;
                    }
                    if (tmp == _jatek.Jatekos3)
                    {
                        _bzoldLo[i].Visible = true;
                        _zoldLo[i].Visible = true;
                        _zoldLo[i].Text = ":" + tmpsz;
                    }
                }
                else
                {
                    if (tmp == _jatek.Jatekos1)
                    {
                        _bkekLo[i].Visible = false;
                        _kekLo[i].Visible = false;
                        _kekLo[i].Text = "0";
                    }
                    if (tmp == _jatek.Jatekos2)
                    {
                        _bpirosLo[i].Visible = false;
                        _pirosLo[i].Visible = false;
                        _pirosLo[i].Text = "0";
                    }
                    if (tmp == _jatek.Jatekos3)
                    {
                        _bzoldLo[i].Visible = false;
                        _zoldLo[i].Visible = false;
                        _zoldLo[i].Text = "0";
                    }
                }
            }

        }

        private void RefreshButton()
        {
            for (int i = 0; i < 13; i++)
            {
                if (_jatek.Palya.MezoList[i].Tulajdonos == _jatek.Jatekos1)
                {
                    _gombok[i].BackgroundImage = new Bitmap(@"C:\MyPrograms\SzakDolgozat\Tronokharca\Jatek.View\Resource\KekZasz.png");
                }
                else if (_jatek.Palya.MezoList[i].Tulajdonos == _jatek.Jatekos2)
                {
                    _gombok[i].BackgroundImage = new Bitmap(@"\MyPrograms\SzakDolgozat\Tronokharca\Jatek.View\Resource\Piroszasz.png");
                }
                else if (_jatek.Palya.MezoList[i].Tulajdonos == _jatek.Jatekos3)
                {
                    _gombok[i].BackgroundImage = new Bitmap(@"\MyPrograms\SzakDolgozat\Tronokharca\Jatek.View\Resource\Greenzasz.png");
                }
                else
                {
                    _gombok[i].BackgroundImage = new Bitmap(@"\MyPrograms\SzakDolgozat\Tronokharca\Jatek.View\Resource\Feher.png");
                }
            }
        }

        private void RefreshBattle()
        {
            for (int i = 0; i < 13; i++)
            {
                if (_jatek.Palya.MezoList[i].RMezoCsata != null)
                {
                    for (int j = 0; j < _jatek.Palya.MezoList[i].RMezoCsata.harcegyseg.Count; j++)
                    {
                        if (_jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Jatekos == _jatek.Jatekos1)
                        {
                            if (_jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Egysegek[Egysegtipus.Gyalogos] > 0)
                            {
                                _kekGyal[i].Text = ":" + _jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Egysegek[Egysegtipus.Gyalogos].ToString();
                                _kekGyal[i].Visible = true;
                                _bkekGyal[i].Visible = true;
                            }
                            if (_jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Egysegek[Egysegtipus.Lovag] > 0)
                            {
                                _kekLo[i].Text = ":" + _jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Egysegek[Egysegtipus.Lovag].ToString();
                                _kekLo[i].Visible = true;
                                _bkekLo[i].Visible = true;
                            }
                        }
                        else if (_jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Jatekos == _jatek.Jatekos2)
                        {
                            if (_jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Egysegek[Egysegtipus.Gyalogos] > 0)
                            {
                                _pirosGyal[i].Text = ":" + _jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Egysegek[Egysegtipus.Gyalogos].ToString();
                                _pirosGyal[i].Visible = true;
                                _bpirosGyal[i].Visible = true;
                            }
                            if (_jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Egysegek[Egysegtipus.Lovag] > 0)
                            {
                                _pirosLo[i].Text = ":" + _jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Egysegek[Egysegtipus.Lovag].ToString();
                                _pirosLo[i].Visible = true;
                                _bpirosLo[i].Visible = true;
                            }
                        }
                        else if (_jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Jatekos == _jatek.Jatekos3)
                        {
                            if (_jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Egysegek[Egysegtipus.Gyalogos] > 0)
                            {
                                _zoldGyal[i].Text = ":" + _jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Egysegek[Egysegtipus.Gyalogos].ToString();
                                _zoldGyal[i].Visible = true;
                                _bzoldGyal[i].Visible = true;
                            }
                            if (_jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Egysegek[Egysegtipus.Lovag] > 0)
                            {
                                _zoldLo[i].Text = ":" + _jatek.Palya.MezoList[i].RMezoCsata.harcegyseg[j].Egysegek[Egysegtipus.Lovag].ToString();
                                _zoldLo[i].Visible = true;
                                _bzoldLo[i].Visible = true;
                            }
                        }
                    }
                }
            }
        }

        public void RefreshShield()
        {
            for (int i = 0; i < 13; i++)
            {
                if (_jatek.Palya.MezoList[i].Allegyseg.Vedekezo == true)
                {
                    _shields[i].Visible = true;
                }
            }
        }

        public void UnrefreshShield()
        {
            for (int i = 0; i < 13; i++)
            {
                if (_shields[i].Visible == true)
                {
                    _shields[i].Visible = false;
                }
            }
        }

        public void Remove()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        #endregion
        private void UjJatek_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Újra szeretnéd kezdeni a játékot?", "Játék újrakezdés", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _jatek.Ujjatek();
                RefreshZero();
                UnrefreshShield();
                RefreshAll();
                RefreshButton();
                RefreshStatus();
                Green1.Visible = true;
                Green2.Visible = false;
                Green3.Visible = false;
                for (int i = 0; i < 13; i++)
                {
                    _gombok[i].Enabled = true;
                }
                Leptet.Enabled = true;
                CurrentJatekos = _jatek.CurrentPlayer;
                StageName.Text = "Tervezés";
            }

        }
    }
}