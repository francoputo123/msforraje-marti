namespace MS_Forraje
{
    
    partial class msProductos
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
            this.tabProductos = new System.Windows.Forms.TabControl();
            this.tabPageInicio = new System.Windows.Forms.TabPage();
            this.gbMostrar = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.cmbMostrarTipo = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rMenu1 = new System.Windows.Forms.RadioButton();
            this.tabPageAgregar = new System.Windows.Forms.TabPage();
            this.tabAgregar = new System.Windows.Forms.TabControl();
            this.tabPageArticulos = new System.Windows.Forms.TabPage();
            this.tabPageProductos = new System.Windows.Forms.TabPage();
            this.tabPageProveedores = new System.Windows.Forms.TabPage();
            this.tabPageOtros = new System.Windows.Forms.TabPage();
            this.tabPagePlanilla = new System.Windows.Forms.TabPage();
            this.msArticulo1 = new ControlesMS.msArticulo();
            this.tabProductos.SuspendLayout();
            this.tabPageInicio.SuspendLayout();
            this.gbMostrar.SuspendLayout();
            this.gbAgregar.SuspendLayout();
            this.tabPageAgregar.SuspendLayout();
            this.tabAgregar.SuspendLayout();
            this.tabPageArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProductos
            // 
            this.tabProductos.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabProductos.Controls.Add(this.tabPageInicio);
            this.tabProductos.Controls.Add(this.tabPageAgregar);
            this.tabProductos.Controls.Add(this.tabPagePlanilla);
            this.tabProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProductos.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProductos.Location = new System.Drawing.Point(0, 0);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.SelectedIndex = 0;
            this.tabProductos.Size = new System.Drawing.Size(890, 645);
            this.tabProductos.TabIndex = 1;
            // 
            // tabPageInicio
            // 
            this.tabPageInicio.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPageInicio.Controls.Add(this.gbMostrar);
            this.tabPageInicio.Controls.Add(this.gbAgregar);
            this.tabPageInicio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageInicio.Location = new System.Drawing.Point(4, 41);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInicio.Size = new System.Drawing.Size(882, 600);
            this.tabPageInicio.TabIndex = 0;
            this.tabPageInicio.Text = "INICIO";
            // 
            // gbMostrar
            // 
            this.gbMostrar.Controls.Add(this.radioButton5);
            this.gbMostrar.Controls.Add(this.cmbMostrarTipo);
            this.gbMostrar.Controls.Add(this.radioButton3);
            this.gbMostrar.Controls.Add(this.radioButton4);
            this.gbMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMostrar.Location = new System.Drawing.Point(402, 52);
            this.gbMostrar.Name = "gbMostrar";
            this.gbMostrar.Size = new System.Drawing.Size(194, 198);
            this.gbMostrar.TabIndex = 3;
            this.gbMostrar.TabStop = false;
            this.gbMostrar.Text = "Mostrar...";
            // 
            // radioButton5
            // 
            this.radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton5.BackColor = System.Drawing.Color.OrangeRed;
            this.radioButton5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chartreuse;
            this.radioButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.radioButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(27, 140);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(146, 32);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.Text = "Proveedores";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // cmbMostrarTipo
            // 
            this.cmbMostrarTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbMostrarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMostrarTipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMostrarTipo.FormattingEnabled = true;
            this.cmbMostrarTipo.Items.AddRange(new object[] {
            "Balanceados",
            "Cereales",
            "etc"});
            this.cmbMostrarTipo.Location = new System.Drawing.Point(27, 30);
            this.cmbMostrarTipo.Name = "cmbMostrarTipo";
            this.cmbMostrarTipo.Size = new System.Drawing.Size(146, 27);
            this.cmbMostrarTipo.TabIndex = 5;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.BackColor = System.Drawing.Color.OrangeRed;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chartreuse;
            this.radioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.radioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(27, 102);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(146, 32);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Productos";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.BackColor = System.Drawing.Color.OrangeRed;
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chartreuse;
            this.radioButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.radioButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(27, 64);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(146, 32);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Articulos";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // gbAgregar
            // 
            this.gbAgregar.Controls.Add(this.radioButton2);
            this.gbAgregar.Controls.Add(this.radioButton1);
            this.gbAgregar.Controls.Add(this.rMenu1);
            this.gbAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAgregar.Location = new System.Drawing.Point(115, 52);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(219, 172);
            this.gbAgregar.TabIndex = 2;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar Nuevo...";
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.Color.OrangeRed;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chartreuse;
            this.radioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.radioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(46, 112);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 32);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Proveedor";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.OrangeRed;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chartreuse;
            this.radioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.radioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(46, 74);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(112, 32);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Producto";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // rMenu1
            // 
            this.rMenu1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rMenu1.BackColor = System.Drawing.Color.OrangeRed;
            this.rMenu1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rMenu1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chartreuse;
            this.rMenu1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.rMenu1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.rMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rMenu1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMenu1.Location = new System.Drawing.Point(46, 36);
            this.rMenu1.Name = "rMenu1";
            this.rMenu1.Size = new System.Drawing.Size(112, 32);
            this.rMenu1.TabIndex = 2;
            this.rMenu1.Text = "Articulo";
            this.rMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rMenu1.UseVisualStyleBackColor = false;
            // 
            // tabPageAgregar
            // 
            this.tabPageAgregar.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPageAgregar.Controls.Add(this.tabAgregar);
            this.tabPageAgregar.Location = new System.Drawing.Point(4, 41);
            this.tabPageAgregar.Name = "tabPageAgregar";
            this.tabPageAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgregar.Size = new System.Drawing.Size(882, 600);
            this.tabPageAgregar.TabIndex = 1;
            this.tabPageAgregar.Text = "AGREGAR";
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.tabPageArticulos);
            this.tabAgregar.Controls.Add(this.tabPageProductos);
            this.tabAgregar.Controls.Add(this.tabPageProveedores);
            this.tabAgregar.Controls.Add(this.tabPageOtros);
            this.tabAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAgregar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAgregar.Location = new System.Drawing.Point(3, 3);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.SelectedIndex = 0;
            this.tabAgregar.Size = new System.Drawing.Size(876, 594);
            this.tabAgregar.TabIndex = 0;
            // 
            // tabPageArticulos
            // 
            this.tabPageArticulos.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPageArticulos.Controls.Add(this.msArticulo1);
            this.tabPageArticulos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageArticulos.Location = new System.Drawing.Point(4, 34);
            this.tabPageArticulos.Name = "tabPageArticulos";
            this.tabPageArticulos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArticulos.Size = new System.Drawing.Size(868, 556);
            this.tabPageArticulos.TabIndex = 0;
            this.tabPageArticulos.Text = "Articulos";
            // 
            // tabPageProductos
            // 
            this.tabPageProductos.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPageProductos.Location = new System.Drawing.Point(4, 34);
            this.tabPageProductos.Name = "tabPageProductos";
            this.tabPageProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductos.Size = new System.Drawing.Size(868, 556);
            this.tabPageProductos.TabIndex = 1;
            this.tabPageProductos.Text = "Productos";
            // 
            // tabPageProveedores
            // 
            this.tabPageProveedores.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPageProveedores.Location = new System.Drawing.Point(4, 34);
            this.tabPageProveedores.Name = "tabPageProveedores";
            this.tabPageProveedores.Size = new System.Drawing.Size(868, 556);
            this.tabPageProveedores.TabIndex = 2;
            this.tabPageProveedores.Text = "Proveedores";
            // 
            // tabPageOtros
            // 
            this.tabPageOtros.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPageOtros.Location = new System.Drawing.Point(4, 34);
            this.tabPageOtros.Name = "tabPageOtros";
            this.tabPageOtros.Size = new System.Drawing.Size(868, 556);
            this.tabPageOtros.TabIndex = 4;
            this.tabPageOtros.Text = "Otros";
            // 
            // tabPagePlanilla
            // 
            this.tabPagePlanilla.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPagePlanilla.Location = new System.Drawing.Point(4, 41);
            this.tabPagePlanilla.Name = "tabPagePlanilla";
            this.tabPagePlanilla.Size = new System.Drawing.Size(882, 600);
            this.tabPagePlanilla.TabIndex = 2;
            this.tabPagePlanilla.Text = "PLANILLA";
            // 
            // msArticulo1
            // 
            this.msArticulo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msArticulo1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msArticulo1.Location = new System.Drawing.Point(3, 3);
            this.msArticulo1.Margin = new System.Windows.Forms.Padding(4);
            this.msArticulo1.Name = "msArticulo1";
            this.msArticulo1.Size = new System.Drawing.Size(862, 550);
            this.msArticulo1.TabIndex = 0;
            // 
            // msProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabProductos);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "msProductos";
            this.Size = new System.Drawing.Size(890, 645);
            this.tabProductos.ResumeLayout(false);
            this.tabPageInicio.ResumeLayout(false);
            this.gbMostrar.ResumeLayout(false);
            this.gbAgregar.ResumeLayout(false);
            this.tabPageAgregar.ResumeLayout(false);
            this.tabAgregar.ResumeLayout(false);
            this.tabPageArticulos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProductos;
        private System.Windows.Forms.TabPage tabPageInicio;
        private System.Windows.Forms.GroupBox gbMostrar;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.ComboBox cmbMostrarTipo;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rMenu1;
        private System.Windows.Forms.TabPage tabPageAgregar;
        private System.Windows.Forms.TabControl tabAgregar;
        private System.Windows.Forms.TabPage tabPageArticulos;
        private System.Windows.Forms.TabPage tabPageProductos;
        private System.Windows.Forms.TabPage tabPageProveedores;
        private System.Windows.Forms.TabPage tabPageOtros;
        private System.Windows.Forms.TabPage tabPagePlanilla;
        private ControlesMS.msArticulo msArticulo1;
    }
}
