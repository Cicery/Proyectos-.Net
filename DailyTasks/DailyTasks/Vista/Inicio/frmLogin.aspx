<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Inicio/Inicio.Master" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="DailyTasks.Vista.Inicio.frmLogin" %>

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
    <!---funciones--->
    <script src="../../Recursos/Funciones/Funciones.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">
    <div class=" pull-right" style="margin-top:-50px;">
       <div class="alert alert-info " role="alert">
            <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>

            <asp:Label ID="lblMensaje" runat="server"  Text="Inicio de Sesión"></asp:Label>
  
        </div>
        </div>
    <div class="login-box">
     
        <div class="login-logo">
            <a href="../../index2.html"><b>Daily</b>Tasks</a>
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">Iniciar sesión</p>


            <div class="form-group  has-feedback">

                <label>Usuario</label>
                <asp:TextBox ID="txtlogin" class="form-control" runat="server" placeholder="Usuario"></asp:TextBox>
                <span class="glyphicon glyphicon-user form-control-feedback"></span>
            </div>

            <div class="form-group has-feedback">
                <label>Contraseña</label>
                <asp:TextBox ID="txtPassword" class="form-control" runat="server" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
                <span class="glyphicon glyphicon-lock form-control-feedback"></span>
            </div>
            <div class="row">

                <!-- /.col -->
                <div class="col-xs-4 pull-right">
                    <asp:Button ID="btnIngresar" runat="server" class="btn btn-primary btn-block btn-flat" Text="Ingresar" OnClick="btnIngresar_Click" />
                </div>
                <!-- /.col -->
            </div>

            <a href="frmRegistrarse.aspx" class="text-center">Registrate si no tienes una cuentas</a>

        </div>
        <!-- /.login-box-body -->
    </div>
</asp:Content>
