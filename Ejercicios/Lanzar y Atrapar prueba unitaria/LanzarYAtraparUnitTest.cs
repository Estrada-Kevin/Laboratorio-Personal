using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lanzar_y_Atrapar;
namespace Lanzar_y_Atrapar_prueba_unitaria
{
    [TestClass]
    public class LanzarYAtraparUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethod1()
        {
            int i = 1;
            int j = 0;

            MiClase.DividirPorCero(i, j);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MiClaseTest1()
        {
            MiClase miClase = new MiClase();

        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void MiClaseTest2()
        {
            MiClase miClase = new MiClase(1);

        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void OtraClaseTest1()
        {
            OtraClase.instanciarClase();

        }
    }
}
