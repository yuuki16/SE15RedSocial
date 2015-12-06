<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="SE15RedSocial.Registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 611px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Red Social
        <asp:Button ID="btnIniciar" runat="server" Text="Iniciar Sesión" align="right" OnClick="btnIniciar_Click"/>
        <br />
        <br />
        Regístrese<br />
        <br />
        <%--<asp:Label ID="lblTextoBienvenida" runat="server" Text="Únete a Nuestra Red Social :)"></asp:Label><br />
        --%>
        <table>
            <tr>
                <td>
                    Correo:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtCorreo" runat="server" Width="260px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Nombre:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtNombre" runat="server" Width="258px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Apellidos:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtApellido" runat="server" Width="258px"></asp:TextBox>
                    <asp:TextBox ID="txtSegundoApellido" runat="server" Width="256px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Alias:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtAlias" runat="server" Width="258px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Contraseña:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtContrasena" runat="server" Width="258px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Pais:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtPais" runat="server" Width="256px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnAgregar" runat="server" Text="Abrir una cuenta" OnClick="btnAgregar_Click" />
    
    </div>
    </form>
</body>
</html>