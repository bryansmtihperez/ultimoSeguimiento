using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaDeNegocio
{
    public class GestorEps
    {
       EpsModel obj1 = new EpsModel();
        public string MostrarEps(string nombre)
        {
            string eps;
            eps = obj1.MostrarEps(nombre);
            return eps;
        }

    }
}
