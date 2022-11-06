using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContadorDigitos;

namespace ContadorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ContadorTest()
        {
            long numeroAProbar = 21345;

            int cantidadDeDigitos = numeroAProbar.ContarCantidadDeDigitos();

            Assert.IsTrue(cantidadDeDigitos == 5);
        }
    }
}
