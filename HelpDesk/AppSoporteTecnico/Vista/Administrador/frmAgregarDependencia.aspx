<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Inicio/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmAgregarDependencia.aspx.cs" Inherits="AppSoporteTecnico.Vista.Administrador.frmAgregarDependencia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Recursos/bootstrap/css/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">

    <div class="row justify-content-center">
        <div class="col-6">

            <div class="form-group2">
                <h2>Agregar Dependencia </h2>
                <hr />
                Nueva Dependencia:                 
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="nombre Dependencia"></asp:TextBox>


                <br />

                <asp:Button class="btn btn-outline-success" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click1" />
                <br />
                <div class="container mt-4">
                    <asp:Label ID="lblMensaje" runat="server" BorderColor="#0066FF" Font-Bold="True"></asp:Label>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
