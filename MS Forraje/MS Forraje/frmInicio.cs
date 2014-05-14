using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MS_Forraje
{
    public partial class frmInicio : Form
    {
        msProductos msProd;
        public frmInicio()
        {
            InitializeComponent();
        }

        #region Menu Izquierdo

        #region Metodos
        private void Cargar_ControlProductos(msProductos mscontrol)
        {
            this.splitFormulario.Panel2.Controls.Add(mscontrol); //agrega al panel derecho
            mscontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            mscontrol.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mscontrol.Location = new System.Drawing.Point(0, 0);
            mscontrol.Margin = new System.Windows.Forms.Padding(5);
            mscontrol.Size = new System.Drawing.Size(799, 692);
            mscontrol.TabIndex = 0;

        }
        #endregion // metodos

        #region Eventos
        private void rMenu2_Click(object sender, EventArgs e)
        {
            try
            {
                if (msProd.Enabled)
                    msProd.Visible = true;
            }
            catch
            {
                msProd = new msProductos();
                Cargar_ControlProductos(msProd);
            }
        }
        private void rMenu2_CheckedChanged(object sender, EventArgs e)
        {
            if (!rMenu2.Checked)
                msProd.Visible = false;
        }
        #endregion// eventos

        #endregion //menu izq










    }
}
