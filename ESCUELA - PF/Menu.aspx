<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="ESCUELA___PF.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<!--===============================================================================================-->
    <title>¡Colegio! - Menú</title>
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/util.css" rel="stylesheet" />
    <link href="css/sweetalert.css" rel="stylesheet" />
<!--===============================================================================================-->
</head>
<body>
    
        <div class="container-contact100">
	<div class="wrap-contact100">
		<form class="contact100-form validate-form"> <form id="form1" runat="server">
			<span class="button-text-1">
				JEREZ CARLOS
			</span>
			<span class="button-text-2">
				MENÚ DE OPCIONES
			</span>
			<span class="button-text-1">
				<img class="imag-cf" src="img/cf.png"/>
			</span>
			
			<div class="modal-button">
				<div id="Reg_alum" class="button-auto">
			        <div class="button-img">
			            <img class="imag-d" src="img/mt.png"/>
			        </div>
			        <div class="button-text">
			            <div><strong>REGISTRAR ALUMNO</strong></div>
			        </div>
			    </div>
				<div id="Reg_doc" class="button-auto">
			        <div class="button-img">
			            <img class="imag-d" src="img/mt.png"/>
			        </div>
			        <div class="button-text">
			            <div><strong>REGISTRAR DOCENTE</strong></div>
			        </div>
			    </div>
			    <div id="Matric" class="button-auto">
			        <div class="button-img">
			            <img class="imag-d" src="img/mt.png"/>
			        </div>
			        <div class="button-text">
			            <div><strong>MATRICULAR</strong></div>
			        </div>
			    </div>

			    <div class="button-auto">
			        <div class="button-img">
			            <img class="imag-d" src="img/mt.png"/>
			        </div>
			        <div class="button-text">
			            <div><strong>ASISTENCIA</strong></div>
			        </div>
			    </div>

			    <div class="button-auto">
			        <div class="button-img">
			            <img class="imag-d" src="img/mt.png"/>
			        </div>
			        <div class="button-text">
			            <div><strong>DOCENTES</strong></div>
			        </div>
			    </div>

			    <div class="button-auto">
			        <div class="button-img">
			            <img class="imag-d" src="img/mt.png"/>
			        </div>
			        <div class="button-text">
			            <div><strong>ALUMNOS</strong></div>
			        </div>
			    </div>

			    <div class="button-auto">
			        <div class="button-img">
			            <img class="imag-d" src="img/mt.png"/>
			        </div>
			        <div class="button-text">
			            <div><strong>REPORTES</strong></div>
			        </div>
			   	</div>

			</div>
		</form>		
	</div>
</div>
<!--===============================================================================================-->
    <script src="Scripts/Selector/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script>
        let Regalum = document.getElementById("Reg_alum");
		let Regdoc = document.getElementById("Reg_doc");
        let Matricular = document.getElementById("Matric");

        Regalum.addEventListener("click",enviar_Regalum);
		Regdoc.addEventListener("click", enviar_Regdoc);
        Matricular.addEventListener("click", enviar_Matricular);

        function enviar_Regalum() {
            location.href = "Registrar_Alumno.aspx";
		}
        function enviar_Regdoc() {
            location.href = "Registrar_Docente.aspx";
		}
        function enviar_Matricular() {
            location.href = "Matricular.aspx";
        }

    </script>
    </form>
</body>
</html>
