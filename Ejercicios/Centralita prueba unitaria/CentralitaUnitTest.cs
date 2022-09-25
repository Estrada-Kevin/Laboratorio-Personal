using Centralita_III;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Centralita_prueba_unitaria
{
    [TestClass]
    public class CentralitaUnitTest
    {
        [TestMethod]
        public void CentralitaInstaciadaTest1()
        {
            Centralita auxiliar = new Centralita();
            
            Assert.IsTrue(auxiliar.Llamadas is not null);

        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void CentralitaInstaciadaTest2()
        {
            Centralita auxiliar = new Centralita();
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            _= auxiliar + l1;

            Local l2 = new Local("Bernal", 30532, "Rosario", 2.653123f);


            Centralita.CentralitaMetodoException(auxiliar, l2);

        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void CentralitaInstaciadaTest3()
        {
            Centralita auxiliar = new Centralita();
            Provincial l1 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            _ = auxiliar + l1;

            Provincial l2 = new Provincial("Morón", Franja.Franja_3, 25, "Bernal");


            Centralita.CentralitaMetodoException(auxiliar, l2);

        }

        [TestMethod]
        public void CentralitaInstaciadaTest4()
        {
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l2 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l3 = new Provincial("Bernal", Franja.Franja_1, 35, "Rosario");
            Provincial l4 = new Provincial("Bernal", Franja.Franja_2, 54, "Rosario");

            Assert.AreEqual(l1, l2);
            Assert.AreEqual(l3, l4);
            Assert.AreNotEqual(l1, l3);
            Assert.AreNotEqual(l1, l4);
            Assert.AreNotEqual(l2, l3);
            Assert.AreNotEqual(l2, l4);

        }
    }
}
