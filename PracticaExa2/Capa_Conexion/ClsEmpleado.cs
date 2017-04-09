using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Conexion
{
    public class ClsEmpleado{

        public bool insertarEmpleado(Capa_Entidad.ClsEmpleado oEmpleado)
        {
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = "INSERT INTO DBO.Empleados (Nombre, Apellidos, IdCedula, Salario)" +
                "VALUES(@Nombre, @Apellidos, @Cedula, @Salario)";
            oSQLC.Parameters.Add("@Nombre", SqlDbType.VarChar, 30).Value = oEmpleado.propStrNombre;
            oSQLC.Parameters.Add("@Apellidos", SqlDbType.VarChar, 50).Value = oEmpleado.propStrApellidos;
            oSQLC.Parameters.Add("@Cedula", SqlDbType.VarChar, 9).Value = oEmpleado.propStIdCedula;
            oSQLC.Parameters.Add("@Salario", SqlDbType.Float).Value = oEmpleado.propflSalario;

            return new clsConexion().ejecCMD(oSQLC);
        }//fin insertar empleado
       
        public DataTable selectEmpleado()
        {
            SqlCommand oSQLC = new SqlCommand();
            oSQLC.CommandType = CommandType.Text;
            oSQLC.CommandText = "SELECT * FROM dbo.Empleados";
            return new clsConexion().ejecCMDSelect(oSQLC);
        }
    }
}
