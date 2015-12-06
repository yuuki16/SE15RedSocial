﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        if (bl_usuario.AgregarUsuario(usuario))
        {

        }
        else {

        }

    }
   }
}