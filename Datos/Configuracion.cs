using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class Configuracion
    {
        //@"Data Source=LAPTOP-8UMA2GT2;Initial Catalog=??????;User ID=LAPTOP-8UMA2GT2;Password=2612"
        static string cadenaConexion = @"Data Source=LAPTOP-8UMA2GT2;Initial Catalog=RegistroVehiculos;Integrated Security=True";

        public static string CadenaConexion {
            get { return cadenaConexion;  }
        }
    }
}
