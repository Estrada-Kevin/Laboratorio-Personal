using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControlDeAduana;

namespace Control_De_Aduana_Tests
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            PaquetePesado paquetePesado = new PaquetePesado("", 1, "", "", 2.5);

            Assert.IsFalse(paquetePesado.TienePrioridad);
        }


        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            PaquetePesado paquetePesado = new PaquetePesado("", 2, "", "", 2);

            decimal auxiliar = 2 * (decimal)0.35;

            Assert.IsTrue(paquetePesado.Impuestos == auxiliar);
        }
    }
}
