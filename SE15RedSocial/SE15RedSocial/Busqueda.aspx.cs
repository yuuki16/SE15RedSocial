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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["correoparabuscar"] == null)
            {
                usuario.Nombre = (string)Session["nombreparabuscar"];
            }
            else {
                usuario.Correo = (string)Session["correoparabuscar"];
            }
            CargarDatos();
        }

        private void CargarDatos()
        {
            ds = null;
            ds = bl_usuario.ObtenerUsuario(usuario);
            if (ds.Tables.Count > 0)
            {
                //grdBusqueda.Visible = true;
                grdBusqueda.DataSource = ds;
                grdBusqueda.DataBind();
                Session["Datos"] = ds;

                //foreach (DataTable data in ds.Tables)
                //{
                //    data.
                //}
            }
            else
            {
                throw new Exception("El ds esta vacio");
            }
        }

    }
}