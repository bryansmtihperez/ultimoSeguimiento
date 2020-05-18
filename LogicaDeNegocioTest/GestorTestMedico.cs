using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaDeNegocio;

namespace LogicaDeNegocioTest
{
    [TestClass]
    public class GestorTestMedico
    {
        [TestMethod]
        public void TestGestionMedico()
        {
            string MedicoEsperado = "{'nombre':'Juan Esteban','apellido':'Betancur','cedula':1026163148,'telefono':2654897,'direccion':'Caldas','centromedico':'Humanitas'}";
            GestorMedico Gp = new GestorMedico();
            Assert.AreEqual(MedicoEsperado, Gp.MostrarInfomedico(1026163148, "Humanitas"));
        }

        [TestMethod]
        public void TestGestionMedicoxcentromedico()
        {
            string MedicoEsperado1 = "[{'nombre':'Juan','apellido':'Vélez','cedula':1026163147,'telefono':2654897,'direccion':'Caldas','centromedico':'ClinicaAntioquia'}], [{'nombre':'Luis','apellido':'Sánchez','cedula':1026163187,'telefono':2654895,'direccion':'Medellín','centromedico':'ClinicaAntioquia'}]";
           GestorMedico Gp = new GestorMedico();
            Assert.AreEqual(MedicoEsperado1, Gp.MostrarmedicosxCentro("ClinicaAntioquia"));

        }
    }
}
