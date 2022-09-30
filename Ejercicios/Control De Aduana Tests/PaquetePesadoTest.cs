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

            decimal valorEsperado = 2 * 0.35M;

            Assert.IsTrue(paquetePesado.Impuestos == valorEsperado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaIAfip()
        {
            PaquetePesado paquetePesado = new PaquetePesado("", 2, "", "", 2);

            decimal valorEsperado = 2 * 0.25M;

            Assert.IsTrue(((IAfip)paquetePesado).Impuestos == valorEsperado);

        }
        
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            PaquetePesado paquetePesado = new PaquetePesado("", 2, "", "", 2);

            decimal valorEsperado = 2 * 1.35M + ((IAfip)paquetePesado).Impuestos;

            Assert.IsTrue(paquetePesado.AplicarImpuestos()==valorEsperado);

        }
    }
}
