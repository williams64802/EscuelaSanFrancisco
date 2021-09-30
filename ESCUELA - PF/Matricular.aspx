<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Matricular.aspx.cs" Inherits="ESCUELA___PF.Matricular" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<!--===============================================================================================-->
    <title>¡Colegio! - Matricula</title>
	
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/util.css" rel="stylesheet" />
<!--===============================================================================================-->
</head>
<body>
   
        <div class="container-contact100">
		<div class="wrap-contact100">
			<form class="contact100-form validate-form"> <form id="form1" runat="server">
				<span class="contact100-form-title">
					MATRICULAR
				</span>

				<div class="wrap-input100 bg1 rs1-wrap-input100">
					<span class="label-input100">IDALUMNO *</span>
					<input class="input100" type="text" name="phone" placeholder="Ingrese ID de alumno">
				</div>

				<div class="wrap-input100 validate-input bg1 rs1-wrap-input100" >
					<span class="label-input100">DNI *</span>
					<asp:TextBox ID="txt_DNI" cssclass="input100" placeholder="Ingrese el DNI" maxlength="8" runat="server"></asp:TextBox>
				</div>

				<div class="wrap-input100 input100-select bg1 rs1-wrap-input100">
					<span class="label-input100">GRADO *</span>
					<div>
						<asp:DropDownList CssClass="dropDown_S" ID="DropDownList1" runat="server" >
                            <asp:ListItem Value="1">PRIMER GRADO</asp:ListItem>
                            <asp:ListItem Value="2">SEGUNDO GRADO</asp:ListItem>
							<asp:ListItem Value="3">TERCER GRADO</asp:ListItem>
                            <asp:ListItem Value="4">CUARTO GRADO</asp:ListItem>
							<asp:ListItem Value="5">QUINTO GRADO</asp:ListItem>
                            <asp:ListItem Value="6">SEXTO GRADO</asp:ListItem>
                        </asp:DropDownList>
					</div>
				</div>

				<div class="wrap-input100 validate-input bg1 rs1-wrap-input100" >
					<span class="label-input100">SECCIÓN *</span>
					<asp:TextBox ID="txt_Seccion" cssclass="input100" placeholder="Ingrese la Sección" maxlength="8" runat="server"></asp:TextBox>
				</div>
					
				<div class="wrap-input100 validate-input bg1">
					<span class="label-input100"> MONTO A PAGAR *</span>
					<asp:TextBox ID="txt_Monto" cssclass="input100" placeholder="Ingrese Monto a Pagar" maxlength="8" runat="server"></asp:TextBox>
				</div>

				<div class="wrap-btn validate-input bg1 rs1-wrap-input100">
					<asp:Button  ID="btnMatricular" cssclass="contact100-form-btn rs1-wrap-input100" Text="MATRICULAR" runat="server"/>
				</div>

				<div class="wrap-btn validate-input bg1 rs1-wrap-input100" >
					<asp:Button  ID="btnCancelar" cssclass="contact100-form-btn rs1-wrap-input100" Text="CANCELAR" runat="server" OnClick="Cancelar_Click"/>
				</div>					

			</form>
		</div>
	</div>
<!--===============================================================================================-->
  
<!--===============================================================================================-->

<!--===============================================================================================-->
    </form>
</body>
</html>
