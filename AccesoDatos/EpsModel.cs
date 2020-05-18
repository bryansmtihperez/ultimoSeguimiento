using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AccesoDatos
{
    public class EpsModel
    {
        public string MostrarEps(string nombre)
        {
            string Eps = "";



            if (nombre == "Sura")
            {
                Eps = MostrarEps1("Sura");
            }
            else
            {
                if (nombre == "Sabia")
                {
                    Eps = MostrarEps1("Sabia");
                }



            }
            return Eps;
        }


        public string MostrarEps1(string nombre)
        {
            var jsonObject = new Eps()
            {
                nombre = nombre,



            };
            string json = JsonConvert.SerializeObject(jsonObject);
            string nueva = json.Replace("\"", "'");
            return nueva;
        }
    }

    public class Eps
    {
        public string nombre { get; set; }

    }
}

