using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fizzbuzz;

namespace FizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeberiaRetornarFizzBuzz()
        {
            int numeroDivisiblePorTresyCinco = 15;

            string DeberiaRetornarFizzBuzz = numeroDivisiblePorTresyCinco.FizzBuzzGame();

            Assert.IsTrue(DeberiaRetornarFizzBuzz == "FizzBuzz");
        }
    }
}
