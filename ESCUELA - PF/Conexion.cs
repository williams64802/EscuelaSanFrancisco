using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ESCUELA___PF
{
    public class Conexion{
        public SqlConnection conection = new SqlConnection("Data Source=JUAN\\EXPRESS2014;Initial Catalog=dbEscuela;Integrated Security=True"); 
        public void conectar(){
            conection.Open();
        }
        public void desconectar() {
            conection.Close();
        }
    }    
}