using System;
using System.Collections.Generic;
using System.Data;
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
        private DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario) (Session["usuario_logueado"]);
            ((MPRedSocial)this.Master).LnkPerfil = usuario.Correo;
            
            ObtenerSolicitudes();
            ObtenerDatos();
        }

        private Boolean ObtenerSolicitudes()
        {

            try
            {
                
                solicitud.Receptor = usuario.Id;
                solicitud.Estado = "Pendiente";
                dt = blSolicitud.ObtenerSolicitudesPendientes(solicitud);

                if (dt.Rows.Count > 0)
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

        private void ObtenerDatos()
        {


           usuario.Id = blUsuario.ObtenerIDUsuarrio(usuario);
           dt = blUsuario.ObtenerDatosUsuario(usuario);
            
            foreach (DataRow dtRow in dt.Rows)
            {

                char myChar = ' ';
                string myString = new string(myChar, 0);
                
                usuario.Id = (int) dtRow["us_id"];
                usuario.Correo = dtRow["us_correo"].ToString();
                usuario.Nombre = dtRow["us_nombre"].ToString();
                usuario.ApellidoPaterno = dtRow["us_apellidoPaterno"].ToString();
                usuario.ApellidoMaterno = dtRow["us_apellidoMaterno"].ToString();
                usuario.Alias = dtRow["us_alias"].ToString();
                usuario.Contrasena = dtRow["us_contrasena"].ToString();
                myString = dtRow["us_estado"].ToString();
                usuario.Estampa = dtRow["us_estampa"].ToString();

                myChar = myString[0];
                usuario.Estado = myChar;

            }
            
            Session["usuario_logueado"] = usuario;
            
        }
            }
}