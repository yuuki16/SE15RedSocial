using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class Conexion
    {

        public SqlConnection conn = new SqlConnection();
        Boolean resultado = false;

        public Boolean abrirConexion()
        {

            try
            {
                conn.ConnectionString = DAO.Properties.Settings.Default.connectionString;
                conn.Open();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Boolean cerrarConexion()
        {

            try
            {
                if (conn.State == ConnectionState.Open)
	            {
		            conn.Close();
                    resultado = true;
                    return resultado;
	            }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

    }
}
