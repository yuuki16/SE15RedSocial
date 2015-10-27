using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DAO_Usuario
    {
        Conexion conn = new Conexion();
        Boolean resultado;
        string sql;
        public Boolean ObtenerUsuario()
        {
            sql = "SP_ObtenerUsuario";
            if (conn.abrirConexion() == true) { 
                
            }
            return resultado;
        }
        
        public Boolean AgregarUsuario() {
           
            sql = "SP_AgregarUsuario";

            try
            {
                if (conn.abrirConexion() == true) {
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

            return resultado;
        }

        public Boolean ModificarUsuario()
        {

            sql = "SP_ModificarUsuario";

            return resultado;
        }

        public Boolean LoginUsuario()
        {

            sql = "SP_LoginUsuario";
            Boolean resultado = true;



            return resultado;
        }


    }
}
