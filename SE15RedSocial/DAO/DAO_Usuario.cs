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
    public class DAO_Usuario
    {

        private Conexion conn = new Conexion();
        private Boolean resultado = false;
        string sql;
        private DataSet ds = new DataSet();

        public DataTable ObtenerUsuario(Usuario usuario) 
        {
            sql = "SP_ObtenerUsuario";
            DataTable dt = new DataTable();
            try
            {
                if (conn.abrirConexion() == true) {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.Parameters.Add("@p_us_id", SqlDbType.Int).Value = usuario.Id;
                    foreach (SqlParameter Parameter in comando.Parameters)
                    {
                        if (Parameter.Value == null)
                        {
                        Parameter.Value = DBNull.Value;
                        }
                    }
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(dt);
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            conn.cerrarConexion();
            return dt;
        }
        
        public Boolean AgregarUsuario(Usuario usuario)
        {
           
            sql = "SP_AgregarUsuario";

            try
            {
                if (conn.abrirConexion() == true) {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@p_us_correo", SqlDbType.VarChar).Value = usuario.Correo;
                    comando.Parameters.Add("@p_us_nombre", SqlDbType.VarChar).Value = usuario.Nombre;
                    comando.Parameters.Add("@p_us_apellidoPaterno", SqlDbType.VarChar).Value = usuario.ApellidoPaterno;
                    comando.Parameters.Add("@p_us_apellidoMaterno", SqlDbType.VarChar).Value = usuario.ApellidoMaterno;
                    comando.Parameters.Add("@p_us_alias", SqlDbType.VarChar).Value = usuario.Alias;
                    comando.Parameters.Add("@p_us_contrasena", SqlDbType.VarChar).Value = usuario.Contrasena;
                    comando.Parameters.Add("@p_us_pais", SqlDbType.VarChar).Value = usuario.Pais;
                    comando.Parameters.Add("@p_us_estado", SqlDbType.Char).Value = usuario.Estado;
                    //comando.Parameters.Add("@p_us_estampa", SqlDbType.Timestamp).Value = usuario.Estampa;
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

        public Boolean ModificarUsuario(Usuario usuario)
        {

            sql = "SP_ModificarUsuario";

            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@p_us_id", SqlDbType.Int).Value = usuario.Id;
                    comando.Parameters.Add("@p_us_correo", SqlDbType.VarChar).Value = usuario.Correo;
                    comando.Parameters.Add("@p_us_nombre", SqlDbType.VarChar).Value = usuario.Nombre;
                    comando.Parameters.Add("@p_us_apellidoPaterno", SqlDbType.VarChar).Value = usuario.ApellidoPaterno;
                    comando.Parameters.Add("@p_us_apellidoMaterno", SqlDbType.VarChar).Value = usuario.ApellidoMaterno;
                    comando.Parameters.Add("@p_us_alias", SqlDbType.VarChar).Value = usuario.Alias;
                    comando.Parameters.Add("@p_us_contrasena", SqlDbType.VarChar).Value = usuario.Contrasena;
                    comando.Parameters.Add("@p_us_pais", SqlDbType.VarChar).Value = usuario.Pais;
                    comando.Parameters.Add("@p_us_estado", SqlDbType.Char).Value = usuario.Estado;
                    comando.Parameters.Add("@p_us_estampa", SqlDbType.Timestamp).Value = usuario.Estampa;
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

        public Boolean InActivarUsuario(Usuario usuario)
        {
            sql = "SP_InActivarUsuario";
            try
            {
                if (conn.abrirConexion() == true) {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@p_us_id", SqlDbType.Int).Value = usuario.Id;
                    comando.Parameters.Add("@p_us_estado", SqlDbType.Char).Value = usuario.Estado;
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

        public int ObtenerIDUsuarrio(Usuario usuario)
        {

            sql = "SP_ObtenerIDUsuario";
            int number = 0;

            try
            {
                if (conn.abrirConexion() == true)
                {
                    string mensaje = "";
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_us_correo", usuario.Correo);
                    comando.Connection = conn.conn;
                    mensaje = comando.ExecuteScalar().ToString();
                    int.TryParse(mensaje, out number);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la consulta.", ex);
            }
            conn.cerrarConexion();
            return number;
        }

        public Boolean LoginUsuario(Usuario usuario)
        {

            sql = "SP_LoginUsuario";
            try
            {
                if (conn.abrirConexion() == true)
                {
                    SqlCommand comando = new SqlCommand(sql, conn.conn);
                    comando.CommandType = CommandType.StoredProcedure;

                    SqlParameter parametro = new SqlParameter("@p_us_correo", SqlDbType.VarChar);
                    parametro.Value = usuario.Correo;
                    comando.Parameters.Add(parametro);

                    parametro = new SqlParameter("@p_us_contrasena", SqlDbType.VarChar);
                    parametro.Value = usuario.Contrasena;
                    comando.Parameters.Add(parametro);

                    SqlDataReader rd = comando.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        resultado = true;
                    }
                    else {
                        resultado = false;
                    }
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
