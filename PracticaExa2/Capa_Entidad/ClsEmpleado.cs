using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class ClsEmpleado{

        private String strNombre;
        private String strApellidos;
        private String strIdCedula;
        private float flSalario;

        //constructor
        public ClsEmpleado()
        {
        }
        public ClsEmpleado(String strNombre, String strApellidos, string strIdCedula, float flSalario)
        {
            this.strNombre = strNombre;
            this.strApellidos = strApellidos;
            this.strIdCedula = strIdCedula;
            this.flSalario = flSalario;
        }

        //PROPERTIES
        public string propStrNombre { get { return this.strNombre; } set { this.strNombre = value; }}
        public string propStrApellidos { get { return this.strApellidos; } set { this.strApellidos = value; }}
        public string propStIdCedula { get { return this.strIdCedula; } set { this.strIdCedula = value; }}
        public float propflSalario { get { return this.flSalario; } set { this.flSalario = value; }}
    }
}
