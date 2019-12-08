using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TallerMecanicoPreparacionIntecap
{
    public partial class AgregarEstudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //comprobar permisos
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            BLLEstudiante estudiante = new BLLEstudiante();
            int idEstudiante = 0;
            bool correcto = false;
            string mensaje = "";
            DateTime fechaNac = new DateTime();
            try
            {
                fechaNac=Convert.ToDateTime(Funciones.formatearFecha(this.txtFechaNac.Text.Trim())).Date;
                correcto = true;
            }
            catch
            {
                mensaje = "Ha ocurrido un error, la fecha no se encuentra en el formato correcto";
            }
            if(correcto)
                mensaje = estudiante.insertarEstudiante(this.txtNombres.Text.Trim(), this.txtApellidos.Text.Trim(), this.txtDPI.Text.Trim(), fechaNac.Date, this.txtMatricula.Text.Trim(), ref idEstudiante);
            if (Funciones.tipoMensaje(mensaje))
                mostrarAlertaExito(mensaje);
            else
                mostrarAlertaError(mensaje);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), "limpiarTextos", "limpiar_textos()", true);
        }

        private void mostrarAlertaExito(string mensaje)
        {
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), "text", " mostrar_alerta('" + mensaje + "','.alerta.exito')", true);
        }
        private void mostrarAlertaAdvertencia(string mensaje)
        {
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), "text", " mostrar_alerta('" + mensaje + "','.alerta.advertencia')", true);
        }
        private void mostrarAlertaError(string mensaje)
        {
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), "text", " mostrar_alerta('" + mensaje + "','.alerta.error')", true);
        }

    }
}