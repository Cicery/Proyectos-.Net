<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Inicio/Inicio.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DailyTasks.Vista.Usuarios._default" %>
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
    <h1></h1>
        <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Inicio Usuario
        <small>Daily Tasks</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="default.aspx"><i class="fa fa-dashboard active"></i>Inicio</a></li>
         
        </ol>
    </section>
    <section class="content">
        <div class="col-md-6">
            <img src="../../Recursos/Imagenes/deca56b8509ab7dfd09d6ffa39aef445.jpg"/>
            </div>
        <div class="col-md-6">
            <img src="../../Recursos/Imagenes/folder-red-scheduled-tasks-icon.png"/>
        </div>
        </section>
</asp:Content>
