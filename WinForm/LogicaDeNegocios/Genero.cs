using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //
using CapaDeDatos;


namespace LogicaDeNegocios
{
    public class Genero
    {
        ////Atributios
        //#region Atributos
        //    private int lado = 0;
        //#endregion

        ////Propiedades
        //#region Propiedades
        //public int lado { get; set; }
        //#endregion

        //Constructores
        public void Main() {
        }

        public DataTable Cargar_Genero(){
            CapaDeDatos.Genero oGenero = new CapaDeDatos.Genero();
            return oGenero.Cargar_Genero();
        }
    }//fin de Genero
}//Fin logica negocios
