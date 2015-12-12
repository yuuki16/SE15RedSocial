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
    public partial class Mensajes : System.Web.UI.Page
    {
        private Usuario usuarioEmisor = new Usuario();
        private Usuario usuarioReceptor = new Usuario();
        private DataTable dt = new DataTable();
        private Entidades.Mensaje mensaje = new Entidades.Mensaje();
        private BL_Mensaje bl_mensaje = new BL_Mensaje();
        Label myLabel;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuarioEmisor = (Usuario)Session["usuario_logueado"];
            ((MPRedSocial)this.Master).LnkPerfil = usuarioEmisor.Correo;

            usuarioReceptor = (Usuario)Session["usuario_perfil"];
            ObtenerMensajes();
        }

        private void ObtenerMensajes()
        {
            mensaje.Emisor = usuarioEmisor.Id;
            mensaje.Receptor = usuarioReceptor.Id;
            dt = bl_mensaje.ObtenerTodosMensajes(mensaje);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dtRow in dt.Rows)
                {
                    myLabel = new Label();
                    mensaje.Msj = dtRow["ms_mensaje"].ToString();
                    mensaje.Emisor = (int)dtRow["ms_emisor"];
                    myLabel.Text = mensaje.Msj;
                    if (mensaje.Emisor == usuarioEmisor.Id)
                    {
                        myLabel.BackColor = System.Drawing.Color.White;
                    }
                    else {
                        myLabel.BackColor = System.Drawing.Color.PeachPuff;
                    }

                    PlaceHolder1.Controls.Add(myLabel);
                    // Add a spacer in the form of an HTML <br /> element.
                    PlaceHolder1.Controls.Add(new LiteralControl("<br />"));
                }
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            mensaje.Msj = txtMensaje.Text;
            mensaje.Emisor = usuarioEmisor.Id;
            mensaje.Receptor = usuarioReceptor.Id;
            mensaje.Estampa = DateTime.Now;
            mensaje.Multimedia = "T";
            if (bl_mensaje.AgregarMensaje(mensaje))
            {
                Response.Redirect(Request.RawUrl);
            }

        }
    }
}