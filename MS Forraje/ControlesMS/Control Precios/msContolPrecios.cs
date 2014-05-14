using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlesMS
{
    public partial class msContolPrecios : UserControl
    {
        cCalculos Calculo = new cCalculos();
        bool ejecutar = true;
        public msContolPrecios()
        {
            this.Unidad = 1;
            InitializeComponent();
        }
        #region metodos
        void Asignacion_Controles(cCalculos calculo)
        {
            this.txtCosto = calculo.Costo;
            this.txtVenta = calculo.Venta;
            this.txtGanancia = calculo.Ganancia;
            this.txtMargen = calculo.Margen;
        }
        #endregion

        #region Eventos Handler de los Controles
        private void TextosCambia(object sender, EventArgs e)
        {
            if (ejecutar)
            {
                ejecutar = false;
                Calculo = new cCalculos(txtCosto, txtVenta, txtGanancia, txtMargen);
                Asignacion_Controles(Calculo);
                ejecutar = true;
            }
        }
        private void TextosDeterminadosCambia(object sender, EventArgs e)
        {
            if (ejecutar)
            {
                Calculo = new cCalculos(this.Unidad, txtKgDeterminado, txtCostoDeterminado, txtVentaDeterminado, txtCosto, txtVenta, txtGanancia, txtMargen);
                Asignacion_Controles(Calculo);
            }
        }
        #endregion

        private void rbPrecio1_CheckedChanged(object sender, EventArgs e)
        {
            this.gbDeterminadoKg.Visible = false;
        }

        private void rbPrecio2_CheckedChanged(object sender, EventArgs e)
        {
            this.gbDeterminadoKg.Visible = true;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtCosto.Clear();
            txtVenta.Clear();
            txtGanancia.Clear();
            txtMargen.Clear();
            txtCostoDeterminado.Clear();
            txtKgDeterminado.Clear();
            txtVentaDeterminado.Clear();
            Metodo();

        }
        public void Metodo()
        {
        }


    }
}
