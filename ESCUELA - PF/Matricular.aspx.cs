using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESCUELA___PF
{
    public partial class Matricular : System.Web.UI.Page
    {
        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx");
        }
    }
}