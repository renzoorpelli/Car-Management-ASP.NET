<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<asp:GridView ID="dgvAutos" runat="server" CssClass="table table-dark"></asp:GridView>SIRVE PARA GENERAR LA LISTA DE MANERA AUTOIMATICA--%>
    <div class="row">
        <div class="col">
            <asp:GridView runat="server" ID="dgvAutos" DataKeyNames="Id" CssClass="table table-dark" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvAutos_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField HeaderText="Modelo" DataField="Modelo" />
                    <asp:BoundField HeaderText="Color" DataField="Color" />
                    <asp:CheckBoxField HeaderText="Usado" DataField="EsUsado" />
                    <asp:CheckBoxField HeaderText="Importado" DataField="Importado" />
                    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Editar" ControlStyle-CssClass="btn btn-light"/>
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnAgregarPage" Text="Agregar Auto" runat="server" CssClass="btn btn-dark" OnClick="btnAgregarPage_Click" />
        </div>
    </div>
</asp:Content>
