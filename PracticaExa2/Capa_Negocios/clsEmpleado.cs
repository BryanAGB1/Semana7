using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Negocios
{
    public class clsEmpleado{

        public bool insertarEmpleado(String strNombre, String strApellidos, string strIdCedula, float flSalario)
        {
            return new Capa_Conexion.ClsEmpleado().insertarEmpleado(new Capa_Entidad.ClsEmpleado(strNombre, strApellidos, strIdCedula, flSalario));
        }

        public DataTable cargarEmpleados()
        {
            return new Capa_Conexion.ClsEmpleado().selectEmpleado();
        }

    }//fin cls empleado
}//fin capa negocios
