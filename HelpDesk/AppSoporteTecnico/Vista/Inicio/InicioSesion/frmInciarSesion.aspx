
<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Inicio/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmInciarSesion.aspx.cs" Inherits="AppSoporteTecnico.Vista.InicioSesion.frmInciarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title>Inicie sesión</title>
      <!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/help.png"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/Linearicons-Free-v1.0.0/icon-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
<!--===============================================================================================-->
    <!--===============================================================================================-->
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/daterangepicker/moment.min.js"></script>
	<script src="vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">

    <div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100">
				<div class="login100-form-title" style="background-image: url(images/helpdesk.png);">
					<span class="login100-form-title-1">
						Bienvenidos
					</span>
				</div>

				<div class="login100-form validate-form">
					<div class="wrap-input100 validate-input m-b-26" data-validate="Username is required">
						<span class="label-input100">Usuario: </span>
						  <asp:TextBox ID="txtlogin" runat="server" class="input100"  name="txtlogin" placeholder="INGRESAR USUARIO"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

				
                       <div class="wrap-input100 validate-input m-b-26" data-validate="password is required">
						<span class="label-input100">Contraseña: </span>
                           <asp:TextBox ID="txtPassword" type="password" runat="server" class="input100"  name="txtPassword" placeholder="INGRESAR CONTRASEÑA"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>
					
                    <br/>
                
				      <div class="container-login100-form-btn" >
						<asp:Button class="login100-form-btn col" ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click"></asp:Button>
				
                        
			           </div>  
               
                      <div class="container mt-4">
			              <asp:Label ID="lblMensaje" runat="server" BorderColor="#0066FF" Font-Bold="True"></asp:Label>
						</div>
				
					</div>
				</div>
               
		</div>
	</div>

</asp:Content>
