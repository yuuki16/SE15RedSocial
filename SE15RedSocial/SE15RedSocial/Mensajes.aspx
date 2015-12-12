<%@ Page Title="" Language="C#" MasterPageFile="~/MPRedSocial.Master" AutoEventWireup="true" CodeBehind="Mensajes.aspx.cs" Inherits="SE15RedSocial.Mensajes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div style="width: 400px; border: 1px solid black">
        <table>
            <tr>
                <td style="width: 280px;">
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
            <tr>
                <td valign="middle">
                    <asp:TextBox ID="txtMensaje" Style="width: 280px; height: 50px;" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" Style="width: 100px; height: 45px;" OnClick="btnEnviar_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="287px" />
                </td>
                
            </tr>
        </table>
    </div>
</asp:Content>