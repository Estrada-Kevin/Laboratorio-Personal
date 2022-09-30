using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControlDeAduana;
using System.Collections.Generic;

namespace Control_De_Aduana_Tests
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            List<Paquete> listaAduana = new List<Paquete>();
            decimal valorEsperado = 1.4M;
            listaAduana.Add(new PaqueteFragil("", 2, "", "", 1));
            listaAduana.Add(new PaquetePesado("", 2, "", "", 1));

            gestionImpuestos.RegistrarImpuestos(listaAduana);

            Assert.IsTrue(gestionImpuestos.CalcularTotalImpuestosAduana() == valorEsperado);   
        }
        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            List<Paquete> listaAfip = new List<Paquete>();
            decimal valorEsperado = 0.5M;
            listaAfip.Add(new PaqueteFragil("", 2, "", "", 1));
            listaAfip.Add(new PaquetePesado("", 2, "", "", 1));

            gestionImpuestos.RegistrarImpuestos(listaAfip);

            Assert.IsTrue(gestionImpuestos.CalcularTotalImpuestosAfip() == valorEsperado);

        }
    }
}
