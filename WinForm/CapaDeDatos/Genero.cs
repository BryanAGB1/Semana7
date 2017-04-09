using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDeDatos
{
    public class Genero
    {
        public void Main()
        {
        }

        public DataTable Cargar_Genero(){
            DataTable oDT = new DataTable();
            CapaDeDatos.Coneccion oCDD = new Coneccion();
            oDT = oCDD.EjecutarCmd("Select ID_Genero, Descripcion_Genero from Genero;")
        }
    }
}
