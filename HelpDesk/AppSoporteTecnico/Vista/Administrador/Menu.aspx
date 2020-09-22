<link href="../../Recursos/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.4.2/css/all.css"
    integrity="sha384-/rXc/GQVaYpyDdyxK+ecHPVYJSN9bmVFBvjA/9eOB+pb3F2w2N6fc5qB9Ew5yIns" crossorigin="anonymous">

<script src="../../Recursos/bootstrap/jquery-3.3.1.slim.min.js"></script>
<script src="../../Recursos/bootstrap/popper.min.js"></script>

<script src="../../Recursos/bootstrap/js/bootstrap.min.js"></script>
<script src="../../Recursos/jquery/external/jquery/jquery.js"></script>

<nav class="navbar navbar-dark navbar-expand-md" style="z-index: 1; width: 100%; background: #4b627f;">

    <a class="navbar-brand" href="default.aspx">
        <!--- <img src="../../Recursos/Logo/LOGO3.png"  alt="LOGO2" class="d-inline-block align-top" style="height:25px; width:auto;">---->
        HelpDesk
    </a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
    </button>

    <div class="collapse navbar-collapse" id="navbarNavDropdown">
        <div class="navbar-nav mr-auto text-center">


            <a class="nav-link" href="default.aspx"><span class="icon-home mr-2"></span>Inicio</a>
            <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">Administración</a>
                <div class="dropdown-menu">
                    <a class="dropdown-item" href="frmAgregarEmpleado.aspx">Agregar Empleado</a>
                    <a class="dropdown-item" href="frmAgregarDependencia.aspx">Agregar Dependencias</a>
                    <a class="dropdown-item" href="frmAgregarEquipos.aspx">Agregar Equipo</a>

                </div>
            </li>


        </div>
        <div class="navbar-nav  text-center">
            <a class="nav-link" href="../Salir.aspx"><i class="fas fa-power-off mr-2"></i>SALIR</a>
        </div>

    </div>
</nav>
