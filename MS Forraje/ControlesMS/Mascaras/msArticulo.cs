using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
namespace ControlesMS
{
    public partial class msArticulo : UserControl
    {
        public msArticulo()
        {
            InitializeComponent();
        }

        private void btEjecutar_Click(object sender, EventArgs e)
        {

        }


        private void txtCantidadUnidad_Leave(object sender, EventArgs e)
        {
            msPrecios.Unidad = txtCantidadUnidad.Valor;
        }





    }
}
