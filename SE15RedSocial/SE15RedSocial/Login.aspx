<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SE15RedSocial.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="content/css/bootstrap.css" type="text/css">
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
            <tr>
                <td>
                    <table style="width: 350px">
                        <tr>
                            <td><asp:Label ID="lblCorreo" runat="server" Text="Correo" class="label label-default"></asp:Label>
                            </td>
                            <td><asp:TextBox runat="server" ID="TxtUserName"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="lblContrasena" runat="server" Text="Contraseña" class="label label-default"></asp:Label>
                            </td>
                            <td><asp:TextBox runat="server" ID="TxtPassword" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button runat="server" class="btn btn-default" ID="BtnIngresar" Text="Ingresar" OnClick="BtnIngresar_Click"></asp:Button>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    <img src="imgs/login.ico" style="height: 114px; width: 174px" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                <asp:Label Visible="false" runat="server" ID="LblMensaje" Font-Bold="True" Font-Size="15pt"
                ForeColor="Red">Usuario o contraseña inválidos</asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
     <script src="Scripts/jquery-2.1.4.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
