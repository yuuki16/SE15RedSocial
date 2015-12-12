using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BL;
using System.Data;

namespace SE15RedSocial
{
    public partial class Solicitudes : System.Web.UI.Page
    {

        private Usuario usuario = new Usuario();
        private Solicitud solicitud = new Solicitud();
        private BL_Usuario bl_usuario = new BL_Usuario();
        private BL_Solicitud bl_solicitud = new BL_Solicitud();
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private DataTable dtUs = new DataTable();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {

                //Session["usuario_logueado"] = null;
                usuario = (Usuario)(Session["usuario_logueado"]);
                ((MPRedSocial)this.Master).LnkPerfil = usuario.Correo;
                
                CargarDatos();
            
            }
            
        }

        private void CargarDatos()
        {
            try
            {
                solicitud.Receptor = usuario.Id;
                solicitud.Estado = "Pendiente";
                dt = bl_solicitud.ObtenerSolicitudesPendientes(solicitud);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtRow in dt.Rows)
                    {
                        usuario.Id = (int) dtRow["sl_emisor"];
                        solicitud.Emisor = (int) dtRow["sl_emisor"];
                    }
                    dtUs = bl_usuario.ObtenerDatosUsuario(usuario);
                    dt.Merge(dtUs, true);
                    dt.AcceptChanges();
                    grdSolicitudes.DataSource = dt;
                    grdSolicitudes.DataBind();

                    Session["Datos"] = dt;

                    Session["usuario"] = usuario;

                    Session["solicitud"] = solicitud;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        
        protected void grdBusqueda_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            //rechazar solicitud
            solicitud.Estampa = DateTime.Now;
            if (bl_solicitud.EliminarSolicitud(solicitud))
            {
                //La solicitud se rechazo
           }
            else
            {
                //Error
            }
        }

        protected void grdSolicitudes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            //aceptar solicitud

            usuario = (Usuario) Session["usuario"];
            solicitud = (Solicitud)Session["solicitud"];

            Session["solicitud"] = solicitud;

            solicitud.Estampa = DateTime.Now;
            if (bl_solicitud.AceptarSolicitud(solicitud))
            {
                //La solicitud se aceptó
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                //Error
            }
        }
    }
}