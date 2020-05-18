using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AccesoDatos
{
    public class MedicoModel
    {
        public string MostrarMedico (int cedula, string nombre)
        {
            string Medico = "";

            if (cedula == 1026163148 && nombre == "Humanitas")
            {
                Medico = Medicos("Juan Esteban", "Betancur", 1026163148, 2654897, "Caldas", "Humanitas");
            }
            else
            {
                if (cedula == 15429219 && nombre == "ClinicaAntioquia")
                {



                    Medico = Medicos("Juan", "Vélez", 1026163147, 2654897, "Caldas", "ClinicaAntioquia");
                }



            }
            return Medico;
        }
        public string MostrarMedicoxcentro(string nombre)
        {
            StringBuilder sb = new StringBuilder();


            if (nombre == "Humanitas")
            {
                sb.Append("[");
                sb.Append(Medicos("Juan Esteban", "Betancur", 1026163148, 2654897, "Caldas", "Humanitas"));
                sb.Append("], [");
                sb.Append(Medicos("Luis", "Sánchez", 1026163149, 2654897, "Medellín", "Humanitas"));
                sb.Append("]");
            }
            else
            {
                if (nombre == "ClinicaAntioquia")
                {
                    sb.Append("[");
                    sb.Append(Medicos("Juan", "Vélez", 1026163147, 2654897, "Caldas", "ClinicaAntioquia"));
                    sb.Append("], [");
                    sb.Append(Medicos("Luis", "Sánchez", 1026163187, 2654895, "Medellín", "ClinicaAntioquia"));
                    sb.Append("]");
                }



            }
            return sb.ToString();
        }
        public bool ValidarMedico(int usuario, string contrasena)
        {
            bool Paciente = false;
            if (usuario == 1026163148 && contrasena == "szs1")
            {
                Paciente = true;
            }
            else
            {
                if (usuario == 43216588 && contrasena == "szs2")
                {
                    Paciente = true;
                }
                else
                {
                    if (usuario == 15429219 && contrasena == "szs3")
                    {
                        Paciente = true;
                    }
                }
            }
            return Paciente;

        }

        public string Medicos(string nombre, string apellido, int cedula, int telefono, string direccion, string centromedico)
        {
            var jsonObject = new Medico()
            {
                nombre = nombre,
                apellido = apellido,
                cedula = cedula,
                telefono = telefono,
                direccion = direccion,
                centromedico = centromedico



            };
            string json = JsonConvert.SerializeObject(jsonObject);
            string nueva = json.Replace("\"", "'");
            return nueva;
        }
    }

    public class Medico
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int cedula { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public string centromedico { get; set; }


    }
}
