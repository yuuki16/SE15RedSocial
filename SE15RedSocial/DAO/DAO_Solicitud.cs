using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace DAO
{
    public class DAO_Solicitud
    {

        Conexion conn = new Conexion();
        Boolean resultado;
        string sql;
        private DataSet ds = new DataSet();
        
        public Boolean ObtenerSolicitud(Solicitud solicitud)
        {

            sql = "SP_ObtenerSolicitud";
            DataTable dt = new DataTable();

            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_sl_receptor", solicitud.Receptor);
                    comando.Connection = conn.conn;
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(dt);
                    conn.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            conn.cerrarConexion();
            return resultado;
        }

        public Boolean ObtenerSolicitudesPendientes(Solicitud solicitud)
        {

            sql = "SP_ObtenerSolicitudesPendientes";

            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_sl_receptor", solicitud.Receptor);
                    comando.Connection = conn.conn;
                    SqlDataReader rd = comando.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        resultado = true;
                    }
                    else
                    {
                        resultado = false;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la consulta.", ex);
            }
            conn.cerrarConexion();
            return resultado;
        }

        public Boolean AgregarSolicitud()
        {
            sql = "SP_AgregarSolicitud";
            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.ExecuteNonQuery();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            conn.cerrarConexion();
            return resultado;
        }

        public Boolean ModificarSolicitud()
        {
            sql = "SP_ModificarSolicitud";
            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.ExecuteNonQuery();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            conn.cerrarConexion();
            return resultado;
        }

    }
}
