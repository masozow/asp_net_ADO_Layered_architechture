using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL.DataSetEstudianteTableAdapters;
namespace BLL
{
    public class BLLEstudiante
    {
        QueriesTableAdapter insertarActualizar = new QueriesTableAdapter();
        QueriesTableAdapter InsertarActualizar
        {
            get { return insertarActualizar; }
        }
        //private ClassDAL estudiante;
        public BLLEstudiante()
        {
            //estudiante = new ClassDAL();
        }
        public string insertarEstudiante(string nombres, string apellidos, string dpi, DateTime fechaNac, string matricula, ref int idEstudiante)
        {
            /*
            string mensaje = "";
            SqlParameter idEst = new SqlParameter("@idEstudiante", idEstudiante);
            idEst.Direction = ParameterDirection.Output;
            SqlParameter mens = new SqlParameter("@mensaje", mensaje);
            mens.Direction = ParameterDirection.Output;
            estudiante.insertarActualizar("agregar_estudiante", new SqlParameter[]{
                new SqlParameter("@matricula",matricula),
                new SqlParameter("@nombres",nombres),
                new SqlParameter("@apellidos",apellidos),
                new SqlParameter("@dpi",dpi),
                new SqlParameter("@fechaNac",fechaNac),
                mens,idEst
            });
            return mensaje;
            */
            string mensaje="";
            int? idEst = (int?)idEstudiante;
            insertarActualizar.agregar_estudiante(matricula, nombres, apellidos, dpi, fechaNac.Date, ref mensaje, ref idEst);
            return mensaje;
        }
        public DataTable ObtenerTodosEstudiantes()
        {
            DAL.ClassDAL est = new DAL.ClassDAL();
            return est.RealizarConsultaSinParametros("sp_obtenerTodosEstuddiantes");
        }
        public DataTable ObtenerTodosMeses()
        {
            DAL.ClassDAL datos = new DAL.ClassDAL();
            return datos.RealizarConsulta("sp_obtenerTodosMesesActivos", new object[] { });
        }
    }
}
