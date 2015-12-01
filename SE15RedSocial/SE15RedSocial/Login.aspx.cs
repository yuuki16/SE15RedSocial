using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using Entidades;

namespace SE15RedSocial
{
    public partial class Login : System.Web.UI.Page
    {
        private BL_Usuario blUsuario = new BL_Usuario();
        private Usuario usuario = new Usuario();
        private Boolean resultado = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.Correo = TxtUserName.Text;
                usuario.Contrasena = TxtPassword.Text;
                resultado = blUsuario.LoginUsuario(usuario);
                if (resultado == true)
                {
                    LblMensaje.Text = "Autorización exitosa.";
                    //Response.Redirect("");
                }
                else {
                    LblMensaje.Text = "Usuario o Contraseña incorrectos.";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}