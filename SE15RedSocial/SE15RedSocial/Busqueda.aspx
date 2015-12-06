<%@ Page Title="" Language="C#" MasterPageFile="~/MPRedSocial.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="SE15RedSocial.Busqueda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:GridView ID="grdBusqueda" runat="server" AutoGenerateColumns="False" CellPadding="4"
        ForeColor="#333333" GridLines="None" Width="722px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="us_nombre" HeaderText="Nombre" />
            <asp:TemplateField HeaderText=" ">
                <ItemTemplate>
                    <asp:ImageButton ID="imbPerfil" runat="server" CommandName="Insert" ImageUrl="~/images/edit.png"
                        ToolTip="Ver Perfil" />
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
<%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RedSocialConnectionString %>" SelectCommand="SP_ObtenerUsuario" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:SessionParameter DefaultValue="null" Name="p_us_correo" SessionField="correoparabuscar" Type="String" />
        <asp:SessionParameter DefaultValue="null" Name="p_us_nombre" SessionField="nombreparabuscar" Type="String" />
    </SelectParameters>
</asp:SqlDataSource>--%>
</asp:Content>