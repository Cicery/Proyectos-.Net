<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Inicio/Inicio.Master" AutoEventWireup="true" CodeBehind="frmAgregarTarea.aspx.cs" Inherits="DailyTasks.Vista.Usuarios.frmAgregarTarea" %>

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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">



    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Registro de segimiento de tareas
        <small>Daily Tasks</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="default.aspx"><i class="fa fa-dashboard"></i>Inicio</a></li>
            <li class="active">Agregar mis tareas</li>
        </ol>
    </section>


    <!-- Main content -->
    <section class="content">
            <div class="alert alert-info " role="alert">
        <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>

        <asp:Label ID="lblMensaje" runat="server" Text="Agregar Tareas"></asp:Label>

    </div>
        <div class="row">

            <!-- left column -->
            <div class="col-md-6">
                <!-- general form elements -->
                <div class="box box-primary">
                    <div class="box-header with-border">
                        <h3 class="box-title">Descripcion de la tarea</h3>
                    </div>
                    <!-- /.box-header -->
                    <!-- form start -->
                    <div role="form">
                        <div class="box-body">
                            <div class="form-group">
                                <label>Descripción</label>
                                <asp:TextBox ID="txtDescripcionTar" class="form-control " placeholder="descripción de la terea" runat="server"></asp:TextBox>

                            </div>

                        </div>
                        <!-- /.box-body -->
                    </div>
                    <!-- general form elements -->
                    <div class="box box-success">
                        <div class="box-header with-border">
                            <h3 class="box-title">Actividades Realizadas</h3>
                        </div>
                        <!-- /.box-header -->
                        <!-- form start -->
                        <div role="form">
                            <div class="box-body">
                                <div class="form-group col-xs-6">
                                    <label>Fecha</label>
                                    <asp:TextBox ID="txtFecha" class="form-control" runat="server" TextMode="Date" Format="dd/MM/yyyy"></asp:TextBox>

                                </div>
                                <div class="form-group col-xs-5">
                                    <label>Duración</label>
                                    <div class="input-group">
                                        <asp:TextBox ID="txtDuracion" class="form-control" placeholder="Duración" runat="server" TextMode="Number" ValidationExpression="^[0-9]+$"></asp:TextBox>
                                        <span class="input-group-addon">Horas</span>
                                    </div>
                                </div>
                                <div class="form-group col-xs-12">
                                    <label>Descripción</label>
                                    <asp:TextBox ID="txtDescripcion" class="form-control" runat="server" Rows="3" TextMode="MultiLine"></asp:TextBox>

                                </div>

                            </div>
                            <!-- /.box-body -->

                            <div class="box-footer">

                                <asp:Button ID="btnAggActividad" runat="server" class="btn btn-primary pull-right" Text="+" OnClick="btnAggActividad_Click" />
                            </div>
                        </div>
                    </div>

                </div>


            </div>
            <div class="col-md-6">
                <!-- general form elements -->
                <div class="box box-primary">
                    <div class="box-header with-border">
                        <h3 class="box-title">Lista de actividades que realizó</h3>
                    </div>
                    <!-- /.box-header -->
                    <!-- form start -->
                    <div role="form">
                        <div class="box-body" style="text-align: center;">
                            <div class="content">
                               
                                    <asp:GridView ID="tblActividades" runat="server" CssClass="content table table-responsive table-striped "  >
                                   
                                        <HeaderStyle BackColor="#261F81  " Font-Bold="True" ForeColor="White" />
                                 
                                    </asp:GridView>
                            
                            </div>

                        </div>
                        <!-- /.box-body -->

                        <div class="box-footer">
                            <div class="pull-left">
                                <asp:Button ID="btnBorrarActividades" CssClass="btn btn-danger" runat="server" Text="Cancelar actividades" Visible="false" OnClick="tbnBorrarActividades_Click" />
                            </div>
                            <div class="pull-right">
                            <asp:Button ID="btnAgregarTarea" class="btn btn-primary" runat="server" Text="Agregar Tarea" Visible="False" OnClick="btnAgregarTarea_Click" />
                                </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </section>



</asp:Content>
