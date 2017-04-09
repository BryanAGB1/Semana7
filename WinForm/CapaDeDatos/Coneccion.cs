using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class Coneccion
    {
        private SqlConnection oCN = new SqlConnection(@
            "Data sourse = BRYAN_AGB\MSSQL2016;
            Integrated security = true)

            ///falta
    }

    public bool Abrir_Conexion()
    {
        try
        {
            oCN.Open();
            return true;
        }

    }


    public bool Cerrar_Conexion()
    {
        try
        {
            if (oCN.State == ConnectionState.Closed)
            {
                return true;
            }
            ocn.Close();
            return true;
        }
        catch (Exception e1)
        {
            throw e1
        }
        finally
        {
            oCN.Close();
        }
        return false;
    }


    public DataTable EjecutarCmd(String pCmd) {
        SqlCommand oCMD = new SqlCommand();
        DataTable oDT = new DataTable();
        SqlDataAdapter oSQLA = new SqlDataAdapter(oCMD);
        try
        {
            oCMD.CommandText = pCmd;
            oCMD.CommandType = CommandType.Text; //LOS TIPOS DE DATOS QUE VA A RETORNAR (INCLUYE LOS PROCEDIMIENTOS ALMACENADOS)
            oCMD.Connection = oCN;
        }
        catch(Exception e1)
        {
            throw e1;
        }
        if (Abrir_Conexcion)
    }

    //falta
}
