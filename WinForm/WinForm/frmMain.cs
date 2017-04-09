using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocios;

namespace WinForm
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            DataTable oDT = new DataTable();
            LogicaDeNegocios.Genero oGenro = new Genero();

            oDT = oGenro.Cargar_Genero();
            cmbGenero.DataSource = oDT;
            cmbGenero.DisplayMember = Descripcion_Genero;

        }
    }
}
