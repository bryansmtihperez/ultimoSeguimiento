using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaDeNegocio;

namespace LogicaDeNegocioTest
{
    [TestClass]
    public class GestorTestEps
    {
        [TestMethod]
        public void TestGestionEps()
        {
            string EpsEsperada = "{'nombre':'Sura'}";
            GestorEps Gp = new GestorEps();
            Assert.AreEqual(EpsEsperada, Gp.MostrarEps("Sura"));

        }
    }
}
