using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entidades;
using BL;


namespace SE15RedSocial
{
	public partial class Perfil : System.Web.UI.Page
	{
        //private Usuario usuario = new Usuario();

        private BL_Usuario blUsuario = new BL_Usuario();
        private BL_Relacion blRelacion = new BL_Relacion();
        private BL_Solicitud blSolicitud = new BL_Solicitud();
        private Usuario usuario1 = new Usuario();
        private Usuario usuario2 = new Usuario();
        private Relacion relacion = new Relacion();
        private Solicitud solicitud = new Solicitud();
        private Boolean resultado = false;
        private int usuario_id;
        private DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
		{

            usuario1 = (Usuario)(Session["usuario_logueado"]);
            usuario2 = (Usuario)(Session["usuario_perfil"]);
            lblNombre.Text = usuario2.Nombre + ' ' + usuario2.ApellidoPaterno + ' ' + usuario2.ApellidoMaterno;
            
            ObtenerRelacion();

		}

	    private void ObtenerRelacion()
	    {
            if (usuario1.Id == usuario2.Id)
            {
                btnAgregarEliminar.Visible = false;
                btnMensaje.Visible = false;
            }
            else {
                btnAgregarEliminar.Visible = true;
                btnMensaje.Visible = true;
                relacion.Usuario1 = usuario1.Id;
                relacion.Usuario2 = usuario2.Id;
                dt = blRelacion.ObtenerUsuario(relacion);

                if (dt.Rows.Count == 0)
                {
                    btnAgregarEliminar.Text = "Agregar";
                }
                else
                {

                    btnAgregarEliminar.Text = "Eliminar";
                }
            }
        }

        private void ConsultarSolicitudPendiente()
        {
            solicitud.Emisor = usuario1.Id;
            solicitud.Receptor = usuario2.Id;
            dt = blSolicitud.ObtenerSolicitudesPendientes(solicitud);
            if (dt.Rows.Count > 0)
            {
                btnAgregarEliminar.Text = "Solicitud Pendiente";
                btnAgregarEliminar.Enabled = false;
            }
            else {
                solicitud.Emisor = usuario2.Id;
                solicitud.Receptor = usuario1.Id;
                dt = blSolicitud.ObtenerSolicitudesPendientes(solicitud);
                if (dt.Rows.Count > 0)
                {
                    btnAgregarEliminar.Text = "Solicitud Pendiente";
                    btnAgregarEliminar.Enabled = false;
                }
                else {

                }
            }
        }

        protected void btnAgregarEliminar_Click(object sender, EventArgs e)
        {

            try
            {

                if (btnAgregarEliminar.Text == "Agregar")
                {
                    solicitud.Emisor = usuario1.Id;
                    solicitud.Receptor = usuario2.Id;
                    solicitud.Estado = "Pendiente";
                    solicitud.Estampa = DateTime.Today;
                    resultado = blSolicitud.AgregarSolicitud(solicitud);

                    if (resultado == true)
                    {
                        btnAgregarEliminar.Text = "Solicitud Enviada";
                        btnAgregarEliminar.Enabled = false;
                    }
                    else
                    {
                        //Mostrar Error
                    }
                    

                }
                else if (btnAgregarEliminar.Text == "Eliminar")
                {

                    relacion.Usuario1 = usuario1.Id;
                    relacion.Usuario2 = usuario2.Id;
                    resultado = blRelacion.EliminarRelacion(relacion);

                    if (resultado == true)
                    {
                        btnAgregarEliminar.Text = "Agregar";
                        btnAgregarEliminar.Enabled = false;
                    }
                    else
                    {
                        //Mostrar Error
                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar", ex);
            }
            
        }
    }
}