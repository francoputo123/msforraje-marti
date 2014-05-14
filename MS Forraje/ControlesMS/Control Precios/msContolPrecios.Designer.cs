namespace ControlesMS
{
    using System;
    using System.Drawing;
    using System.ComponentModel;
    using System.Windows.Forms;
    partial class msContolPrecios
    {
        private double munidad;

        #region Propiedades

        #region Valores
        [DisplayName("Unidad")]
        [Description("Cantidad de Unidades o Kilos en que se fijara el precio, ejemplo producto x 3 kgs. DEBE SER MAYOR a 0")]
        public double Unidad
        {
            get { return munidad; }
            set 
            {
                if (value > 0)
                {
                    this.Enabled = true;
                    munidad = value;
                }
                else
                {
                    this.Enabled = false;
                    MessageBox.Show("La unidad ingresada debe ser mayor a 0", "Ingreso Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                    //throw new ArgumentException("La unidad tiene que ser mayor a 0");
            }
        }
        public bool Permitir_Determinado
        {
            get
            {
                if (this.gbDeterminadoKg.Visible)
                    return true;
                else
                    return false;
            }
            set
            {
                if (value)
                    this.gbDeterminadoKg.Visible = true;
                else
                    this.gbDeterminadoKg.Visible = false;
            }
        }
        public double Costo
        {
            get { return Calculo.valCosto; }
        }
        public double Venta
        {
            get { return Calculo.valVenta; }
        }
        #endregion
        #region Diseño
        [DisplayName("ColorCajasTexto")]
        [Description("Color de las cajas de texto.")]
        [Category("Colores")]
        public Color BackColorTextBox
        {
            get { return txtCosto.BackColor; }
            set
            {
                txtCosto.BackColor = value;
                txtVenta.BackColor = value;
                txtGanancia.BackColor = value;
                txtMargen.BackColor = value;
                txtCostoDeterminado.BackColor = value;
                txtVentaDeterminado.BackColor = value;
                txtKgDeterminado.BackColor = value;
            }
        }
        [DisplayName("ColorBoton")]
        [Description("Color del Boton")]
        [Category("Colores")]
        public Color BackColorBoton
        {
            get { return btLimpiar.BackColor; }
            set
            { btLimpiar.BackColor = value;}
        }
        #endregion

        #endregion

        private System.ComponentModel.IContainer components = null;
        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msContolPrecios));
            this.gbDeterminadoKg = new System.Windows.Forms.GroupBox();
            this.txtVentaDeterminado = new ControlesMS.msTextBoxNumerico();
            this.txtCostoDeterminado = new ControlesMS.msTextBoxNumerico();
            this.txtKgDeterminado = new ControlesMS.msTextBoxNumerico();
            this.lblDeterminadoVenta = new System.Windows.Forms.Label();
            this.lblDeterminadoCosto = new System.Windows.Forms.Label();
            this.lblTituloKilos = new System.Windows.Forms.Label();
            this.lblTituloGanancia = new System.Windows.Forms.Label();
            this.lblTituloMargen = new System.Windows.Forms.Label();
            this.lblTituloVenta = new System.Windows.Forms.Label();
            this.lblTituloCosto = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.txtGanancia = new ControlesMS.msTextBoxNumerico();
            this.txtMargen = new ControlesMS.msTextBoxNumerico();
            this.txtVenta = new ControlesMS.msTextBoxNumerico();
            this.txtCosto = new ControlesMS.msTextBoxNumerico();
            this.gbDeterminadoKg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDeterminadoKg
            // 
            resources.ApplyResources(this.gbDeterminadoKg, "gbDeterminadoKg");
            this.gbDeterminadoKg.Controls.Add(this.txtVentaDeterminado);
            this.gbDeterminadoKg.Controls.Add(this.txtCostoDeterminado);
            this.gbDeterminadoKg.Controls.Add(this.txtKgDeterminado);
            this.gbDeterminadoKg.Controls.Add(this.lblDeterminadoVenta);
            this.gbDeterminadoKg.Controls.Add(this.lblDeterminadoCosto);
            this.gbDeterminadoKg.Controls.Add(this.lblTituloKilos);
            this.gbDeterminadoKg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDeterminadoKg.Name = "gbDeterminadoKg";
            this.gbDeterminadoKg.TabStop = false;
            this.gbDeterminadoKg.TextChanged += new System.EventHandler(this.TextosDeterminadosCambia);
            // 
            // txtVentaDeterminado
            // 
            this.txtVentaDeterminado.BackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.txtVentaDeterminado, "txtVentaDeterminado");
            this.txtVentaDeterminado.Name = "txtVentaDeterminado";
            this.txtVentaDeterminado.TabStop = false;
            this.txtVentaDeterminado.Valor = 0D;
            this.txtVentaDeterminado.TextChanged += new System.EventHandler(this.TextosDeterminadosCambia);
            // 
            // txtCostoDeterminado
            // 
            this.txtCostoDeterminado.BackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.txtCostoDeterminado, "txtCostoDeterminado");
            this.txtCostoDeterminado.Name = "txtCostoDeterminado";
            this.txtCostoDeterminado.TabStop = false;
            this.txtCostoDeterminado.Valor = 0D;
            this.txtCostoDeterminado.TextChanged += new System.EventHandler(this.TextosDeterminadosCambia);
            // 
            // txtKgDeterminado
            // 
            this.txtKgDeterminado.BackColor = System.Drawing.Color.LightSkyBlue;
            resources.ApplyResources(this.txtKgDeterminado, "txtKgDeterminado");
            this.txtKgDeterminado.Name = "txtKgDeterminado";
            this.txtKgDeterminado.TabStop = false;
            this.txtKgDeterminado.Valor = 0D;
            this.txtKgDeterminado.TextChanged += new System.EventHandler(this.TextosDeterminadosCambia);
            // 
            // lblDeterminadoVenta
            // 
            resources.ApplyResources(this.lblDeterminadoVenta, "lblDeterminadoVenta");
            this.lblDeterminadoVenta.Name = "lblDeterminadoVenta";
            // 
            // lblDeterminadoCosto
            // 
            resources.ApplyResources(this.lblDeterminadoCosto, "lblDeterminadoCosto");
            this.lblDeterminadoCosto.Name = "lblDeterminadoCosto";
            // 
            // lblTituloKilos
            // 
            resources.ApplyResources(this.lblTituloKilos, "lblTituloKilos");
            this.lblTituloKilos.Name = "lblTituloKilos";
            // 
            // lblTituloGanancia
            // 
            resources.ApplyResources(this.lblTituloGanancia, "lblTituloGanancia");
            this.lblTituloGanancia.Name = "lblTituloGanancia";
            // 
            // lblTituloMargen
            // 
            resources.ApplyResources(this.lblTituloMargen, "lblTituloMargen");
            this.lblTituloMargen.Name = "lblTituloMargen";
            // 
            // lblTituloVenta
            // 
            resources.ApplyResources(this.lblTituloVenta, "lblTituloVenta");
            this.lblTituloVenta.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTituloVenta.Name = "lblTituloVenta";
            // 
            // lblTituloCosto
            // 
            resources.ApplyResources(this.lblTituloCosto, "lblTituloCosto");
            this.lblTituloCosto.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTituloCosto.Name = "lblTituloCosto";
            // 
            // btLimpiar
            // 
            resources.ApplyResources(this.btLimpiar, "btLimpiar");
            this.btLimpiar.BackColor = System.Drawing.Color.LimeGreen;
            this.btLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLimpiar.FlatAppearance.BorderSize = 2;
            this.btLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.TabStop = false;
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // txtGanancia
            // 
            this.txtGanancia.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.txtGanancia, "txtGanancia");
            this.txtGanancia.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Valor = 0D;
            this.txtGanancia.TextChanged += new System.EventHandler(this.TextosCambia);
            // 
            // txtMargen
            // 
            resources.ApplyResources(this.txtMargen, "txtMargen");
            this.txtMargen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtMargen.Name = "txtMargen";
            this.txtMargen.Valor = 0D;
            this.txtMargen.TextChanged += new System.EventHandler(this.TextosCambia);
            // 
            // txtVenta
            // 
            resources.ApplyResources(this.txtVenta, "txtVenta");
            this.txtVenta.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Valor = 0D;
            this.txtVenta.TextChanged += new System.EventHandler(this.TextosCambia);
            // 
            // txtCosto
            // 
            resources.ApplyResources(this.txtCosto, "txtCosto");
            this.txtCosto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Valor = 0D;
            this.txtCosto.TextChanged += new System.EventHandler(this.TextosCambia);
            // 
            // msContolPrecios
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.gbDeterminadoKg);
            this.Controls.Add(this.txtGanancia);
            this.Controls.Add(this.txtMargen);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblTituloGanancia);
            this.Controls.Add(this.lblTituloMargen);
            this.Controls.Add(this.lblTituloVenta);
            this.Controls.Add(this.lblTituloCosto);
            this.Name = "msContolPrecios";
            this.gbDeterminadoKg.ResumeLayout(false);
            this.gbDeterminadoKg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDeterminadoKg;
        private msTextBoxNumerico txtVentaDeterminado;
        private msTextBoxNumerico txtCostoDeterminado;
        private msTextBoxNumerico txtKgDeterminado;
        private System.Windows.Forms.Label lblDeterminadoVenta;
        private System.Windows.Forms.Label lblDeterminadoCosto;
        private System.Windows.Forms.Label lblTituloKilos;
        private msTextBoxNumerico txtGanancia;
        private msTextBoxNumerico txtMargen;
        private msTextBoxNumerico txtVenta;
        private msTextBoxNumerico txtCosto;
        private System.Windows.Forms.Label lblTituloGanancia;
        private System.Windows.Forms.Label lblTituloMargen;
        private System.Windows.Forms.Label lblTituloVenta;
        private System.Windows.Forms.Label lblTituloCosto;
        private System.Windows.Forms.Button btLimpiar;


    }
}
