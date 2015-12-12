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
        Image myImage;
        protected void Page_Load(object sender, EventArgs e)
        {
            usuarioEmisor = (Usuario)Session["usuario_logueado"];
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
                    mensaje.Msj = dtRow["ms_mensaje"].ToString();
                    mensaje.Emisor = (int)dtRow["ms_emisor"];
                    mensaje.Multimedia = dtRow["ms_multimedia"].ToString();
                    if (mensaje.Multimedia == "")
                    {
                        myLabel = new Label();
                        if (mensaje.Emisor == usuarioEmisor.Id)
                        {
                            myLabel.BackColor = System.Drawing.Color.White;
                        }
                        else {
                            myLabel.BackColor = System.Drawing.Color.PeachPuff;
                        }
                        myLabel.Text = mensaje.Msj;
                        PlaceHolder1.Controls.Add(myLabel);
                    }
                    else {
                        myImage = new Image();
                        myImage.ImageUrl = "~/Multimedia/" + mensaje.Multimedia;
                        myImage.Width = 100;
                        myImage.Height = 100;
                        PlaceHolder1.Controls.Add(myImage);
                    }
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
            if (FileUpload1.HasFile)
            {
                string strname = FileUpload1.FileName.ToString();
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Multimedia/") + strname);
                mensaje.Multimedia = strname;
            }
            else {
                mensaje.Multimedia = "";
            }
            if (bl_mensaje.AgregarMensaje(mensaje))
            {
                Response.Redirect(Request.RawUrl);
            }

        }
    }
}