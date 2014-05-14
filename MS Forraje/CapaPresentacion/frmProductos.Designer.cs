namespace CapaPresentacion
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabProductos = new System.Windows.Forms.TabControl();
            this.tabPageInicio = new System.Windows.Forms.TabPage();
            this.gbMostrar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbMostrarTipo = new System.Windows.Forms.ComboBox();
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.btTipoProductos = new System.Windows.Forms.Button();
            this.btNuevaMarca = new System.Windows.Forms.Button();
            this.btNuevoArticulo = new System.Windows.Forms.Button();
            this.btNuevoProducto = new System.Windows.Forms.Button();
            this.tabPageProductos = new System.Windows.Forms.TabPage();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLimiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.marcaDescripcionCortaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDescripcionLargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProductoDescripcionCortaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProductoDescripcionLargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProductos = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btAgregarProducto = new System.Windows.Forms.Button();
            this.tabPageArticulos = new System.Windows.Forms.TabPage();
            this.tabPageOtros = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProductos.SuspendLayout();
            this.tabPageInicio.SuspendLayout();
            this.gbMostrar.SuspendLayout();
            this.gbAgregar.SuspendLayout();
            this.tabPageProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.tabPageInicio);
            this.tabProductos.Controls.Add(this.tabPageProductos);
            this.tabProductos.Controls.Add(this.tabPageArticulos);
            this.tabProductos.Controls.Add(this.tabPageOtros);
            this.tabProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProductos.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProductos.Location = new System.Drawing.Point(0, 0);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.SelectedIndex = 0;
            this.tabProductos.Size = new System.Drawing.Size(820, 451);
            this.tabProductos.TabIndex = 2;
            // 
            // tabPageInicio
            // 
            this.tabPageInicio.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPageInicio.Controls.Add(this.gbMostrar);
            this.tabPageInicio.Controls.Add(this.gbAgregar);
            this.tabPageInicio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageInicio.Location = new System.Drawing.Point(4, 38);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInicio.Size = new System.Drawing.Size(812, 409);
            this.tabPageInicio.TabIndex = 0;
            this.tabPageInicio.Text = "INICIO";
            // 
            // gbMostrar
            // 
            this.gbMostrar.Controls.Add(this.button1);
            this.gbMostrar.Controls.Add(this.button2);
            this.gbMostrar.Controls.Add(this.button3);
            this.gbMostrar.Controls.Add(this.button4);
            this.gbMostrar.Controls.Add(this.cmbMostrarTipo);
            this.gbMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMostrar.Location = new System.Drawing.Point(295, 39);
            this.gbMostrar.Name = "gbMostrar";
            this.gbMostrar.Size = new System.Drawing.Size(187, 295);
            this.gbMostrar.TabIndex = 3;
            this.gbMostrar.TabStop = false;
            this.gbMostrar.Text = "Mostrar...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 61);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tipo de Productos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(40, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "Marca";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(40, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 44);
            this.button3.TabIndex = 10;
            this.button3.Text = "Articulo";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(40, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Producto";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // cmbMostrarTipo
            // 
            this.cmbMostrarTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbMostrarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMostrarTipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMostrarTipo.FormattingEnabled = true;
            this.cmbMostrarTipo.Items.AddRange(new object[] {
            "+ Vendido",
            "- Vendido",
            "Fecha"});
            this.cmbMostrarTipo.Location = new System.Drawing.Point(27, 30);
            this.cmbMostrarTipo.Name = "cmbMostrarTipo";
            this.cmbMostrarTipo.Size = new System.Drawing.Size(146, 27);
            this.cmbMostrarTipo.TabIndex = 5;
            // 
            // gbAgregar
            // 
            this.gbAgregar.Controls.Add(this.btTipoProductos);
            this.gbAgregar.Controls.Add(this.btNuevaMarca);
            this.gbAgregar.Controls.Add(this.btNuevoArticulo);
            this.gbAgregar.Controls.Add(this.btNuevoProducto);
            this.gbAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAgregar.Location = new System.Drawing.Point(56, 39);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(187, 295);
            this.gbAgregar.TabIndex = 2;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar Nuevo...";
            // 
            // btTipoProductos
            // 
            this.btTipoProductos.BackColor = System.Drawing.Color.OrangeRed;
            this.btTipoProductos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btTipoProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btTipoProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btTipoProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTipoProductos.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTipoProductos.Location = new System.Drawing.Point(43, 216);
            this.btTipoProductos.Name = "btTipoProductos";
            this.btTipoProductos.Size = new System.Drawing.Size(112, 61);
            this.btTipoProductos.TabIndex = 8;
            this.btTipoProductos.Text = "Tipo de Productos";
            this.btTipoProductos.UseVisualStyleBackColor = false;
            // 
            // btNuevaMarca
            // 
            this.btNuevaMarca.BackColor = System.Drawing.Color.OrangeRed;
            this.btNuevaMarca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btNuevaMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btNuevaMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btNuevaMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNuevaMarca.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevaMarca.Location = new System.Drawing.Point(43, 160);
            this.btNuevaMarca.Name = "btNuevaMarca";
            this.btNuevaMarca.Size = new System.Drawing.Size(112, 44);
            this.btNuevaMarca.TabIndex = 7;
            this.btNuevaMarca.Text = "Marca";
            this.btNuevaMarca.UseVisualStyleBackColor = false;
            // 
            // btNuevoArticulo
            // 
            this.btNuevoArticulo.BackColor = System.Drawing.Color.OrangeRed;
            this.btNuevoArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btNuevoArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btNuevoArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btNuevoArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNuevoArticulo.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevoArticulo.Location = new System.Drawing.Point(43, 104);
            this.btNuevoArticulo.Name = "btNuevoArticulo";
            this.btNuevoArticulo.Size = new System.Drawing.Size(112, 44);
            this.btNuevoArticulo.TabIndex = 6;
            this.btNuevoArticulo.Text = "Articulo";
            this.btNuevoArticulo.UseVisualStyleBackColor = false;
            // 
            // btNuevoProducto
            // 
            this.btNuevoProducto.BackColor = System.Drawing.Color.OrangeRed;
            this.btNuevoProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btNuevoProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btNuevoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNuevoProducto.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevoProducto.Location = new System.Drawing.Point(43, 44);
            this.btNuevoProducto.Name = "btNuevoProducto";
            this.btNuevoProducto.Size = new System.Drawing.Size(112, 44);
            this.btNuevoProducto.TabIndex = 5;
            this.btNuevoProducto.Text = "Producto";
            this.btNuevoProducto.UseVisualStyleBackColor = false;
            this.btNuevoProducto.Click += new System.EventHandler(this.btNuevoProducto_Click);
            // 
            // tabPageProductos
            // 
            this.tabPageProductos.Controls.Add(this.dgProductos);
            this.tabPageProductos.Controls.Add(this.dateTimePicker2);
            this.tabPageProductos.Controls.Add(this.dateTimePicker1);
            this.tabPageProductos.Controls.Add(this.comboBox1);
            this.tabPageProductos.Controls.Add(this.button5);
            this.tabPageProductos.Controls.Add(this.btAgregarProducto);
            this.tabPageProductos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProductos.Location = new System.Drawing.Point(4, 38);
            this.tabPageProductos.Name = "tabPageProductos";
            this.tabPageProductos.Size = new System.Drawing.Size(812, 409);
            this.tabPageProductos.TabIndex = 1;
            this.tabPageProductos.Text = "PRODUCTOS";
            this.tabPageProductos.UseVisualStyleBackColor = true;
            // 
            // dgProductos
            // 
            this.dgProductos.AutoGenerateColumns = false;
            this.dgProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.fechaIngresoDataGridViewTextBoxColumn,
            this.fechaModificacionDataGridViewTextBoxColumn,
            this.stockLimiteDataGridViewTextBoxColumn,
            this.habilitadoDataGridViewCheckBoxColumn,
            this.marcaDescripcionCortaDataGridViewTextBoxColumn,
            this.marcaDescripcionLargaDataGridViewTextBoxColumn,
            this.tipoProductoDescripcionCortaDataGridViewTextBoxColumn,
            this.tipoProductoDescripcionLargaDataGridViewTextBoxColumn});
            this.dgProductos.DataSource = this.bsProductos;
            this.dgProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgProductos.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgProductos.Location = new System.Drawing.Point(0, 84);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(812, 325);
            this.dgProductos.TabIndex = 11;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "COD";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            this.fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Ingreso";
            this.fechaIngresoDataGridViewTextBoxColumn.HeaderText = "FECHA DE INGRESO";
            this.fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            this.fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Modificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.HeaderText = "FECHA MODIFICADO";
            this.fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            // 
            // stockLimiteDataGridViewTextBoxColumn
            // 
            this.stockLimiteDataGridViewTextBoxColumn.DataPropertyName = "Stock_Limite";
            this.stockLimiteDataGridViewTextBoxColumn.HeaderText = "LIMITE DE STOCK";
            this.stockLimiteDataGridViewTextBoxColumn.Name = "stockLimiteDataGridViewTextBoxColumn";
            // 
            // habilitadoDataGridViewCheckBoxColumn
            // 
            this.habilitadoDataGridViewCheckBoxColumn.DataPropertyName = "Habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.HeaderText = "HABILITADO";
            this.habilitadoDataGridViewCheckBoxColumn.Name = "habilitadoDataGridViewCheckBoxColumn";
            // 
            // marcaDescripcionCortaDataGridViewTextBoxColumn
            // 
            this.marcaDescripcionCortaDataGridViewTextBoxColumn.DataPropertyName = "Marca_DescripcionCorta";
            this.marcaDescripcionCortaDataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.marcaDescripcionCortaDataGridViewTextBoxColumn.Name = "marcaDescripcionCortaDataGridViewTextBoxColumn";
            this.marcaDescripcionCortaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDescripcionLargaDataGridViewTextBoxColumn
            // 
            this.marcaDescripcionLargaDataGridViewTextBoxColumn.DataPropertyName = "Marca_DescripcionLarga";
            this.marcaDescripcionLargaDataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.marcaDescripcionLargaDataGridViewTextBoxColumn.Name = "marcaDescripcionLargaDataGridViewTextBoxColumn";
            this.marcaDescripcionLargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoProductoDescripcionCortaDataGridViewTextBoxColumn
            // 
            this.tipoProductoDescripcionCortaDataGridViewTextBoxColumn.DataPropertyName = "TipoProducto_DescripcionCorta";
            this.tipoProductoDescripcionCortaDataGridViewTextBoxColumn.HeaderText = "TIPO DE PRODUCTO";
            this.tipoProductoDescripcionCortaDataGridViewTextBoxColumn.Name = "tipoProductoDescripcionCortaDataGridViewTextBoxColumn";
            this.tipoProductoDescripcionCortaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoProductoDescripcionLargaDataGridViewTextBoxColumn
            // 
            this.tipoProductoDescripcionLargaDataGridViewTextBoxColumn.DataPropertyName = "TipoProducto_DescripcionLarga";
            this.tipoProductoDescripcionLargaDataGridViewTextBoxColumn.HeaderText = "TIPO DE PRODUCTO";
            this.tipoProductoDescripcionLargaDataGridViewTextBoxColumn.Name = "tipoProductoDescripcionLargaDataGridViewTextBoxColumn";
            this.tipoProductoDescripcionLargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsProductos
            // 
            this.bsProductos.DataSource = typeof(CapaEntidad.ceProducto);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(536, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(141, 26);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+ Vendido",
            "- Vendido",
            "Fecha"});
            this.comboBox1.Location = new System.Drawing.Point(215, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 27);
            this.comboBox1.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.OrangeRed;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(78, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 28);
            this.button5.TabIndex = 7;
            this.button5.Text = "Editar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btAgregarProducto
            // 
            this.btAgregarProducto.BackColor = System.Drawing.Color.OrangeRed;
            this.btAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btAgregarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarProducto.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarProducto.Location = new System.Drawing.Point(3, 3);
            this.btAgregarProducto.Name = "btAgregarProducto";
            this.btAgregarProducto.Size = new System.Drawing.Size(69, 28);
            this.btAgregarProducto.TabIndex = 6;
            this.btAgregarProducto.Text = "Nuevo";
            this.btAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // tabPageArticulos
            // 
            this.tabPageArticulos.Location = new System.Drawing.Point(4, 38);
            this.tabPageArticulos.Name = "tabPageArticulos";
            this.tabPageArticulos.Size = new System.Drawing.Size(812, 409);
            this.tabPageArticulos.TabIndex = 2;
            this.tabPageArticulos.Text = "ARTICULOS";
            this.tabPageArticulos.UseVisualStyleBackColor = true;
            // 
            // tabPageOtros
            // 
            this.tabPageOtros.Location = new System.Drawing.Point(4, 38);
            this.tabPageOtros.Name = "tabPageOtros";
            this.tabPageOtros.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOtros.Size = new System.Drawing.Size(812, 409);
            this.tabPageOtros.TabIndex = 3;
            this.tabPageOtros.Text = "OTROS";
            this.tabPageOtros.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fecha_Ingreso";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha_Ingreso";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha_Modificacion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha_Modificacion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Stock_Limite";
            this.dataGridViewTextBoxColumn7.HeaderText = "Stock_Limite";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Animal";
            this.dataGridViewTextBoxColumn3.HeaderText = "Animal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TipoProducto";
            this.dataGridViewTextBoxColumn4.HeaderText = "TipoProducto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 451);
            this.Controls.Add(this.tabProductos);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.tabProductos.ResumeLayout(false);
            this.tabPageInicio.ResumeLayout(false);
            this.gbMostrar.ResumeLayout(false);
            this.gbAgregar.ResumeLayout(false);
            this.tabPageProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProductos;
        private System.Windows.Forms.TabPage tabPageInicio;
        private System.Windows.Forms.GroupBox gbMostrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbMostrarTipo;
        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.Button btTipoProductos;
        private System.Windows.Forms.Button btNuevaMarca;
        private System.Windows.Forms.Button btNuevoArticulo;
        private System.Windows.Forms.Button btNuevoProducto;
        private System.Windows.Forms.TabPage tabPageProductos;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btAgregarProducto;
        private System.Windows.Forms.TabPage tabPageArticulos;
        private System.Windows.Forms.TabPage tabPageOtros;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource bsProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLimiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDescripcionCortaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDescripcionLargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProductoDescripcionCortaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProductoDescripcionLargaDataGridViewTextBoxColumn;
    }
}