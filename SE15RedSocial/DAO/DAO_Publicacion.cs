using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    class DAO_Publicacion
    {

        Conexion conn = new Conexion();
        Boolean resultado;
        string sql;

        public Boolean AgregarPublicacion()
        {
            sql = "SP_AgregarPublicacion";
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

        public Boolean ModificarPublicacion()
        {
            sql = "SP_ModificarPublicacion";
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
