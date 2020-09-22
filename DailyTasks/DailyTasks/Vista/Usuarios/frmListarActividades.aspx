<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Inicio/Inicio.Master" AutoEventWireup="true" CodeBehind="frmListarActividades.aspx.cs" Inherits="DailyTasks.Vista.Usuarios.ListarActividades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Bootstrap 3-->
    <link href="../../Recursos/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Font Awesome -->
    <link href="../../Recursos/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <!-- Ionicons -->
    <link href="../../Recursos/Ionicons/css/ionicons.min.css" rel="stylesheet" />
    <!-- Theme style -->
    <link href="../../Recursos/dist/css/AdminLTE.min.css" rel="stylesheet" />
    <!-- AdminLTE Skins. Choose a skin from the css/skins
             folder instead of downloading all of them to reduce the load. -->
    <link href="../../Recursos/dist/css/skins/_all-skins.min.css" rel="stylesheet" />
    <!-- jquery ui-mi.css -->
    <link href="../../Recursos/jquery/jquery-ui.min.css" rel="stylesheet" />
    <!-- Google Font -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
    <!-- Data table -->
    <link href="../../Recursos/dataTable/datatables.min.css" rel="stylesheet" />


    <!-- jQuery  -->
    <script src="../../Recursos/jquery/external/jquery/jquery.js"></script>
    <!-- jQuery ui -->
    <script src="../../Recursos/jquery/jquery-ui.min.js"></script>
    <!-- Bootstrap 3.3.7 -->
    <script src="../../Recursos/bootstrap/dist/js/bootstrap.min.js"></script>
    <!-- SlimScroll -->
    <script src="../../Recursos/jquery-slimscroll/jquery.slimscroll.min.js"></script>
    <!-- FastClick -->
    <script src="../../Recursos/fastclick/lib/fastclick.js"></script>
    <!-- AdminLTE App -->
    <script src="../../Recursos/dist/js/adminlte.min.js"></script>
    <!-- AdminLTE for demo purposes -->
    <script src="../../Recursos/dist/js/demo.js"></script>
    <!-- Funciones -->
    <script src="../../Recursos/Funciones/Funciones.js"></script>
    <!-- Data table -->
    <script src="../../Recursos/dataTable/datatables.min.js"></script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">
    
                <asp:HiddenField ID="txtIdTarea" runat="server" />
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Actividades Realizadas
            <small>Daily Tasks</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="default.aspx"><i class="fa fa-dashboard"></i>Inicio</a></li>
            <li class="active">Actividades De la tarea </li>
        </ol>
    </section>

    <section class="content">
            <div class="alert alert-info " role="alert">
        <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>

        <asp:Label ID="lblMensaje" runat="server" Text="Lista de actividades"></asp:Label>

    </div>
        <div id="contAggActividad" style="display:none">
        <div class="box box-success" >
            <div class="box-header with-border">
                <h3 class="box-title">Reportar Nueva Actividad</h3>
            </div>
            <!-- /.box-header -->
            <!-- form start -->
            <div role="form">
                <div class="box-body">
                    <div class="form-group col-xs-6">
                        <label>Fecha</label>
                            <asp:TextBox ID="txtFechaA" class="form-control" runat="server" TextMode="Date" Format="dd/MM/yyyy"></asp:TextBox>
                    </div>
                    <div class="form-group col-xs-5">
                        <label>Duración</label>
                        <div class="input-group">
                            <asp:TextBox ID="txtDuracionA" class="form-control" placeholder="Duración" runat="server" TextMode="Number" ValidationExpression="^[0-9]+$"></asp:TextBox>
                            <span class="input-group-addon">Horas</span>
                        </div>
                    </div>
                    <div class="form-group col-xs-12">
                        <label>Descripción</label>
                        <asp:TextBox ID="txtDescripcionA" class="form-control" runat="server" Rows="3" TextMode="MultiLine"></asp:TextBox>
                    </div>

                </div>
                <!-- /.box-body -->

                <div class="box-footer">
                    <div class="col-xs-4 pull-left">
                    <asp:Button ID="btnAgregarActividad" runat="server" class="btn btn-success btn-block btn-flat " Text="Agregar Actividad" OnClick="btnAgregarActividad_Click"  />
                </div>
                    </div>
            </div>
        </div>
            </div>

        <div class="box box-default">
            <div class="box-header with-border">
                <h1 class="box-title">
                    <asp:Label ID="lblDesTarea" runat="server" Text=""></asp:Label></h1>
                <!-- /.col -->
                <div class="col-xs-4 pull-right">
                    <button type="button" class="btn btn-primary btn-block btn-flat " id="btnNuevaActividad">Reportar mas actividades</button>
                </div>
            </div>
            <div class="box-body">



                <table id="tblActividades" class="table table-hover">
                    <thead class="bg-primary">

                        <tr>
                            <th scope="col">Fecha de realizacion</th>
                            <th scope="col">Duración</th>
                            <th scope="col">Descripcion de la Actividad</th>
                            <th scope="col">Estado</th>

                        </tr>
                    </thead>
                    <tbody>
                        <tr id="aFila">
                            <td id="aFecha"></td>
                            <td id="aDuracion"></td>
                            <td id="aDescripcion"></td>
                            <td id="aEstado"></td>

                        </tr>
                    </tbody>
                </table>


            </div>
        </div>
    </section>

</asp:Content>
