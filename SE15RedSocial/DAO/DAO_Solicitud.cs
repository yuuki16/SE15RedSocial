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

        public DataTable ObtenerSolicitudesPendientes(Solicitud solicitud)
        {

            sql = "SP_ObtenerSolicitudesPendientes";
            DataTable dt = new DataTable();

            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_sl_receptor", solicitud.Receptor);
                    comando.Parameters.AddWithValue("@p_sl_estado", solicitud.Estado);
                    comando.Connection = conn.conn;
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(dt);
                    conn.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la consulta.", ex);
            }
            conn.cerrarConexion();
            return dt;
        }

        public Boolean AgregarSolicitud(Solicitud solicitud)
        {
            sql = "SP_AgregarSolicitud";
            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.Parameters.AddWithValue("@p_sl_emisor", solicitud.Emisor);
                    comando.Parameters.AddWithValue("@p_sl_receptor", solicitud.Receptor);
                    comando.Parameters.AddWithValue("@p_sl_estado", solicitud.Estado);
                    comando.Parameters.AddWithValue("@p_sl_estampa", solicitud.Estampa);
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

        public Boolean AceptarSolicitud(Solicitud solicitud)
        {
            sql = "SP_AceptarSolicitud";
            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.Parameters.AddWithValue("@p_sl_emisor", solicitud.Emisor);
                    comando.Parameters.AddWithValue("@p_sl_receptor", solicitud.Receptor);
                    comando.Parameters.AddWithValue("@p_sl_estado", solicitud.Estado);
                    comando.Parameters.AddWithValue("@p_sl_estampa", solicitud.Estampa);
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

        public Boolean ModificarSolicitud(Solicitud solicitud)
        {
            sql = "SP_ModificarSolicitud";
            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.Parameters.AddWithValue("@p_sl_id", solicitud.Id);
                    comando.Parameters.AddWithValue("@p_sl_estado", solicitud.Estado);
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


        public Boolean EliminarSolicitud(Solicitud solicitud)
        {
            sql = "SP_EliminarSolicitud";
            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.Parameters.AddWithValue("@p_sl_emisor", solicitud.Emisor);
                    comando.Parameters.AddWithValue("@p_sl_receptor", solicitud.Receptor);
                    comando.Parameters.AddWithValue("@p_sl_estado", solicitud.Estado);
                    comando.Parameters.AddWithValue("@p_sl_estampa", solicitud.Estampa);
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
