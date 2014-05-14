using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
namespace ControlesMS.Mascaras
{
    public partial class msProductos : UserControl
    {
        ceProducto produc;
        public msProductos()
        {
            produc = new ceProducto();
            InitializeComponent();
        }
        public msProductos(ceProducto iproducto)
        {
            this.produc = iproducto;
            InitializeComponent();
            
        }

        private void msProductos_Load(object sender, EventArgs e)
        {
            //try
            {
                CargarCombos();
                if (this.produc != null)
                    CargarFormulario();
            }
          //  catch (Exception exc)
            {
                //throw exc;
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                Nuevo_Producto();
                try
                {
                    cnProducto.AgregarNuevo(this.produc);
                    this._validado = true;
                    this.ObjetoProducto = this.produc;
                    Limpiar();
                }
                catch (Exception exc)
                {
                    throw exc;
                }
            }
        }
        public bool Validacion()
        {
            errorProvider.Clear();
            bool resul = true;
            if (!txtCodigo.MaskCompleted)
            {
                resul = false;
                errorProvider.SetError(txtCodigo, "Debe completar el Codigo correctamente");
            }
            if (txtNombre.TextLength < 3)
            {
                resul = false;
                errorProvider.SetError(txtNombre,"Debe completar el campo Nombre");
            }
            if (cmbMarca.SelectedIndex == -1)
            {
                resul = false;
                errorProvider.SetError(cmbMarca, "Selecione alguna Marca");
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                resul = false;
                errorProvider.SetError(cmbTipo, "Seleccione algun Tipo de producto");
            }
            if (cmbAnimal.SelectedIndex == -1)
            {
                resul = false;
                errorProvider.SetError(cmbAnimal, "Seleccione algun Animal");
            }
            if (txtStock.Valor < 1)
            {
                resul = false;
                errorProvider.SetError(txtStock, "Debe ingresar un valor en el Stock");
            }
            return resul;           
        }
        void Nuevo_Producto()
        {
            ceMarca marca = new ceMarca();
            ceTipoProducto tipo = new ceTipoProducto();
            ceAnimal animal = new ceAnimal();
            marca.Codigo = cmbMarca.SelectedValue.ToString();
            tipo.Codigo = cmbTipo.SelectedValue.ToString();
            animal.Codigo = cmbTipo.SelectedValue.ToString();
            this.produc.Codigo = txtCodigo.Text;
            MessageBox.Show(produc.Codigo);
            this.produc.Marca = marca;
            this.produc.TipoProducto = tipo;
            this.produc.Animal = animal;
            this.produc.Nombre = txtNombre.Text;
            this.produc.Stock_Limite = Convert.ToSingle(txtStock.Valor);
            this.produc.Fecha_Ingreso = DateTime.Now;
            this.produc.Fecha_Modificacion = DateTime.Now;
            this.produc.Habilitado = chkHabilitado.Checked;
        }
        void CargarCombos()
        {
            BindingSource bsMarcas = new BindingSource(), bsTipos = new BindingSource(), bsAnimales = new BindingSource();

            string value = "Codigo", display = "Descripcion_Larga";
            bsMarcas.DataSource = cnMarca.GetAll();
            bsTipos.DataSource = cnTipoProducto.GetAll();
            bsAnimales.DataSource = cnAnimal.GetAll();

            cmbMarca.DataSource = bsMarcas;
            cmbMarca.DisplayMember = display;
            cmbMarca.ValueMember = value;
            cmbTipo.DataSource = bsTipos;
            cmbTipo.DisplayMember = display;
            cmbTipo.ValueMember = value;
            cmbAnimal.DataSource = bsAnimales;
            cmbAnimal.DisplayMember = display;
            cmbAnimal.ValueMember = value;
        }
        void CargarFormulario()
        {
            txtCodigo.Text = this.produc.Codigo;
            txtCodigo.Enabled = false;
            txtCodigo.ReadOnly = true;
            txtNombre.Text = this.produc.Nombre;
            txtStock.Valor = this.produc.Stock_Limite;
            cmbMarca.SelectedValue = this.produc.Marca.Codigo;
            cmbMarca.SelectedValue = 1;
        }
        void Limpiar()
        {
            this.txtCodigo.Clear();
            this.txtCodigo.Enabled = true;
            txtCodigo.ReadOnly = false;
            this.txtNombre.Clear();
            cmbMarca.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
            cmbAnimal.SelectedIndex = 0;
            chkHabilitado.Checked = true;
            txtStock.Valor = 1;
            pbEstatusCodigo.Image = null;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.MaskFull)
            {
                if (!cnProducto.Existe(txtCodigo.Text.Replace("-","")))
                    pbEstatusCodigo.Image = Properties.Resources.Apply;
                else
                    pbEstatusCodigo.Image = Properties.Resources.No;
            }
            else
                if (pbEstatusCodigo.Image != null) pbEstatusCodigo.Image = null;
        }
    }
}
