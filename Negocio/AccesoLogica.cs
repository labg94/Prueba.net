using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public class AccesoLogica
    {
        public static DataTable ObtenerPersonas()
        {
            return AccesoDatos.ObtenerPersonas();
        }

        public static DataTable BuscarPersona(int rut) {
            return AccesoDatos.BuscarPersona(rut);
        }

        public int Insert(int rut, string nombre, string apellido, string calle, int numero, string comuna) {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Insert(rut, nombre, apellido, calle, numero, comuna);

        }


        public int Modificar(int rut, string nombre, string apellido, string calle, int numero, string comuna)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Modificar(rut, nombre, apellido, calle, numero, comuna);

        }


        public static DataTable ObtenerVehiculos()
        {
            return AccesoDatos.ObtenerVehiculos();
        }

        public static DataTable BuscarVehiculoRut(int rut)
        {
            return AccesoDatos.BuscarVehiculoRut(rut);
        }

        public static DataTable BuscarVehiculoPatente(string patente)
        {
            return AccesoDatos.BuscarVehiculoPatente(patente);
        }

        public int InsertVehiculo(string patente, string marca, string modelo, int annio, string color, int rut)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.InsertVehiculo( patente,  marca,  modelo,  annio,  color,  rut);

        }


        public int ModificarVehiculo(string patente, string marca, string modelo, int annio, string color, int rut)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.ModificarVehiculo(patente, marca, modelo, annio, color, rut);

        }
    }
}
