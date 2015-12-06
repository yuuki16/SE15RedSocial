using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
    }
}