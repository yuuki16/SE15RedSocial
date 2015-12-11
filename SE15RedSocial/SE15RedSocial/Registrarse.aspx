<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="SE15RedSocial.Registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="content/css/bootstrap.css" type="text/css">
    <style type="text/css">
        .auto-style1 {
            width: 611px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="page-header">
            <h1>Red Social&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnIniciar" class="btn btn-group" runat="server" Text="Iniciar Sesión" OnClick="btnIniciar_Click"/>
            </h1>
            
        </div>
        <br />
        <br />
        <asp:Label ID="lblRegistrese" runat="server" Text="Registrese" class="label label-primary"></asp:Label>
        <br />
        <br />
        <%--<asp:Label ID="lblTextoBienvenida" runat="server" Text="Únete a Nuestra Red Social :)"></asp:Label><br />
        --%>
        <table>
            <tr>
                <td>
                    Correo:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtCorreo" class="form-control" runat="server" Width="260px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Nombre:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtNombre" class="form-control" runat="server" Width="258px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Apellidos:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtApellido" class="form-control" runat="server" Width="258px"></asp:TextBox>
                    <asp:TextBox ID="txtSegundoApellido" runat="server" class="form-control" Width="256px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Alias:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtAlias" class="form-control" runat="server" Width="258px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Contraseña:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtContrasena" class="form-control" runat="server" Width="258px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Pais:
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtPais" class="form-control" runat="server" Width="256px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnAgregar" runat="server" class="btn btn-default" Text="Abrir una cuenta" OnClick="btnAgregar_Click" />
    
    </div>
    </form>
</body>
</html>