using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Esta clase esta encargada de realizar los calculos de los msTextBoxNumericos*/
namespace ControlesMS
{
    class cCalculos
    {
        double _valcosto,_valventa;
        msTextBoxNumerico _costo, _venta, _ganancia, _margen;
        public cCalculos()
        {
            this.valCosto = 0;
            this.valVenta = 0;
        }
        public cCalculos(msTextBoxNumerico costo, msTextBoxNumerico venta, msTextBoxNumerico ganancia, msTextBoxNumerico margen)
        {
            this.Costo = costo;
            this.Venta = venta;
            this.Ganancia = ganancia;
            this.Margen = margen;
            Precios_Calculo();
            Redondeo();
        }
        public cCalculos(double unidad, msTextBoxNumerico kilos, msTextBoxNumerico costodet, msTextBoxNumerico ventadet, msTextBoxNumerico costo, msTextBoxNumerico venta, msTextBoxNumerico ganancia, msTextBoxNumerico margen)
        {
            this.Costo = costo;
            this.Venta = venta;
            this.Ganancia = ganancia;
            this.Margen = margen;
            PreciosBolsa_Calculos(kilos, costodet, ventadet, unidad);
            Redondeo();
        }
        #region Propiedades
        public msTextBoxNumerico Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }
        public msTextBoxNumerico Venta
        {
            get { return _venta; }
            set { _venta = value; }
        }
        public msTextBoxNumerico Ganancia
        {
            get { return _ganancia; }
            set { _ganancia = value; }
        }
        public msTextBoxNumerico Margen
        {
            get { return _margen; }
            set { _margen = value; }
        }
        public double valCosto
        {
            get { return _valcosto; }
            set { _valcosto = value; }
        }
        public double valVenta
        {
            get { return _valventa; }
            set { _valventa = value; }
        }
        #endregion

        #region Metodos en donde decide que calculos ejecutar
        private void Redondeo()
        {
            this.valCosto = this.Costo.Valor;
            this.valVenta = this.Venta.Valor;
            if (!this.Costo.Focused)
                this.Costo.Valor = Math.Round(Costo.Valor, 2);
            if (!this.Venta.Focused)
                this.Venta.Valor = Math.Round(Venta.Valor, 2);
            if (!this.Ganancia.Focused)
                this.Ganancia.Valor = Math.Round(Ganancia.Valor, 2);
            if (!this.Margen.Focused)
                this.Margen.Valor = Math.Round(Margen.Valor, 2);
        }
        private void Precios_Calculo()
        {
            if (this.Costo.Valor == 0)
            {
                this.Costo.Focus();
                return;
            }
            if (this.Costo.Focused && (this.Venta.Valor != 0 || this.Ganancia.Valor != 0 || this.Margen.Valor != 0))
            {
                #region Cuando se cambia el txtCosto hay que actualizar todo!-
                if (this.Venta.Valor != 0)
                {
                    this.Ganancia.Valor = Calc_Ganancia(this.Costo.Valor, this.Venta.Valor);
                    this.Margen.Valor = Calc_Margen(this.Venta.Valor, this.Costo.Valor);
                }
                else if (this.Ganancia.Valor != 0)
                {
                    this.Venta.Valor = Calc_Venta(this.Costo.Valor, this.Ganancia.Valor, 0);
                    this.Margen.Valor = Calc_Margen(this.Venta.Valor, this.Costo.Valor);
                }
                else if (this.Costo.Valor != 0)
                {
                    this.Venta.Valor = Calc_Venta(this.Costo.Valor, 0, this.Margen.Valor);
                    this.Ganancia.Valor = Calc_Ganancia(this.Costo.Valor, this.Venta.Valor);
                }
                #endregion
            }
            if (this.Venta.Focused)
            {
                this.Ganancia.Valor = Calc_Ganancia(this.Costo.Valor, this.Venta.Valor);
                this.Margen.Valor = Calc_Margen(this.Venta.Valor, this.Costo.Valor);
                return;
            }
            else if (this.Ganancia.Focused)
            {
                this.Venta.Valor = Calc_Venta(this.Costo.Valor, this.Ganancia.Valor, 0);
                this.Margen.Valor = Calc_Margen(this.Venta.Valor, this.Costo.Valor);
                return;
            }
            else if (Margen.Focused)
            {
                Venta.Valor = Calc_Venta(Costo.Valor, 0, Margen.Valor);
                Ganancia.Valor = Calc_Ganancia(Costo.Valor, Venta.Valor);
                //tventa.Valor = ((tmargen.Valor / 100) + 1) * tcosto.Valor;
                return;
            }
        }
        private void PreciosBolsa_Calculos( msTextBoxNumerico tkilos,  msTextBoxNumerico tcosto,  msTextBoxNumerico tventa, double unidad)
        {
            if (tkilos.Valor == 0)
            {
                tkilos.Focus();
                return;
            }
            if (tcosto.Valor != 0 && tventa.Valor != 0)
            {
                this.Costo.Valor = (tcosto.Valor / tkilos.Valor) / unidad;
                this.Venta.Valor = (tventa.Valor / tkilos.Valor) / unidad;
                this.Ganancia.Valor = Calc_Ganancia(Costo.Valor, Venta.Valor);
                this.Margen.Valor = Calc_Margen(Venta.Valor, Costo.Valor);
            }
        }
        #endregion

        #region Calculos de precios
        private double Calc_Ganancia(double costo, double venta)
        {
            return venta - costo;
        }
        private double Calc_Margen(double venta, double costo)
        {
            return ((venta / costo) - 1) * 100;
        }
        private double Calc_Venta(double costo, double ganancia, double margen)
        {
            if (margen == 0)
                return costo + ganancia;
            else
                return ((margen / 100) + 1) * costo;
        }
        #endregion

    }

}
