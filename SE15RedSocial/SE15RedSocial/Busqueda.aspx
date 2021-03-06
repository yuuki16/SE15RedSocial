﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MPRedSocial.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="SE15RedSocial.Busqueda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:GridView ID="grdBusqueda" runat="server" AutoGenerateColumns="False" CellPadding="4"
        ForeColor="#333333" GridLines="None" Width="722px" OnRowDeleting="grdBusqueda_RowDeleting" DataKeyNames="us_id">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="us_nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="us_apellidoPaterno" HeaderText="" />
            <asp:BoundField DataField="us_apellidoMaterno" HeaderText="" />
            <asp:TemplateField HeaderText=" ">
                <ItemTemplate>
                    <asp:ImageButton ID="imbPerfil" runat="server" CommandName="Delete" ImageUrl="~/imgs/profile.ico"
                        ToolTip="Ver Perfil" Height="50" Width="50" />
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