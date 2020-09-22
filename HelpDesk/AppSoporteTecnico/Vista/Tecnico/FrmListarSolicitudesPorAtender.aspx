<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Inicio/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="FrmListarSolicitudesPorAtender.aspx.cs" Inherits="AppSoporteTecnico.Vista.Tecnico.FrmListarSolicitudesPorAtender" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../../Recursos/bootstrap/css/bootstrap.css" rel="stylesheet" />
    <script src="../../Recursos/jquery/external/jquery/jquery.js"></script>
    <script src="../../Recursos/jquery/jquery-ui.min.js"></script>
    <script src="../../Recursos/bootstrap/js/bootstrap.js"></script>
    <script src="../../Recursos/Funciones/Funciones.js"></script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">



    <div class="row justify-content-center mt-4">
        <table id="tblSolicitudes" style="width: 70%;" class="table table-hover">
            <thead class="bg-primary">

                <tr>
                    <th scope="col">Tiket</th>
                    <th scope="col">Funcionario</th>
                    <th scope="col">Dependencia</th>
                    <th scope="col">Fecha de solicitud</th>
                    <th scope="col">Estado</th>
                    <th scope="col">Acción</th>

                </tr>
            </thead>
            <tbody>
                <tr id="fila">
                    <td id="sTicket"></td>
                    <td id="sFuncionario"></td>
                    <td id="sDependencia"></td>
                    <td id="sFecha"></td>
                    <td id="sEstado"></td>
                    <td id="sFoto"></td>

                </tr>
            </tbody>
        </table>
    </div>

    <div class="row justify-content-center mt-3">
        <asp:Label ID="lblMensaje" runat="server" BorderColor="#0066FF" Font-Bold="True"></asp:Label>
    </div>

    <div class="row justify-content-center mt-4">
        <asp:ImageButton ID="butonExportarPdf" runat="server" ImageUrl="~/Recursos/img/icons8-pdf-2-40.png" OnClick="butonExportarPdf_Click" />

    </div>


</asp:Content>
