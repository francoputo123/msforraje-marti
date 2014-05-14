using System.ComponentModel;
using System.Windows.Forms;
using CapaEntidad;
namespace ControlesMS.Mascaras
{
    partial class msProductos
    {
        private bool _validado;
        private ceProducto _productointerno;
        [DisplayName("ObjetoProducto")]
        [Description("Objeto Producto que contiene los valoers del formulario")]
        [Category("Objetos")]
        public ceProducto ObjetoProducto
        {
            get { return _productointerno; }
            set { _productointerno = value; }
         }
        [DisplayName("Validado")]
        [Description("True si fue validado, falso si puto el que lee")]
        [Category("Objetos")]
        public bool Validado
        { get { return _validado; } }


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
            this.components = new System.ComponentModel.Container();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtStock = new ControlesMS.msTextBoxNumerico();
            this.pbEstatusCodigo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstatusCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmbAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAnimal.DisplayMember = "Codigo";
            this.cmbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAnimal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(290, 96);
            this.cmbAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(84, 26);
            this.cmbAnimal.TabIndex = 4;
            this.cmbAnimal.ValueMember = "Codigo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipo.DisplayMember = "Codigo";
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(144, 96);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(124, 26);
            this.cmbTipo.TabIndex = 3;
            this.cmbTipo.ValueMember = "Codigo";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAnimal.Location = new System.Drawing.Point(305, 74);
            this.lblAnimal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(58, 18);
            this.lblAnimal.TabIndex = 37;
            this.lblAnimal.Text = "ANIMAL";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Checked = true;
            this.chkHabilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHabilitado.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabilitado.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.chkHabilitado.Location = new System.Drawing.Point(217, 164);
            this.chkHabilitado.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(107, 27);
            this.chkHabilitado.TabIndex = 6;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(25, 33);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Mask = ">LLL-999";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(58, 26);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStock.Location = new System.Drawing.Point(70, 144);
            this.lblStock.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(91, 18);
            this.lblStock.TabIndex = 34;
            this.lblStock.Text = "STOCK LIMITE";
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTipoProducto.Location = new System.Drawing.Point(150, 74);
            this.lblTipoProducto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(109, 18);
            this.lblTipoProducto.TabIndex = 33;
            this.lblTipoProducto.Text = "TIPO PRODUCTO";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMarca.Location = new System.Drawing.Point(25, 74);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(54, 18);
            this.lblMarca.TabIndex = 32;
            this.lblMarca.Text = "MARCA";
            // 
            // cmbMarca
            // 
            this.cmbMarca.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmbMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMarca.DisplayMember = "Codigo";
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMarca.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(7, 96);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(110, 26);
            this.cmbMarca.TabIndex = 2;
            this.cmbMarca.ValueMember = "Codigo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCodigo.Location = new System.Drawing.Point(25, 11);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 18);
            this.lblCodigo.TabIndex = 28;
            this.lblCodigo.Text = "CODIGO";
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAceptar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAceptar.FlatAppearance.BorderSize = 2;
            this.btAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAceptar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btAceptar.Location = new System.Drawing.Point(135, 201);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(133, 41);
            this.btAceptar.TabIndex = 6;
            this.btAceptar.TabStop = false;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(135, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(239, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.CharacterCasing = CharacterCasing.Upper;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNombre.Location = new System.Drawing.Point(185, 11);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(135, 18);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "NOMBRE PRODUCTO";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtStock.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(71, 166);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.MaxLength = 5;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(87, 26);
            this.txtStock.TabIndex = 5;
            this.txtStock.Text = "1";
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStock.Valor = 1D;
            // 
            // pbEstatusCodigo
            // 
            this.pbEstatusCodigo.Location = new System.Drawing.Point(91, 33);
            this.pbEstatusCodigo.Name = "pbEstatusCodigo";
            this.pbEstatusCodigo.Size = new System.Drawing.Size(26, 26);
            this.pbEstatusCodigo.TabIndex = 38;
            this.pbEstatusCodigo.TabStop = false;
            // 
            // msProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbEstatusCodigo);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.chkHabilitado);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "msProductos";
            this.Size = new System.Drawing.Size(412, 256);
            this.Load += new System.EventHandler(this.msProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstatusCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private msTextBoxNumerico txtStock;
        private ErrorProvider errorProvider;
        private PictureBox pbEstatusCodigo;
    }
}
