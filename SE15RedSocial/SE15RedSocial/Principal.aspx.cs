using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using Entidades;

namespace SE15RedSocial

{
    public partial class Principal : System.Web.UI.Page
    {
        private BL_Usuario blUsuario = new BL_Usuario();
        private BL_Solicitud blSolicitud = new BL_Solicitud();
        private Solicitud solicitud = new Solicitud();
        private Usuario usuario = new Usuario();
        private Boolean resultado = false;
        private string usuario_correo;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario_correo = (string) (Session["correo"]);
            ((MPRedSocial)this.Master).LnkPerfil = usuario_correo;


            ObtenerSolicitudes();
        }

        private Boolean ObtenerSolicitudes()
        {

            int idUsuario;

            try
            {
                usuario.Correo = usuario_correo;
                idUsuario = blUsuario.ObtenerIDUsuarrio(usuario);
                solicitud.Receptor = idUsuario;
                resultado = blSolicitud.ObtenerIDUsuarrio(solicitud);

                if (resultado == true)
                {
                    ((MPRedSocial)Master).LnkSolicitud = Color.Crimson;
                }

            }
            catch (Exception)
            {
                
                throw;
            }
            return resultado;
        }

        private Boolean ObtenerMensajes()
        {

            return resultado;
        }

    }
}