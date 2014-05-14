using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using ControlesMS;
namespace CapaPresentacion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            dgProductos.DataSource = cnProducto.GetAll();
        }

        private void btNuevoProducto_Click(object sender, EventArgs e)
        {
            frmEmergente frm = new frmEmergente();
            
            frm.ShowDialog();
        }
    }
}
