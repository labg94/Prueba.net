using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class MetodosDatos
    {
        public static SqlCommand CrearComando()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = System.Data.CommandType.Text;
            return _comando;
        }

        public static SqlCommand CrearComandoProc() {
            String _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("insPersona", _conexion);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            return _comando;
        }


        public static SqlCommand CrearComandoProcModificar()
        {
            String _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("modPersona", _conexion);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            return _comando;
        }



        public static SqlCommand CrearComandoProcVehiculo()
        {
            String _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("insVehiculo", _conexion);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            return _comando;
        }


        public static SqlCommand CrearComandoProcModificarVehiculo()
        {
            String _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("modVehiculo", _conexion);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            return _comando;
        }




        public static int EjecutarComandoInsert(SqlCommand comando) {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { return 0; throw;  }
            finally {
                comando.Connection.Dispose();
                comando.Connection.Close();

            }
        }

        public static int EjecutarComandoModificar(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { return 0; throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();

            }
        }

        public static DataTable EjecutarComandoSelect(SqlCommand comando) {
            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
            }
            catch (Exception ex) { throw ex; }
            finally {
                comando.Connection.Close();
            }
            return _tabla;
        }
    }
}
