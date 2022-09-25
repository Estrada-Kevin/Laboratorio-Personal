using Microsoft.VisualStudio.TestTools.UnitTesting;
using Segui_participando;

namespace Segui_Participando_prueba_unitaria
{
    [TestClass]
    public class SeguiParticipandoUnitTest
    {
        [TestMethod]
        public void CompetenciaTest1()
        {
            Competencia competencia = new Competencia(5, 5, TipoCompetencia.F1);

            Assert.IsNotNull(competencia.Competidores);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponible))]
        public void CompetenciaTest2()
        {
            Competencia competencia = new Competencia(5, 5, TipoCompetencia.F1);
            MotoCross moto = new MotoCross(5, "Pastizales");

            Competencia.lanzarCompetenciaExcepcion(competencia, moto);
        }

        [TestMethod]
        public void CompetenciaTest3()
        {
            Competencia competencia = new Competencia(5, 5, TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(5, "Pastizales");

            Competencia.lanzarCompetenciaExcepcion(competencia, moto);

        }

        [TestMethod]
        public void CompetenciaTest4()
        {
            Competencia competencia = new Competencia(5, 5, TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(5, "Pastizales");
            _ = competencia + moto;

            Assert.IsTrue(competencia == moto);

        }

        [TestMethod]
        public void CompetenciaTest5()
        {
            Competencia competencia = new Competencia(5, 5, TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(5, "Pastizales");
            _ = competencia + moto;

            _ = competencia - moto;

            Assert.IsTrue(competencia != moto);

        }


    }
}
