using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
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

            //try
            //{
                
            //}
            //catch (Exception exAdd)
            //{ 
            //    throw new Exception("Error", exAdd);
            //}

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
                    LblMensaje.Visible = true;
                    Response.Redirect("MPRedSocial.Master");
                }
                else
                {
                    LblMensaje.Text = "Usuario o Contraseña incorrectos.";
                    LblMensaje.Visible = true;
                }
            }
            catch (Exception exLogin)
            {
                throw new Exception(exLogin.Message);
            }

            //--------------------------------------------
            //Agregar

            //try
            //{
                
            //    usuario.Correo = "bgonzalez@correo.com";
            //    usuario.Nombre = "Braulio";
            //    usuario.ApellidoPaterno = "Gonzalez";
            //    usuario.ApellidoMaterno = "Mora";
            //    usuario.Alias = "Brulio";
            //    usuario.Contrasena = "123456";
            //    usuario.Pais = "Costa Rica";
            //    usuario.Estado = 'Y';
            //    usuario.Estampa = "0x00000000000007D1";
            //    resultado = blUsuario.AgregarUsuario(usuario);

            //    if (resultado == true)
            //    {
            //        LblMensaje.Text = "Usuario agregado exitosamente.";
            //        LblMensaje.Visible = true;
            //        //Response.Redirect("");
            //    }
            //    else
            //    {
            //        LblMensaje.Text = "Usuario no ingresado.";
            //        LblMensaje.Visible = true;
            //    }
            //}
            //catch (Exception exLogin)
            //{
            //    throw new Exception("Error", exLogin);
            //}

            //--------------------------------------------





        }
    }
}