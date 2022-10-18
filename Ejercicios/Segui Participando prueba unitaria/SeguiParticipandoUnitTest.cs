using Microsoft.VisualStudio.TestTools.UnitTesting;
using Segui_participando;

namespace Segui_Participando_prueba_unitaria
{
    [TestClass]
    public class SeguiParticipandoUnitTest
    {
        [TestMethod]
        public void ValidarSiEstaInstanciadaAlCrearObjeto()
        {
            Competencia competencia = new Competencia(5, 5, TipoCompetencia.F1);

            Assert.IsNotNull(competencia.Competidores);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponible))]
        public void LanzarExcepcionAlAgregarAutoEnCompetenciaMoto()
        {
            Competencia competencia = new Competencia(5, 5, TipoCompetencia.MotoCross);
            AutoF1 auto = new AutoF1(5, "perez");

            Competencia.lanzarCompetenciaExcepcion(competencia, auto);
        }

        [TestMethod]
        public void NoDeberiaLanzarExcepcionAlAgregarMotoEnCompetenciaMoto()
        {
            Competencia competencia = new Competencia(5, 5, TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(5, "Pastizales");

            Competencia.lanzarCompetenciaExcepcion(competencia, moto);

        }

        [TestMethod]
        public void ComprobarSiElAgregadoExisteEnLaLista()
        {
            Competencia competencia = new Competencia(5, 5, TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(5, "Pastizales");
            _ = competencia + moto;

            Assert.IsTrue(competencia == moto);

        }

        [TestMethod]
        public void ComprobarSiSeEliminoElElemento()
        {
            Competencia competencia = new Competencia(5, 5, TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(5, "Pastizales");
            _ = competencia + moto;

            _ = competencia - moto;

            Assert.IsTrue(competencia != moto);

        }

    }
}
