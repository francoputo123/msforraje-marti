using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
/* msTextBoxNumerico es un control de Windows Forms modificado para la practica
utilizacion solamente con numeros, no permite otros caracteres */
namespace ControlesMS
{
    public partial class msTextBoxNumerico : TextBox
    { 
        public msTextBoxNumerico() // constructor
        {
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            
        }

        #region Propiedades del Control
        [DisplayName("Valor")]
        [Description("Valor numerico double de la caja de texto.")]
        public double Valor // Devuelve en double el string Text del contenido del a caja de texto
        {
            get
            {
                try
                {
                    double.Parse(Text);
                    return Convert.ToDouble(Text);
                }
                catch { return 0; }
            }
            set
            {
                try
                { Text = Convert.ToString(value); }
                catch
                { return; }
            }
        }
        #endregion

        #region Metodos del Control Teclas
        private bool TeclasExc(KeyEventArgs e) // Es solamente un conjunto de condiciones que se agregan despues al if del keydown
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Execute || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Delete)
                return true;
            else
                return false;
        }
        protected override void OnKeyDown(KeyEventArgs e) //Cuando se presiona una tecla, permite solo numeros y coma
        {
            if (!(e.KeyData >= Keys.D0 && e.KeyData <= Keys.D9 || (e.KeyValue == 188 && Text.Contains(',') == false || TeclasExc(e))))
            {
                e.SuppressKeyPress = true;
                return;
            }
            base.OnKeyDown(e);
        }
        protected override void OnLeave(EventArgs e) //Evento cuando se pierde el foco del control: si hay una coma en la primera o ultima posicion, agrega un 0
        {
            if (this.Text.Contains(',') == true)
            {
                char[] letras = this.Text.ToCharArray();
                if (letras[0] == ',')
                    this.Text = this.Text.Insert(0, "0");
                else if (letras[letras.Length - 1] == ',')
                    this.Text = this.Text.Insert(letras.Length, "0");
            }
            this.Valor = Math.Round(this.Valor,2); //redondea en dos decimales
            base.OnLeave(e);
        }
        #endregion
    }//clase
}
                                                        //////////////
                                                        //Ariel Marti//
                                                        //////////////