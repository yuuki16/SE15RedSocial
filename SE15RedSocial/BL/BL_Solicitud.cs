using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Entidades;
using System.Data;

namespace BL
{
    public class BL_Solicitud
    {

        private Boolean resultado = false;
        private DAO_Solicitud dao_solicitud = new DAO_Solicitud();
        private DataTable dt = new DataTable();
        public Boolean ObtenerIDUsuarrio(Solicitud solicitud)
        {
            
            try
            {
                resultado = dao_solicitud.ObtenerSolicitud(solicitud);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return resultado;

        }

        public DataTable ObtenerSolicitudesPendientes(Solicitud solicitud)
        {

            try
            {
                dt = dao_solicitud.ObtenerSolicitudesPendientes(solicitud);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;

        }

        public Boolean AgregarSolicitud(Solicitud solicitud)
        {

            try
            {
                resultado = dao_solicitud.AgregarSolicitud(solicitud);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return resultado;

        }

        public Boolean ModificarSolicitud(Solicitud solicitud)
        {

            try
            {
                resultado = dao_solicitud.ModificarSolicitud(solicitud);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return resultado;

        }

        public Boolean EliminarSolicitud(Solicitud solicitud)
        {

            try
            {
                resultado = dao_solicitud.EliminarSolicitud(solicitud);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return resultado;

        }

    }
}
