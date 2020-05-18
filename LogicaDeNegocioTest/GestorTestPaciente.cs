using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaDeNegocio;

namespace LogicaDeNegocioTest
{
    [TestClass]
    public class GestorTestPaciente
    {
        [TestMethod]
        public void TestGestionPaciente()
        {
            string pacienteEsperado = "{'nombre':'Juan','apellido':'Vélez','cedula':1026163147,'telefono':2654897,'direccion':'Caldas','eps':'Sura'}";
            GestorPaciente Gp = new GestorPaciente();
            Assert.AreEqual(pacienteEsperado, Gp.MostrarPaciente(1026163147, "Sura"));
            
        }

        [TestMethod]
        public void TestGestionPaciente1()
        {
            string pacienteEsperado1  = "[{'nombre':'Juan','apellido':'Vélez','cedula':1026163147,'telefono':2654897,'direccion':'Caldas','eps':'Sura'}], [{'nombre':'Luis','apellido':'Sánchez','cedula':1026163158,'telefono':2654898,'direccion':'Medellín','eps':'Sura'}]";
            GestorPaciente Gp = new GestorPaciente();
            Assert.AreEqual(pacienteEsperado1, Gp.MostrarPaciente1("Sura"));

        }
    }
}
