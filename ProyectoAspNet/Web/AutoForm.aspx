<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AutoForm.aspx.cs" Inherits="Web.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row justify-content-center">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id: </label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" placeholder="Ingrese el id"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtModelo" class="form-label">Modelo: </label>
                <asp:TextBox runat="server" ID="txtModelo" CssClass="form-control" placeholder="Ingrese el modelo"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion: </label>
                <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" CssClass="form-control" placeholder="Ingrese la Descripcion"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="ddlColor" class="form-label">Color: </label>
                <asp:DropDownList ID="ddlColor" runat="server" CssClass="form-select"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="txtFecha" class="form-label">Fecha: </label>
                <asp:TextBox runat="server" ID="txtFecha" TextMode="Date" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="chbUsado" class="form-label">Usado: </label>
                <asp:CheckBox ID="chbUsado" runat="server" CssClass="form-check-input" />
            </div>
            <div class="mb-3">
                <label for="rdbUsado" class="form-label">Origen: </label>
                <asp:RadioButton ID="rdbImportado" runat="server" Text="Importado" CssClass="form-check-input" GroupName="Importado" />
                <asp:RadioButton ID="rdbNacional" runat="server" Text="Nacional" CssClass="form-check-input" GroupName="Importado" Checked="true" />
            </div>
            <div class="mb-3">
                <asp:Button Text="Agregar" runat="server" ID="btnAceptar" OnClick="btnAceptar_Click" CssClass="btn btn-success"/>
                <asp:Button Text="Cancelar" runat="server" ID="btnCancelar" OnClick="btnCancelar_Click" CssClass="btn btn-dark"/>
                <asp:Button Text="Modificar" runat="server" ID="btnModificar" OnClick="btnModificar_Click" CssClass="btn btn-warning" Visible="false"/>
                <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" OnClick="btnEliminar_Click" CssClass="btn btn-danger" Visible="false"/>

            </div>
        </div>
    </div>
</asp:Content>
