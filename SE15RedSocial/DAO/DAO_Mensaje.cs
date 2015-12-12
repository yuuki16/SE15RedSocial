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
    public class DAO_Mensaje
    {
        Conexion conn = new Conexion();
        Boolean resultado = false;
        string sql;
        DataTable dt;

        public DataTable ObtenerTodosMensajes(Mensaje mensaje)
        {

            sql = "SP_ObtenerTodosMensajes";
            DataTable dt = new DataTable();

            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_ms_receptor", mensaje.Receptor);
                    comando.Parameters.AddWithValue("@p_ms_emisor", mensaje.Emisor);
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

        public Boolean AgregarMensaje(Mensaje mensaje)
        {

            sql = "SP_AgregarMensaje";
            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.Parameters.AddWithValue("@p_ms_emisor", mensaje.Emisor);
                    comando.Parameters.AddWithValue("@p_ms_receptor", mensaje.Receptor);
                    comando.Parameters.AddWithValue("@p_ms_estampa", mensaje.Estampa);
                    comando.Parameters.AddWithValue("@p_ms_mensaje", mensaje.Msj);
                    comando.Parameters.AddWithValue("@p_ms_multimedia", mensaje.Multimedia);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.ExecuteNonQuery();
                    resultado = true;
                    conn.cerrarConexion();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            conn.cerrarConexion();
            return resultado;

        }
    }

}
