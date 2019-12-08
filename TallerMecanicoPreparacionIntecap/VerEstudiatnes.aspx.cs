using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TallerMecanicoPreparacionIntecap
{
    public partial class VerEstudiatnes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BLLEstudiante estu = new BLLEstudiante();
                this.grvEstudiantes.DataSource = estu.ObtenerTodosEstudiantes();
                this.grvEstudiantes.DataBind();
                this.drpMeses.DataSource = estu.ObtenerTodosMeses();
                this.drpMeses.DataValueField = "id_mes";
                this.drpMeses.DataTextField = "nombre_mes";
            }
        }
    }
}