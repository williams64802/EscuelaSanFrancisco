using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ESCUELA___PF
{
    public class Consulta
    {
        Conexion cn = new Conexion();

        public DataTable extrae(string nombresp, string nomparam1, string valorparam1, string nomparam2, string valorparam2,
            string nomparam3, string valorparam3, string nomparam4, string valorparam4, string nomparam5, string valorparam5,
            string nomparam6, string valorparam6, string nomparam7, string valorparam7)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cmd.Parameters.Add(nomparam1, SqlDbType.VarChar).Value = valorparam1;
            cmd.Parameters.Add(nomparam2, SqlDbType.VarChar).Value = valorparam2;
            cmd.Parameters.Add(nomparam3, SqlDbType.VarChar).Value = valorparam3;
            cmd.Parameters.Add(nomparam4, SqlDbType.VarChar).Value = valorparam4;
            cmd.Parameters.Add(nomparam5, SqlDbType.VarChar).Value = valorparam5;
            cmd.Parameters.Add(nomparam6, SqlDbType.VarChar).Value = valorparam6;
            cmd.Parameters.Add(nomparam7, SqlDbType.VarChar).Value = valorparam7;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            return dt;
        }

        public DataTable extrae(string nombresp)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            return dt;
        }
        public DataTable extrae(string nombresp, string nomparam1, int valorparam1)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cmd.Parameters.Add(nomparam1, SqlDbType.Int).Value = valorparam1;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            return dt;
        }

        public DataTable extrae(string nombresp, string nomparam1, string valorparam1)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cmd.Parameters.Add(nomparam1, SqlDbType.VarChar).Value = valorparam1;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            return dt;
        }
        public DataTable extrae(string nombresp, string nomparam1, int valorparam1, string nomparam2, int valorparam2)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cmd.Parameters.Add(nomparam1, SqlDbType.Int).Value = valorparam1;
            cmd.Parameters.Add(nomparam2, SqlDbType.Int).Value = valorparam2;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            return dt;
        }

        public DataTable extrae(string nombresp, string nomparam1, int valorparam1, string nomparam2, string valorparam2)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cmd.Parameters.Add(nomparam1, SqlDbType.Int).Value = valorparam1;
            cmd.Parameters.Add(nomparam2, SqlDbType.VarChar).Value = valorparam2;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            return dt;
        }

        public DataTable extrae(string nombresp, string nomparam1, int valorparam1, string nomparam2, int valorparam2, string nomparam3, string valorparam3)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cmd.Parameters.Add(nomparam1, SqlDbType.Int).Value = valorparam1;
            cmd.Parameters.Add(nomparam2, SqlDbType.Int).Value = valorparam2;
            cmd.Parameters.Add(nomparam3, SqlDbType.VarChar).Value = valorparam3;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            return dt;
        }

        public DataTable extrae(string nombresp, string nomparam1, string valorparam1, string nomparam2, string valorparam2)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cmd.Parameters.Add(nomparam1, SqlDbType.VarChar).Value = valorparam1;
            cmd.Parameters.Add(nomparam2, SqlDbType.VarChar).Value = valorparam2;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            return dt;
        }

        public DataTable extrae(string nombresp, string nomparam1, string valorparam1, string nomparam2, int valorparam2)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cmd.Parameters.Add(nomparam1, SqlDbType.VarChar).Value = valorparam1;
            cmd.Parameters.Add(nomparam2, SqlDbType.Int).Value = valorparam2;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            return dt;
        }

        public void eliminar(string nombresp, string nomparam1, string valorparam1, string nomparam2, int valorparam2)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cmd.Parameters.Add(nomparam1, SqlDbType.VarChar).Value = valorparam1;
            cmd.Parameters.Add(nomparam2, SqlDbType.Int).Value = valorparam2;
            cn.conectar();
            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            cn.desconectar();
        }

        public void eliminar(string nombresp, string nomparam1, string valorparam1)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cmd.Parameters.Add(nomparam1, SqlDbType.VarChar).Value = valorparam1;
            cn.conectar();
            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            cn.desconectar();
        }

        public void eliminar(string nombresp, string nomparam1, int valorparam1)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cmd.Parameters.Add(nomparam1, SqlDbType.Int).Value = valorparam1;
            cn.conectar();
            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            cn.desconectar();
        }



        public string getValor(string nombre_sp, string nombre_Param1, int val_Param1)
        {//, GridView gw
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            string resp = "1";
            dt = extrae(nombre_sp, nombre_Param1, val_Param1);
            //gw.DataSource = dt;
            //gw.DataBind();
            resp = dt.Rows[0][0].ToString();
            return resp;
        }

        public string getValor(string nombresp, string nombreParam1, int valParam1, string nombreParam2, int valParam2)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            string resp = "";
            dt = extrae(nombresp, nombreParam1, valParam1, nombreParam2, valParam2);
            resp = dt.Rows[0][0].ToString();
            return resp;
        }

        public void enviarValor(string nombreSP, string nombreparam1, int valEnviar)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Add(nombreparam1, SqlDbType.Int).Value = valEnviar;
            cn.conectar();
            // da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            cn.desconectar();

        }
        public string enviarValor(string nombreSP, string nombreparam1, int valEnviar, string nombreparam2)
        {
            SqlCommand cmd = new SqlCommand();
            string salida = "";
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Add(nombreparam1, SqlDbType.Int).Value = valEnviar;
            SqlParameter salidaParam = cmd.Parameters.Add(nombreparam2, SqlDbType.Int);
            salidaParam.Direction = ParameterDirection.Output;
            //cmd.Parameters.Add(salidaParam);
            cn.conectar();
            cmd.ExecuteNonQuery();
            cn.desconectar();
            salida = cmd.Parameters[nombreparam2].Value.ToString();
            return salida;
        }
        public void enviarValor(string nombreSP, string nombreparam1, int valEnviar1, string nombreparam2, int valEnviar2)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Add(nombreparam1, SqlDbType.Int).Value = valEnviar1;
            cmd.Parameters.Add(nombreparam2, SqlDbType.Int).Value = valEnviar2;
            cn.conectar();
            cmd.ExecuteNonQuery();
            cn.desconectar();
        }

        public DataTable extrae(string nombresp, string nomparam1, int valorparam1, string nomparam2, int valorparam2, string nomparam3, int valorparam3)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cmd.Parameters.Add(nomparam1, SqlDbType.Int).Value = valorparam1;
            cmd.Parameters.Add(nomparam2, SqlDbType.Int).Value = valorparam2;
            cmd.Parameters.Add(nomparam3, SqlDbType.Int).Value = valorparam3;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            return dt;
        }

        public void enviarValor(string nombreSP, string nombreparam1, string valEnviar1, string nombreparam2, int valEnviar2)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Add(nombreparam1, SqlDbType.VarChar).Value = valEnviar1;
            cmd.Parameters.Add(nombreparam2, SqlDbType.Int).Value = valEnviar2;
            cn.conectar();
            cmd.ExecuteNonQuery();
            cn.desconectar();
        }

        public string getvalor(string nomsp)
        {
            string res = "?";
            DataTable dt1 = new DataTable();
            dt1 = extrae(nomsp);
            int nrows = dt1.Rows.Count;
            if (nrows >= 1) res = dt1.Rows[0][0].ToString();
            return res;
        }
        public string getvalor(string nomsp, string nomparam, string valorparam)
        {
            string res = "?";
            DataTable dt1 = new DataTable();
            dt1 = extrae(nomsp, nomparam, valorparam);
            int nrows = dt1.Rows.Count;
            if (nrows >= 1) res = dt1.Rows[0][0].ToString();
            return res;
        }

        public string getvalor(string nomsp, string nomparam, int valorparam)
        {
            string res = "?";
            DataTable dt1 = new DataTable();
            dt1 = extrae(nomsp, nomparam, valorparam);
            int nrows = dt1.Rows.Count;
            if (nrows >= 1) res = dt1.Rows[0][0].ToString();
            return res;
        }

        public string getvalor(string nomsp, string nomparam, int valorparam, string nomparam2, string valorparam2)
        {
            string res = "?";
            DataTable dt1 = new DataTable();
            dt1 = extrae(nomsp, nomparam, valorparam, nomparam2, valorparam2);
            int nrows = dt1.Rows.Count;
            if (nrows >= 1) res = dt1.Rows[0][0].ToString();
            return res;
        }
        public void enviarValor(string nombreSP, string nombreparam1, int valEnviar1, string nombreparam2, bool valEnviar2)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Add(nombreparam1, SqlDbType.Int).Value = valEnviar1;
            cmd.Parameters.Add(nombreparam2, SqlDbType.Bit).Value = valEnviar2;
            cn.conectar();
            //da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            cn.desconectar();
            //Response.Write("<Script>alert('Modificado'); </script>");
        }

        public void enviarValor(string nombreSP, string nombreparam1, int valEnviar1, string nombreparam2, int valEnviar2,
            string nombreparam3, string valEnviar3)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn.conection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Add(nombreparam1, SqlDbType.Int).Value = valEnviar1;
            cmd.Parameters.Add(nombreparam2, SqlDbType.Int).Value = valEnviar2;
            cmd.Parameters.Add(nombreparam3, SqlDbType.VarChar).Value = valEnviar3;
            cn.conectar();
            cmd.ExecuteNonQuery();
            cn.desconectar();
        }


    }
}