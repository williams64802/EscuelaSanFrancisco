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
    public partial class Menu : System.Web.UI.Page
    {
        Conexion cn = new Conexion();
        Consulta consul = new Consulta();
        protected void btnHidden_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Registrar Docente.aspx");
        }
    }

    
}