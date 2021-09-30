using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ESCUELA___PF
{
    public partial class Matricula : System.Web.UI.Page
    {
        Conexion cn = new Conexion();
        Consulta consul = new Consulta();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registrar_Click(object sender, EventArgs e)
        {
            string DNI = txt_DNI.Text.ToString().ToUpper();
            string ApellidoPaterno = txt_APaterno.Text.ToString();
            string ApellidoMaterno = txt_AMaterno.Text.ToString();
            string Nombre = txt_Nombre.Text.ToString();
            string Direccion = txt_Direccion.Text.ToString();
            string Telefono = txt_Telefono.Text.ToString();
            string Nacimiento = txt_FNacimiento.Text.ToString();
            string Email = txt_Email.Text.ToString();

            SqlCommand cmd = new SqlCommand();
              cmd.Connection = cn.conection;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "set_regalum";
              cmd.Parameters.Add("@DNI", SqlDbType.VarChar).Value = DNI;
              cmd.Parameters.Add("@ApPaterno", SqlDbType.VarChar).Value = ApellidoPaterno;
              cmd.Parameters.Add("@ApMaterno", SqlDbType.VarChar).Value = ApellidoMaterno;
              cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
              cmd.Parameters.Add("@Dirección", SqlDbType.VarChar).Value = Direccion;
              cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Telefono;
              cmd.Parameters.Add("@FechaNacimiento", SqlDbType.VarChar).Value = Nacimiento;
              cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
              cmd.Connection.Open();
              cmd.ExecuteNonQuery();
              cmd.Connection.Close();
        }
        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx");
        }

    }
}