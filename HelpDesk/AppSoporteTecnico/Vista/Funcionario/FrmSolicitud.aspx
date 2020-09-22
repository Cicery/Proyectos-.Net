<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Inicio/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="FrmSolicitud.aspx.cs" Inherits="AppSoporteTecnico.Vista.Funcionario.FrmSolicitud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Recursos/bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="../../Recursos/bootstrap/css/style.css" rel="stylesheet" />
    <script src="../../Recursos/jquery/external/jquery/jquery.js"></script>
    <script src="../../Recursos/jquery/jquery-ui.min.js"></script>
    <script src="../../Recursos/bootstrap/js/bootstrap.min.js"></script>
    <script src="../../Recursos/Funciones/Funciones.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">

    <div class="row justify-content-center">
        <div class="col-6">
            <div class="form-group2">
                <h2>Agregar Solicitud</h2>
                <hr />
                Serial del Equipo
                <asp:TextBox ID="txtSerial" runat="server" placeholder="serial del Equipo" class="form-control"></asp:TextBox>
                <asp:Label ID="lblMensajeSerial" runat="server"></asp:Label>
                <br />
                Observaciones:&nbsp;<asp:TextBox ID="txtObservaciones" runat="server" class="form-control" Rows="3" TextMode="MultiLine"></asp:TextBox>
           
                <br />
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" class="col btn btn-outline-primary" OnClick="btnAgregar_Click" />
                     <asp:Label ID="lblMensaje" runat="server"  BorderColor="#0066FF" Font-Bold="True" CssClass="mt-3"></asp:Label>
                <div class="row justify-content-center">
                    <asp:GridView ID="tblSolicitud" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="mt-3 mb-2" Width="469px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </div>
                <asp:Button ID="btnRegistrar" runat="server" CssClass="col btn btn-outline-secondary" OnClick="btnRegistrar_Click" Text="Registar" Visible="False" />
            </div>
        </div>
    </div>
</asp:Content>
