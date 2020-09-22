<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Inicio/Inicio.Master" AutoEventWireup="true" CodeBehind="frmRegistrarse.aspx.cs" Inherits="DailyTasks.Vista.Inicio.frmRegistrarse" %>

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
    <!-----funciones-->
    <script src="../../Recursos/Funciones/Funciones.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">
        <div class="col-8 pull-right" style="margin-top:-50px;">
       <div class="alert alert-info " role="alert">
            <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>

            <asp:Label ID="lblMensaje" runat="server"  Text="Registraese a la App"></asp:Label>
  
        </div>
        </div>

    <div class="register-box">
        <div class="register-logo">
            <a href="default.aspx"><b>Daily</b>Tasks</a>
        </div>

        <div class="register-box-body">
            <p class="login-box-msg">Crea una cuenta </p>


            <div class="form-group ">

                <label>Identificación</label>
                <asp:TextBox ID="txtIdentificacion" class="form-control" runat="server" TextMode="Number" placeholder="Ingrese su identificaión"></asp:TextBox>

            </div>

            <div class="form-group">

                <label>Nombre</label>
                <asp:TextBox ID="txtNombre" class="form-control" runat="server" placeholder="Ingrese nombre"></asp:TextBox>

            </div>
            <div class="form-group ">

                <label>Apellido</label>
                <asp:TextBox ID="txtApellido" class="form-control" runat="server" placeholder="Ingrese apellido"></asp:TextBox>

            </div>

            <div class="form-group ">

                <label>Correo</label>
                <asp:TextBox ID="txtCorreo" class="form-control" runat="server" TextMode="Email" placeholder="correo"></asp:TextBox>

            </div>
            <div class="row">

                <div class="col-xs-4 pull-right">

                    <asp:Button ID="btnRegistrar" runat="server" class="btn btn-primary btn-block btn-flat " Text="Registrarse" OnClick="btnRegistrar_Click" />
                </div>
                <!-- /.col -->
            </div>


            <a href="frmLogin.aspx" class="text-center">Ya tengo una cuenta</a>
        </div>
        <!-- /.form-box -->
    </div>
</asp:Content>
