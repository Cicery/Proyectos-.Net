<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Inicio/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmAgregarEmpleado.aspx.cs" Inherits="AppSoporteTecnico.Vista.Administrador.formAgregarEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Recursos/bootstrap/css/bootstrap.css" rel="stylesheet" />
    <script src="../../Recursos/bootstrap/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">
    <div class="row justify-content-center">
     <div class="col-6">
         
    <div class="form-group2" id="form1" runat="server">
        <h2>Agrega el Empleado</h2>
        <hr />
        Identificacion:
        <asp:TextBox ID="txtIdentificacion" runat="server" placeholder="Identificación" Class="form-control"></asp:TextBox>
        Nombres:
        <asp:TextBox ID="txtNombres" runat="server" Class="form-control"></asp:TextBox>
        Apellidos:
        <asp:TextBox ID="txtApellidos" runat="server" Class="form-control" ></asp:TextBox>
        Correo:
        <asp:TextBox ID="txtCorreo" runat="server" Class="form-control"></asp:TextBox>
        Cargo:
        <asp:DropDownList ID="cbCargo" runat="server"  Class="form-control">
            <asp:ListItem>Gerente</asp:ListItem>
            <asp:ListItem>Tesorero</asp:ListItem>
            <asp:ListItem>Secretaria</asp:ListItem>
            <asp:ListItem>Ingeniero de Sistemas</asp:ListItem>
            <asp:ListItem Value="Tecnico en Sistemas ">Técnico en Sistemas </asp:ListItem>
            <asp:ListItem>Secretaria</asp:ListItem>
            <asp:ListItem>Archivista</asp:ListItem>
        </asp:DropDownList>
        Dependencia:
        <asp:DropDownList ID="cbDependencia" runat="server" Class="form-control">
        </asp:DropDownList>
        Rol:
        <asp:DropDownList ID="cbRol" runat="server" Class="form-control">
            <asp:ListItem>Administrador</asp:ListItem>
            <asp:ListItem>Funcionario</asp:ListItem>
            <asp:ListItem>Soporte</asp:ListItem>
        </asp:DropDownList>
       
        <br />
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" Class="btn btn-primary col" OnClick="btnAgregar_Click" />
          <div class="container mt-4">
         <asp:Label ID="lblMensaje" runat="server"  BorderColor="#0066FF" Font-Bold="True"></asp:Label>
              </div>
    </div>
         </div>
     </div>
</asp:Content>
