using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using Entidades;

namespace BL
{
    public class BL_Relacion
    {

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private Boolean resultado = false;
        private DAO_Relacion dao_relacion = new DAO_Relacion();

        public DataTable ObtenerUsuario(Relacion relacion)
        {

            try
            {
                dt = dao_relacion.ObtenerRelacion(relacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;

        }

        public Boolean EliminarRelacion(Relacion relacion)
        {

            try
            {
                resultado = dao_relacion.EliminarRelacion(relacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return resultado;

        }

    }
}
