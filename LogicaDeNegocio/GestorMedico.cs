using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaDeNegocio
{
    public class GestorMedico
    {   
        MedicoModel obj1 = new MedicoModel();

        public string MostrarInfomedico(int cedula, string nombre)
        {

            string medico;
            medico = obj1.MostrarMedico(cedula, nombre);
            return medico;
        }

        public string MostrarmedicosxCentro(string nombre)
        {
            string medico;
            medico = obj1.MostrarMedicoxcentro(nombre);
            return medico;
        }

        
    }
}

