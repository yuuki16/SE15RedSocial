using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE15RedSocial
{
    public partial class MPRedSocial : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string LnkPerfil
        {
            set { lnkPerfil.Text = value; }
        }

        public Color LnkSolicitud
        {
            set { lnkSolicitudes.BackColor = value; }
        }

        protected void lnkPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("Perfil.aspx");
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            Session["correoparabuscar"] = null;
            Session["nombreparabuscar"] = null;
            if (txtBuscar.Text == string.Empty)
            {
                ShowPopUpMsg("Ingrese algo");
            }
            else if (txtBuscar.Text.Contains("@"))
            {
                Session["correoparabuscar"] = txtBuscar.Text;
                Response.Redirect("Busqueda.aspx", false);
            }
            else {
                Session["nombreparabuscar"] = txtBuscar.Text;
                Response.Redirect("Busqueda.aspx", false);
            }
        }

        private void ShowPopUpMsg(string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("alert('");
            sb.Append(msg.Replace("\n", "\\n").Replace("\r", "").Replace("'", "\\'"));
            sb.Append("');");
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "showalert", sb.ToString(), true);
        }
    }
}