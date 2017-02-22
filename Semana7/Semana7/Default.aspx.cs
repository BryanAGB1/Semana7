using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Semana7
{
    public partial class _Default : Page
    {
        static String operacion; //variables globales
        static int operador;
        static int resAnterior;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                operacion = "";
                operador = 0;
                resAnterior = 0;
            }
        }

        protected void ans(object sender, EventArgs e)
        {
            operacion += resAnterior;
            valores.value = operacion; 
        }

        protected void cuatro(object sender, EventArgs e)
        {
            operacion += resAnterior;
            valores.value = operacion;
        }
    }
}