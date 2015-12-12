using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using Entidades;

namespace BL
{
    public class BL_Mensaje
    {
        private DAO_Mensaje dao_mensaje = new DAO_Mensaje();
        private DataTable dt = new DataTable();
        private Boolean resultado = false;
        public DataTable ObtenerTodosMensajes(Mensaje mensaje)
        {
            try
            {
                dt = dao_mensaje.ObtenerTodosMensajes(mensaje);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }

        public Boolean AgregarMensaje(Mensaje mensaje)
        {
            try
            {
                resultado = dao_mensaje.AgregarMensaje(mensaje);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            return resultado;
        }
    }
}
