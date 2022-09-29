using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControlDeAduana;

namespace Control_De_Aduana_Tests
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            PaqueteFragil paqueteFragil = new PaqueteFragil("",1,"","",2.5);

            Assert.IsTrue(paqueteFragil.TienePrioridad);
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            PaqueteFragil paqueteFragil = new PaqueteFragil("", 2, "", "", 2);

            decimal auxiliar = 2 * (decimal)0.35;

            Assert.IsTrue(paqueteFragil.Impuestos == auxiliar);
        }

        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            PaqueteFragil paqueteFragil = new PaqueteFragil("", 2, "", "", 2);

            decimal auxiliar = 2 * (decimal)1.35;

            Assert.IsTrue(paqueteFragil.AplicarImpuestos() == auxiliar);

        }
    }
}
