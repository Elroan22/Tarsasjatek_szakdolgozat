using System;
using System.Threading.Tasks;
using Játék;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace JatekTest
{
    [TestClass]
    public class JatekTest
    {
        private JatekModel _model = null!;

        [TestInitialize]
        public void Initialize()
        {
            _model = new JatekModel();
        }

        [TestMethod]
        public void MozgasTeszt()
        {
            _model.Ujjatek();
            _model.Palya.MezoList[1].Elfoglalas(_model.Jatekos1);
            _model.Palya.MezoList[0].egyseghozzaad(Egysegtipus.Gyalogos);
            Egyseg egyseg = new Egyseg(_model.Jatekos1);
            egyseg.TeremEgyseg(Egysegtipus.Lovag, 0);
            Egyseg megyseg = new Egyseg(_model.Jatekos1);
            _model.Palya.MezoList[1].ralep(egyseg);
            _model.ParancsFelvesz(new Mozgatas(_model.Palya.MezoList[0], _model.Palya.MezoList[1], megyseg, _model));
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            Assert.AreEqual(2, _model.Palya.MezoList[1].Allegyseg.Egysegek[Egysegtipus.Gyalogos]);
            Assert.AreEqual(1, _model.Palya.MezoList[1].Allegyseg.Egysegek[Egysegtipus.Lovag]);
            Assert.AreEqual(1, _model.Palya.MezoList[0].Allegyseg.Egysegek[Egysegtipus.Gyalogos]);
            Assert.AreEqual(0, _model.Palya.MezoList[0].Allegyseg.Egysegek[Egysegtipus.Lovag]);

        }

        [TestMethod]
        public void ToborzasTeszt()
        {
            _model.Ujjatek();
            _model.ParancsFelvesz(new Toborzas(_model.Jatekos2, Egysegtipus.Gyalogos, _model, _model.Palya.MezoList[8]));
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            Assert.AreEqual(2, _model.Palya.MezoList[8].Allegyseg.Egysegek[Egysegtipus.Gyalogos]);
               
        }

        [TestMethod]
        public void VedekezesTeszt()
        {
            _model.Ujjatek();
            _model.Palya.MezoList[2].Elfoglalas(_model.Jatekos1);
            Egyseg egyseg = new Egyseg(_model.Jatekos1);
            _model.Palya.MezoList[2].ralep(egyseg);
            _model.ParancsFelvesz(new Vedekezes(_model.Palya.MezoList[2].Allegyseg, _model));
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            Assert.AreEqual(true, _model.Palya.MezoList[2].Allegyseg.Vedekezo);
        }

        [TestMethod]
        public void VedekezesCsataTeszt()
        {
            _model.Ujjatek();
            _model.Palya.MezoList[3].Elfoglalas(_model.Jatekos1);
            _model.Palya.MezoList[5].Elfoglalas(_model.Jatekos2);
            Egyseg fegyseg = new Egyseg(_model.Jatekos1);
            fegyseg.TeremEgyseg(Egysegtipus.Lovag, 0);           
            Egyseg segyseg = new Egyseg(_model.Jatekos2); 
            segyseg.TeremEgyseg(Egysegtipus.Lovag, 0);
            _model.Palya.MezoList[3].ralep(fegyseg);
            _model.Palya.MezoList[5].ralep(segyseg);
            _model.ParancsFelvesz(new Vedekezes(_model.Palya.MezoList[3].Allegyseg, _model));
            _model.ParancsFelvesz(new Mozgatas(_model.Palya.MezoList[5], _model.Palya.MezoList[3], segyseg, _model));
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            Assert.AreEqual(_model.Jatekos1, _model.Palya.MezoList[3].Tulajdonos);

        }

        [TestMethod]
        public void VisszavonulTeszt()
        {
            _model.Ujjatek();
            _model.Palya.MezoList[5].Elfoglalas(_model.Jatekos1);
            _model.Palya.MezoList[7].Elfoglalas(_model.Jatekos2);
            _model.Palya.MezoList[9].Elfoglalas(_model.Jatekos2);
            Egyseg fegyseg = new Egyseg(_model.Jatekos1);
            Egyseg segyseg = new Egyseg(_model.Jatekos2);
            segyseg.TeremEgyseg(Egysegtipus.Lovag, 0);
            segyseg.Addegyseg(Egysegtipus.Gyalogos);
            _model.Palya.MezoList[5].ralep(fegyseg);
            _model.Palya.MezoList[7].ralep(segyseg);
            _model.ParancsFelvesz(new Mozgatas(_model.Palya.MezoList[7], _model.Palya.MezoList[5], segyseg, _model));
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            _model.Palya.MezoList[7].Elfoglalas(_model.Jatekos1);
            _model.Palya.MezoList[8].Elfoglalas(_model.Jatekos1);
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            Assert.AreEqual(1, _model.Palya.MezoList[9].Allegyseg.Egysegek[Egysegtipus.Gyalogos]);
            Assert.AreEqual(0, _model.Palya.MezoList[7].Allegyseg.Egysegek[Egysegtipus.Gyalogos]);

        }

        [TestMethod]
        public void ElfoglalTeszt()
        {
            _model.Ujjatek();
            Egyseg egyseg = new Egyseg(_model.Jatekos1);
            egyseg.TeremEgyseg(Egysegtipus.Lovag, 0);
            _model.ParancsFelvesz(new Mozgatas(_model.Palya.MezoList[0], _model.Palya.MezoList[1], egyseg, _model));
            Assert.AreEqual(null, _model.Palya.MezoList[1].Tulajdonos);
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            _model.Leptet();
            Assert.AreEqual(_model.Jatekos1, _model.Palya.MezoList[1].Tulajdonos);
            Assert.AreEqual(2, _model.Jatekos1.Kincstar.Arany_kor);
            Assert.AreEqual(5, _model.Jatekos1.Sereg.UtanPotlas);
        }
    }
}