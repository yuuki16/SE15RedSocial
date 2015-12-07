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
    public class DAO_Relacion
    {

        Conexion conn = new Conexion();
        Boolean resultado;
        string sql;
        private DataTable dt = new DataTable();

        public DataTable ObtenerRelacion(Relacion relacion)
        {
            sql = "SP_ObtenerRelacion";
            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.Parameters.AddWithValue("@p_rl_usuario1", relacion.Usuario1);
                    comando.Parameters.AddWithValue("@p_rl_usuario2", relacion.Usuario2);
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            conn.cerrarConexion();
            return dt;
        }

        public Boolean AgregarRelacion(Relacion relacion)
        {
            sql = "SP_AgregarRelacion";
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

        public Boolean ModificarRelacion(Relacion relacion)
        {
            sql = "SP_ModificarRelacion";
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

        

        public Boolean EliminarRelacion(Relacion relacion)
        {
            sql = "SP_EliminarRelacion";
            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_rl_usuario1", relacion.Usuario1);
                    comando.Parameters.AddWithValue("@p_rl_usuario2", relacion.Usuario2);
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
