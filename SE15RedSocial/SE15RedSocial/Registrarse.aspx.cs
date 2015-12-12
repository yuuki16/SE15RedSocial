using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BL;

namespace SE15RedSocial
{
    public partial class Registrarse : System.Web.UI.Page
    {

    private Usuario usuario = new Usuario();
    private BL_Usuario bl_usuario = new BL_Usuario();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIniciar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx", false);
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        usuario.Correo = txtCorreo.Text;
        usuario.Nombre = txtNombre.Text;
        usuario.ApellidoMaterno = txtSegundoApellido.Text;
        usuario.ApellidoPaterno = txtApellido.Text;
        usuario.Alias = txtAlias.Text;
        usuario.Contrasena = txtContrasena.Text;
        usuario.Pais = txtPais.Text;
        usuario.Estado = 'Y';
        usuario.Estampa = DateTime.Now.ToString();

        if (bl_usuario.AgregarUsuario(usuario))
        {
           ShowPopUpMsg("Usuario agregado con éxito");
           Response.Redirect("Login.aspx");
        }
        else
        {
            ShowPopUpMsg("Error al ingresar usuario.");
        }

    }

        public void ShowPopUpMsg(string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("alert('");
            sb.Append(msg.Replace("\n", "\\n").Replace("\r", "").Replace("'", "\\'"));
            sb.Append("');");
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "showalert", sb.ToString(), true);
        }

    }
}