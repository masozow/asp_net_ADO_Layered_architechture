using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class ClassDAL
    {
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection cn;
        SqlCommand cmd;
        private string cadena;
        protected string Cadena
        {
            get { return cadena; }
            set { cadena = value; }
        }
        public ClassDAL()
        {
            establecer_conexion();
            abrir_conexion();
        }
        private void abrir_conexion()
        {
            if (cn.State != ConnectionState.Open)
                cn.Open();
        }
        private void cerrar_conexion()
        {
            if (cn.State != ConnectionState.Closed)
                cn.Close();
        }
        private void establecer_conexion()
        {
            try
            {
                cadena = "Data Source=MASOZOW-PC;Initial Catalog=ControlNotasPrueba;Persist Security Info=True;User ID=sa;Password=database";
                cn = new SqlConnection(cadena);
            }
            catch
            {

            }
        }
        public string insertarActualizar(string procedimiento, object[] parametros)
        {
          
            try
            {
                cmd = new SqlCommand(procedimiento, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                string resultado = "";
                foreach (SqlParameter parametro in parametros)
                {
                    cmd.Parameters.AddWithValue(parametro.ParameterName, parametro.Value).Direction = parametro.Direction;
                }
                resultado = cmd.ExecuteNonQuery().ToString();
                cerrar_conexion();
                return resultado;
            }
            catch (Exception ex)
            {
                cerrar_conexion();
                return ex.Message;
            }           
        }
        public DataTable RealizarConsulta(string procedimiento, object[] parametros)
        {
            try
            {
                dt = new DataTable();
                da = new SqlDataAdapter(procedimiento, cn);
                ds = new DataSet();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter parametro in parametros)
                {
                    da.SelectCommand.Parameters.AddWithValue(parametro.ParameterName,parametro.Value);
                }
                da.Fill(ds);
                cerrar_conexion();
                return ds.Tables[0];
            }
            catch
            {
                cerrar_conexion();
                return null;
            }
         }

        public DataTable RealizarConsultaSinParametros(string procedimiento)
        {
            //try
            //{
                dt = new DataTable();
                ds = new DataSet();
                da = new SqlDataAdapter(procedimiento, cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds);
                cerrar_conexion();
                return ds.Tables[0];
            //}
            //catch
            //{
            //    cerrar_conexion();
            //    return null;
            //}

        }












        
        





        
        
    }
}
