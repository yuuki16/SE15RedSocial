using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Entidades;

namespace BL
{
    public class BL_Solicitud
    {

        private Boolean resultado = false;
        private DAO_Solicitud dao_solicitud = new DAO_Solicitud();

        public Boolean ObtenerIDUsuarrio(Solicitud solicitud)
        {
            
            try
            {
                resultado = dao_solicitud.ObtenerSolicitudesPendientes(solicitud);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return resultado;

        }

    }
}
