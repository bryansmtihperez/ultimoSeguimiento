using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaDeNegocio
{
    public class GestorPaciente
    {
            PacienteModel obj1 = new PacienteModel();

            public string MostrarPaciente1(string nombre)
            {

                string Paciente;
                Paciente = obj1.MostrarPaciente1(nombre);
                return Paciente;
            }

            public string MostrarPaciente(int cedula, string nombre)
            {
                string Paciente;
                Paciente = obj1.MostrarPaciente(cedula, nombre);
                return Paciente;
            }

            public bool ValidarPaciente(int usuario, string contrasena)
            {
                bool Paciente = false;
                Paciente = obj1.ValidarPaciente(usuario, contrasena);
                if ((Paciente == true))
                {
                    Paciente = true;
                }
                return Paciente;
            }     

    }
}

