<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SE15RedSocial.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
            <tr>
                <td>
                    <table style="width: 350px">
                        <tr>
                            <td>Correo:
                            </td>
                            <td><asp:TextBox runat="server" ID="TxtUserName"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Contraseña:
                            </td>
                            <td><asp:TextBox runat="server" ID="TxtPassword" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button runat="server" ID="BtnIngresar" Text="Ingresar" OnClick="BtnIngresar_Click"></asp:Button>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    <img src="Imgs/login.jpeg" style="height: 114px; width: 174px" />
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
</body>
</html>
