using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IO__notepad_;

namespace NotePad_Tests
{
    [TestClass]
    public class NotepadTests
    {
        [TestMethod]
        public void JsonValidarExtensionDevuelveTrue()
        {
            PuntoJson<string> json = new PuntoJson<string>();

            bool auxiliar = json.ValidarExtension(".json");

            Assert.IsTrue(auxiliar);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void JsonValidarExtensionDevuelveFalse()
        {
            PuntoJson<string> json = new PuntoJson<string>();

            bool auxiliar = json.ValidarExtension(".git");

            Assert.AreEqual(true, auxiliar);
        }

        [TestMethod]
        public void XmlValidarExtensionDevuelveTrue()
        {
            PuntoXml<string> xml = new PuntoXml<string>();

            bool auxiliar = xml.ValidarExtension(".xml");

            Assert.AreEqual(true, auxiliar);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void XmlValidarExtensionDevuelveFalse()
        {
            PuntoXml<string> xml = new PuntoXml<string>();

            bool auxiliar = xml.ValidarExtension(".git");

            Assert.AreEqual(true, auxiliar);
        }

        [TestMethod]
        public void TxtValidarExtensionDevuelveTrue()
        {
            PuntoTxt txt = new PuntoTxt();

            bool auxiliar = txt.ValidarExtension(".txt");

            Assert.AreEqual(true, auxiliar);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void TxtValidarExtensionDevuelveFalse()
        {
            PuntoTxt txt = new PuntoTxt();

            bool auxiliar = txt.ValidarExtension(".git");

            Assert.AreEqual(true, auxiliar);
        }
    }
}
