<%@ Page Title="" Language="C#" MasterPageFile="~/MPRedSocial.Master" AutoEventWireup="true" CodeBehind="Solicitudes.aspx.cs" Inherits="SE15RedSocial.Solicitudes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="grdSolicitudes" runat="server" AutoGenerateColumns="False" CellPadding="4"
        ForeColor="#333333" GridLines="None" Width="722px" OnRowDeleting="grdBusqueda_RowDeleting" DataKeyNames="sl_id" OnRowUpdating="grdSolicitudes_RowUpdating">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="us_nombre" HeaderText="Nombre" />
            
            <asp:TemplateField HeaderText="Aceptar">
                <ItemTemplate>
                    <asp:ImageButton ID="imbAceptar" runat="server" CommandName="Update" ImageUrl="~/imgs/check.ico"
                        ToolTip="Aceptar Usuario" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Rechazar">
                <ItemTemplate>
                    <asp:ImageButton ID="imbRechazar" runat="server" CommandName="Delete" ImageUrl="~/imgs/delete.ico"
                        ToolTip="Rechazar Usuario" />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>


