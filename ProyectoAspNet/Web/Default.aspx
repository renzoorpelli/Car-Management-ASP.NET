<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<asp:GridView ID="dgvAutos" runat="server" CssClass="table table-dark"></asp:GridView>SIRVE PARA GENERAR LA LISTA DE MANERA AUTOIMATICA--%>
    <asp:GridView runat="server" ID="dgvAutos" CssClass="table table-dark" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Modelo" DataField="Modelo"/>
            <asp:BoundField HeaderText="Color" DataField="Color"/>
            <asp:CheckBoxField HeaderText="Usado" DataField="EsUsado"/>
            <asp:CheckBoxField HeaderText="Importado" DataField="Importado" />
        </Columns>
    </asp:GridView>
</asp:Content>
