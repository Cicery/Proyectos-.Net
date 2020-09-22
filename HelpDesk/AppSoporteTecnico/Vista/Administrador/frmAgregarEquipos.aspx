<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Inicio/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmAgregarEquipos.aspx.cs" Inherits="AppSoporteTecnico.Vista.Administrador.frmAgregarEquipos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Recursos/bootstrap/css/bootstrap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">



    <div class="row justify-content-center">
        <div class="col-6">
           
            <div class="form-group2">
                 <h2 >Agregar Equipos </h2>
                <hr />

                Tipo de Equipos:                 
                        <asp:DropDownList ID="cbTipo" runat="server" class="form-control">
                            <asp:ListItem>Computador Escritorio</asp:ListItem>
                            <asp:ListItem>Portatil</asp:ListItem>
                            <asp:ListItem>Impresora</asp:ListItem>
                            <asp:ListItem>Monitor</asp:ListItem>
                            <asp:ListItem>Scanner</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                Marca:                   
                        <asp:DropDownList ID="cbMarca" runat="server" CssClass="form-control">
                            <asp:ListItem>Dell</asp:ListItem>
                            <asp:ListItem>HP</asp:ListItem>
                            <asp:ListItem>Lenovo</asp:ListItem>
                            <asp:ListItem>Asus</asp:ListItem>
                            <asp:ListItem>Acer</asp:ListItem>
                            <asp:ListItem>Epson</asp:ListItem>
                            <asp:ListItem>Canon</asp:ListItem>
                            <asp:ListItem>Samsung</asp:ListItem>
                            <asp:ListItem>Mac</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>

                Serial:                 
                        <asp:TextBox ID="txtSerial" runat="server" CssClass="form-control"></asp:TextBox>
                Dependencia:                    
                        <asp:DropDownList ID="cbDependencia" runat="server" CssClass="form-control">
                        </asp:DropDownList>

                <br />

                <asp:Button class="btn btn-outline-success" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click1" />
                <div class="container mt-4">
                    <asp:Label ID="lblMensaje" runat="server"  BorderColor="#0066FF" Font-Bold="True"></asp:Label>
                </div>
            </div>

        </div>
    </div>



</asp:Content>
