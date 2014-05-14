namespace ControlesMS
{
    partial class msArticulo
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
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
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.panelArticulo = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.cmbSeleccionarUnidad = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarUnidad = new System.Windows.Forms.Label();
            this.msPrecios = new ControlesMS.msContolPrecios();
            this.txtCantidadUnidad = new ControlesMS.msTextBoxNumerico();
            this.lblCantidadUnidad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.btEjecutar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumArticulo = new System.Windows.Forms.Label();
            this.panelArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.txtNombreProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(84, 29);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(280, 27);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblProducto.Location = new System.Drawing.Point(112, 0);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(152, 26);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Buscar Producto";
            // 
            // panelArticulo
            // 
            this.panelArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelArticulo.Controls.Add(this.txtDescripcion);
            this.panelArticulo.Controls.Add(this.lblUnidades);
            this.panelArticulo.Controls.Add(this.cmbSeleccionarUnidad);
            this.panelArticulo.Controls.Add(this.lblSeleccionarUnidad);
            this.panelArticulo.Controls.Add(this.msPrecios);
            this.panelArticulo.Controls.Add(this.txtCantidadUnidad);
            this.panelArticulo.Controls.Add(this.lblCantidadUnidad);
            this.panelArticulo.Controls.Add(this.lblDescripcion);
            this.panelArticulo.Controls.Add(this.chkHabilitado);
            this.panelArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelArticulo.ForeColor = System.Drawing.Color.Black;
            this.panelArticulo.Location = new System.Drawing.Point(13, 64);
            this.panelArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelArticulo.Name = "panelArticulo";
            this.panelArticulo.Size = new System.Drawing.Size(545, 390);
            this.panelArticulo.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.txtDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtDescripcion.Location = new System.Drawing.Point(32, 40);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(280, 27);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidades.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUnidades.Location = new System.Drawing.Point(160, 124);
            this.lblUnidades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(40, 26);
            this.lblUnidades.TabIndex = 18;
            this.lblUnidades.Text = "kgs";
            // 
            // cmbSeleccionarUnidad
            // 
            this.cmbSeleccionarUnidad.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmbSeleccionarUnidad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeleccionarUnidad.FormattingEnabled = true;
            this.cmbSeleccionarUnidad.Location = new System.Drawing.Point(265, 113);
            this.cmbSeleccionarUnidad.Name = "cmbSeleccionarUnidad";
            this.cmbSeleccionarUnidad.Size = new System.Drawing.Size(79, 37);
            this.cmbSeleccionarUnidad.TabIndex = 5;
            // 
            // lblSeleccionarUnidad
            // 
            this.lblSeleccionarUnidad.AutoSize = true;
            this.lblSeleccionarUnidad.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarUnidad.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSeleccionarUnidad.Location = new System.Drawing.Point(270, 71);
            this.lblSeleccionarUnidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionarUnidad.Name = "lblSeleccionarUnidad";
            this.lblSeleccionarUnidad.Size = new System.Drawing.Size(74, 26);
            this.lblSeleccionarUnidad.TabIndex = 16;
            this.lblSeleccionarUnidad.Text = "Unidad";
            // 
            // msPrecios
            // 
            this.msPrecios.BackColor = System.Drawing.Color.LightSeaGreen;
            this.msPrecios.BackColorBoton = System.Drawing.Color.LimeGreen;
            this.msPrecios.BackColorTextBox = System.Drawing.Color.LightSkyBlue;
            this.msPrecios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msPrecios.Font = new System.Drawing.Font("Calibri", 12F);
            this.msPrecios.Location = new System.Drawing.Point(32, 157);
            this.msPrecios.Margin = new System.Windows.Forms.Padding(4);
            this.msPrecios.Name = "msPrecios";
            this.msPrecios.Permitir_Determinado = true;
            this.msPrecios.Size = new System.Drawing.Size(483, 212);
            this.msPrecios.TabIndex = 6;
            this.msPrecios.Unidad = 1D;
            // 
            // txtCantidadUnidad
            // 
            this.txtCantidadUnidad.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtCantidadUnidad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadUnidad.Location = new System.Drawing.Point(56, 113);
            this.txtCantidadUnidad.MaxLength = 5;
            this.txtCantidadUnidad.Name = "txtCantidadUnidad";
            this.txtCantidadUnidad.Size = new System.Drawing.Size(87, 37);
            this.txtCantidadUnidad.TabIndex = 4;
            this.txtCantidadUnidad.Text = "1";
            this.txtCantidadUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidadUnidad.Valor = 1D;
            this.txtCantidadUnidad.Leave += new System.EventHandler(this.txtCantidadUnidad_Leave);
            // 
            // lblCantidadUnidad
            // 
            this.lblCantidadUnidad.AutoSize = true;
            this.lblCantidadUnidad.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadUnidad.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCantidadUnidad.Location = new System.Drawing.Point(55, 71);
            this.lblCantidadUnidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadUnidad.Name = "lblCantidadUnidad";
            this.lblCantidadUnidad.Size = new System.Drawing.Size(88, 26);
            this.lblCantidadUnidad.TabIndex = 13;
            this.lblCantidadUnidad.Text = "Cantidad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDescripcion.Location = new System.Drawing.Point(84, 10);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(185, 26);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Agregar Descripcion";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Checked = true;
            this.chkHabilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHabilitado.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabilitado.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.chkHabilitado.Location = new System.Drawing.Point(347, 40);
            this.chkHabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(119, 30);
            this.chkHabilitado.TabIndex = 3;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // btEjecutar
            // 
            this.btEjecutar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEjecutar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btEjecutar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btEjecutar.FlatAppearance.BorderSize = 2;
            this.btEjecutar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btEjecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEjecutar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEjecutar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btEjecutar.Location = new System.Drawing.Point(226, 473);
            this.btEjecutar.Name = "btEjecutar";
            this.btEjecutar.Size = new System.Drawing.Size(100, 36);
            this.btEjecutar.TabIndex = 7;
            this.btEjecutar.TabStop = false;
            this.btEjecutar.Text = "Agregar";
            this.btEjecutar.UseVisualStyleBackColor = false;
            this.btEjecutar.Click += new System.EventHandler(this.btEjecutar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(391, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(52, 27);
            this.textBox1.TabIndex = 4;
            // 
            // lblNumArticulo
            // 
            this.lblNumArticulo.AutoSize = true;
            this.lblNumArticulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumArticulo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNumArticulo.Location = new System.Drawing.Point(386, 0);
            this.lblNumArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumArticulo.Name = "lblNumArticulo";
            this.lblNumArticulo.Size = new System.Drawing.Size(106, 26);
            this.lblNumArticulo.TabIndex = 5;
            this.lblNumArticulo.Text = "N° Articulo";
            // 
            // msArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNumArticulo);
            this.Controls.Add(this.btEjecutar);
            this.Controls.Add(this.panelArticulo);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblProducto);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "msArticulo";
            this.Size = new System.Drawing.Size(594, 523);
            this.panelArticulo.ResumeLayout(false);
            this.panelArticulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Panel panelArticulo;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Label lblDescripcion;
        private msTextBoxNumerico txtCantidadUnidad;
        private System.Windows.Forms.Label lblCantidadUnidad;
        private msContolPrecios msPrecios;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.ComboBox cmbSeleccionarUnidad;
        private System.Windows.Forms.Label lblSeleccionarUnidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btEjecutar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumArticulo;
    }
}
