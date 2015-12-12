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
    public partial class Busqueda : System.Web.UI.Page
    {
        private Usuario usuario = new Usuario();
        private BL_Usuario bl_usuario = new BL_Usuario();
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Session["usuario_perfil"] = null;
                if (Session["correoparabuscar"] == null)
                {
                    usuario.Nombre = (string)Session["nombreparabuscar"];
                }
                else
                {
                    usuario.Correo = (string)Session["correoparabuscar"];
                }
                usuario = (Usuario)(Session["usuario_logueado"]);
                ((MPRedSocial)this.Master).LnkPerfil = usuario.Correo;
                CargarDatos();
            }
            
        }

        private void CargarDatos()
        {
            ds = null;
            ds = bl_usuario.ObtenerUsuario(usuario);
            if (ds.Tables.Count > 0)
            {
                grdBusqueda.DataSource = ds;
                grdBusqueda.DataBind();
                Session["Datos"] = ds;
            }
            else
            {
                throw new Exception("El ds esta vacio");
            }
        }

        protected void grdBusqueda_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = grdBusqueda.DataKeys[e.RowIndex].Values["us_id"].ToString();
            Session["idperfil"] = id;
            usuario.Id = int.Parse(id);
            ObtenerDatosUsuario();
            Response.Redirect("Perfil.aspx", false);
            
        }

        private void ObtenerDatosUsuario()
        {

            dt = bl_usuario.ObtenerDatosUsuario(usuario);

            foreach (DataRow dtRow in dt.Rows)
            {
                usuario.Id = (int)dtRow["us_id"];
                usuario.Correo = dtRow["us_correo"].ToString();
                usuario.Nombre = dtRow["us_nombre"].ToString();
                usuario.ApellidoPaterno = dtRow["us_apellidoPaterno"].ToString();
                usuario.ApellidoMaterno = dtRow["us_apellidoMaterno"].ToString();
                usuario.Alias = dtRow["us_alias"].ToString();
                usuario.Contrasena = dtRow["us_contrasena"].ToString();
                usuario.Estado = char.Parse(dtRow["us_estado"].ToString());
                usuario.Estampa = dtRow["us_estampa"].ToString();
            }

            Session["usuario_perfil"] = usuario;

        }

    }
}