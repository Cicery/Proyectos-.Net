<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Inicio/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmDetalleSolicitud.aspx.cs" Inherits="AppSoporteTecnico.Vista.Tecnico.frmDetalleSolicitud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Recursos/bootstrap/css/bootstrap.css" rel="stylesheet" />
    <script src="../../Recursos/jquery/external/jquery/jquery.js"></script>
    <script src="../../Recursos/jquery/jquery-ui.min.js"></script>
    <script src="../../Recursos/bootstrap/js/bootstrap.js"></script>
    <script src="../../Recursos/Funciones/Funciones.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">
    <br />
    <asp:HiddenField ID="txtIdSolicitud" runat="server" />
   

    <div class="row justify-content-center">
        <table id="tblDetalle" style="width: 70%;" class="table table-hover">
            <thead class="bg-primary">

                <tr>
                    <th scope="col">oficina</th>
                    <th scope="col">Serial Equipo</th>
                    <th scope="col">Observaciones</th>
                </tr>
            </thead>
            <tbody>
                <tr id="fila">
                    <td id="dOficina"></td>
                    <td id="dSerial"></td>
                    <td id="dObservacion"></td>
                </tr>
            </tbody>
        </table>

    </div>
    <br />

    <div class="row justify-content-center">
        <div class="col-6">
            <div class="form-group2">
                <h2></h2>
                <h2>Registrar Respuesta al Servicio</h2>
                <asp:TextBox ID="txtObservacionSolucion" runat="server" TextMode="MultiLine" class="form-control" required="required" placeholder="Ingrese aqí las observaciones al servicio prestado."></asp:TextBox>
                <br />

                <asp:Button ID="btnAtender" runat="server" Text="Atender Solicitud" class="row btn btn-primary" OnClick="btnAtender_Click" />
                <br />
                 <div class="container mt-4">
                <asp:Label ID="lblMensaje" runat="server" BorderColor="#0066FF" Font-Bold="True"></asp:Label>
                     </div>
            </div>
        </div>
    </div>

</asp:Content>
