using CapaEntidad;
namespace CapaPresentacion
{
    partial class frmEmergente
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
            ceProducto _produc = new ceProducto();
            _produc.Codigo = "AAA123";
            _produc.Nombre = "GELVE";
            _produc.Marca.Codigo = "BB11";
            this.msProductos1 = new ControlesMS.Mascaras.msProductos(_produc);
            this.SuspendLayout();
            // 
            // msProductos1
            // 
            this.msProductos1.Location = new System.Drawing.Point(12, 12);
            this.msProductos1.Name = "msProductos1";
            this.msProductos1.ObjetoProducto = null;
            this.msProductos1.Size = new System.Drawing.Size(399, 259);
            this.msProductos1.TabIndex = 0;
            // 
            // frmEmergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 343);
            this.Controls.Add(this.msProductos1);
            this.Name = "frmEmergente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmergente";
            this.Load += new System.EventHandler(this.frmEmergente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesMS.Mascaras.msProductos msProductos1;
    }
}