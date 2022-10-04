using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadoraUnitaria;


namespace CalculadoraTest
{
    [TestClass]
    public class CalculadoraUnitTest
    {
        [TestMethod]
        public void AddPrueba1()
        {
            string numeros = "5,6";

            int resultado = CalculadoraPrueba.Add(numeros);
            
            Assert.AreEqual(resultado, 11);
        }

        [TestMethod]
        public void AddPrueba2()
        {
            string numeros = "5,6,7,8";

            int resultado = CalculadoraPrueba.AddV2(numeros);

            Assert.AreEqual(resultado, 26);

        }

        [TestMethod]
        public void AddPrueba3()
        {
            string numeros = "1 \n2,3";

            int resultado = CalculadoraPrueba.AddV3(numeros);

            Assert.AreEqual(resultado, 6);

        }

        [TestMethod]
        public void AddPrueba4()
        {
            string numeros = "//;\n1;2,5,6";

            int resultado = CalculadoraPrueba.AddV4(numeros);

            Assert.AreEqual(resultado, 14);

        }

        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void AddPrueba5()
        {
            string numeros = "//;\n1;2,5,-5";

            int resultado = CalculadoraPrueba.AddV5(numeros);

            //Assert.AreEqual(resultado, 14);

        }
    }
}
