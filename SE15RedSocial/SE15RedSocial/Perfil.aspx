﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="SE15RedSocial.Perfil" MasterPageFile="~/MPRedSocial.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <br />
<br />

<br />
    
<asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
    <br />
<asp:Image ID="imgPerfil" runat="server" Height="191px" Width="174px" ImageUrl="~/imgs/usuario.png"/>
<asp:Button ID="btnAgregarEliminar" runat="server" Text="Agregar/Eliminar" OnClick="btnAgregarEliminar_Click" />
<asp:Button ID="btnMensaje" runat="server" Text="Enviar Mensaje" OnClick="btnMensaje_Click" />
</asp:Content>