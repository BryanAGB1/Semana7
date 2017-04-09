using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capa_Vista
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListEmpleados.DataSource = new Capa_Negocios.clsEmpleado().cargarEmpleados();
                ListEmpleados.DataBind();
            } 
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if(new Capa_Negocios.clsEmpleado().insertarEmpleado(txtNombre.Text, txtApellidos.Text, txtCedula.Text, (float)Convert.ToDouble(txtSalario.Text)))
            {
                ibExito.Text = "Ingreso Correcto";
                ListEmpleados.DataSource = new Capa_Negocios.clsEmpleado().cargarEmpleados();
                ListEmpleados.DataBind();
            }
            else
            {
                ibExito.Text = "Error";
            }
        }
    }
}