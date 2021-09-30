<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar_Alumno.aspx.cs" Inherits="ESCUELA___PF.Matricula" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<!--===============================================================================================-->
    <title>¡Colegio! - RegistrarAlumno</title>
	
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/util.css" rel="stylesheet" />
<!--===============================================================================================-->
</head>
<body>
        <div class="container-contact100">
		<div class="wrap-contact100">
			<form class="contact100-form validate-form> <form id="form1" runat="server">
				<span class="contact100-form-title">
					REGISTRAR ALUMNO
				</span>

				<div class="wrap-input100 validate-input bg1 rs1-wrap-input100" data-validate="Please Type Your Name">
					<span class="label-input100">APELLIDO PATERNO *</span>
					<asp:TextBox ID="txt_APaterno" cssclass="input100" placeholder="Ingrese el Apellido Paterno" maxlength="20" runat="server" ></asp:TextBox>
				</div>

				<div class="wrap-input100 bg1 rs1-wrap-input100">
					<span class="label-input100">APELLIDO MATERNO *</span>
					<asp:TextBox ID="txt_AMaterno" cssclass="input100" placeholder="Ingrese el Apellido Materno" maxlength="20" runat="server"></asp:TextBox>
				</div>
				
				<div class="wrap-input100 validate-input bg1">
					<span class="label-input100">NOMBRES *</span>
					<asp:TextBox ID="txt_Nombre" cssclass="input100" placeholder="Ingrese el Nombre" maxlength="20" runat="server"></asp:TextBox>
				</div>

				<div class="wrap-input100 validate-input bg1" >
					<span class="label-input100">DIRECCIÓN *</span>
					<asp:TextBox ID="txt_Direccion" cssclass="input100" placeholder="Ingrese el Dirección" maxlength="20" runat="server"></asp:TextBox>
				</div>

				<div class="wrap-input100 bg1 rs1-wrap-input100">
					<span class="label-input100">FECHA DE NACIMIENTO *</span>
					<asp:TextBox ID="txt_FNacimiento" cssclass="input100" placeholder="Ingrese la fecha de nacimiento" maxlength="20" runat="server"></asp:TextBox>
				</div>

				<div class="wrap-input100 validate-input bg1 rs1-wrap-input100" >
					<span class="label-input100">DNI *</span>
					<asp:TextBox ID="txt_DNI" cssclass="input100" placeholder="Ingrese el DNI" maxlength="8" runat="server"></asp:TextBox>
				</div>

				<div class="wrap-input100 bg1 rs1-wrap-input100">
					<span class="label-input100">TELÉFONO *</span>
					<asp:TextBox ID="txt_Telefono" cssclass="input100" placeholder="Ingrese el número de Teléfono" maxlength="9" runat="server"></asp:TextBox>
				</div>

				<div class="wrap-input100 validate-input bg1 rs1-wrap-input100" >
					<span class="label-input100">EMAIL *</span>
					<asp:TextBox ID="txt_Email" cssclass="input100" placeholder="Ingrese el Email" maxlength="200" runat="server"></asp:TextBox>
				</div>

				<div class="wrap-btn validate-input bg1 rs1-wrap-input100">
                    <asp:Button  ID="btnRegistrar" cssclass="contact100-form-btn rs1-wrap-input100" Text="REGISTRAR" runat="server" OnClick="Registrar_Click"/>
				</div>

				<div class="wrap-btn validate-input bg1 rs1-wrap-input100">
                    <asp:Button  ID="btnCancelar" cssclass="contact100-form-btn rs1-wrap-input100" Text="CANCELAR" runat="server" OnClick="Cancelar_Click"/>
				</div>
			</form>
		</div>
	</div>
<!--===============================================================================================-->
    <script src="Scripts/Selector/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->

<!--===============================================================================================-->
	<script src="../animation/select2/select2.min.js"></script>
	<script>
		$(".js-select2").each(function(){
			$(this).select2({
				minimumResultsForSearch: 20,
				dropdownParent: $(this).next('.dropDownSelect2')
			});


			$(".js-select2").each(function(){
				$(this).on('select2:close', function (e){
					if($(this).val() == "Please chooses") {
						$('.js-show-service').slideUp();
					}
					else {
						$('.js-show-service').slideUp();
						$('.js-show-service').slideDown();
					}
				});
			});
		})
    </script>
</form>

</body>
</html>
