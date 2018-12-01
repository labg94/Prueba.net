using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class AccesoDatos
    {

        public int Insert(int rut, string nombre, string apellido, string calle,int numero, string comuna)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc();
            _comando.Parameters.AddWithValue("@rut", rut);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@apellido", apellido);
            _comando.Parameters.AddWithValue("@calle", calle);
            _comando.Parameters.AddWithValue("@numero", numero);
            _comando.Parameters.AddWithValue("@comuna", comuna);
            return MetodosDatos.EjecutarComandoInsert(_comando);
        }


        public int Modificar(int rut, string nombre, string apellido, string calle, int numero, string comuna)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProcModificar();
            _comando.Parameters.AddWithValue("@rut", rut);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@apellido", apellido);
            _comando.Parameters.AddWithValue("@calle", calle);
            _comando.Parameters.AddWithValue("@numero", numero);
            _comando.Parameters.AddWithValue("@comuna", comuna);
            return MetodosDatos.EjecutarComandoModificar(_comando);
        }

        public static DataTable ObtenerPersonas()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM PERSONA";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }

        public static DataTable BuscarPersona(int rut)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM PERSONA where rut="+rut;
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
     
        public int InsertVehiculo(string patente, string marca, string modelo, int annio, string color, int rut)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProcVehiculo();
            _comando.Parameters.AddWithValue("@patente", patente);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@annio", annio);
            _comando.Parameters.AddWithValue("@color", color);
            _comando.Parameters.AddWithValue("@rut", rut);
            return MetodosDatos.EjecutarComandoInsert(_comando);
        }

        public int ModificarVehiculo(string patente, string marca, string modelo, int annio, string color, int rut)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProcModificarVehiculo();
            _comando.Parameters.AddWithValue("@patente", patente);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@annio", annio);
            _comando.Parameters.AddWithValue("@color", color);
            _comando.Parameters.AddWithValue("@rut", rut);
            return MetodosDatos.EjecutarComandoInsert(_comando);
        }


        public static DataTable ObtenerVehiculos()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM VEHICULO";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }

        public static DataTable BuscarVehiculoRut(int rut)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM VEHICULO where rut=" + rut;
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }

        public static DataTable BuscarVehiculoPatente(string patente)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM VEHICULO where patente='" + patente +"'";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
    }
}
