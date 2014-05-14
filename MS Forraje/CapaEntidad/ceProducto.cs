using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace CapaEntidad
{
    public class ceProducto
    {
        #region Atributos
        string _cod_producto;
        string _nombre_producto;
        ceMarca _marca;
        ceAnimal _animal;
        ceTipoProducto _tipoproducto;
        DateTime _fecha_ingreso;
        DateTime _fecha_modificacion;
        float _stock_limite;
        bool _habilitado;
        #endregion

        #region Constructores
        public ceProducto()
        {
            this._cod_producto = string.Empty;
            this._marca = new ceMarca();
            this._animal = new ceAnimal();
            this._tipoproducto = new ceTipoProducto();
            this._nombre_producto = string.Empty;
            this._fecha_ingreso = DateTime.MinValue;
            this._fecha_modificacion = DateTime.MinValue;
            this._stock_limite = 0;
            this._habilitado = false;
        }
        public ceProducto(int iid_producto, string inombre, ceMarca imarca, ceAnimal ianimal, ceTipoProducto itipoproducto, DateTime ifecha_ingreso, DateTime ifecha_modificacion, float istock_limite, bool ihabilitado)
        {

        }
        #endregion


        #region Encapsulamiento
        public string Codigo
        {
            get { return _cod_producto; }
            set { _cod_producto = value.Replace("-",""); }
        }
        public string Nombre
        {
            get { return _nombre_producto; }
            set {_nombre_producto = value.Trim().ToUpper(); }
        }
        public ceMarca Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public ceTipoProducto TipoProducto
        {
            get { return _tipoproducto; }
            set { _tipoproducto = value; }
        }
        public ceAnimal Animal
        {
            get { return _animal; }
            set { _animal = value; }
        }
        public DateTime Fecha_Ingreso
        {
            get { return _fecha_ingreso; }
            set { _fecha_ingreso = value; }
        }
        public DateTime Fecha_Modificacion
        {
            get { return _fecha_modificacion; }
            set { _fecha_modificacion = value; }
        }
        public float Stock_Limite
        {
            get { return _stock_limite; }
            set { _stock_limite = value; }
        }
        public bool Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }
        #region Propiedades de Objetos Aninados a resolver mas adelante
        public string Animal_DescripcionCorta
        {
            get { return Animal.Descripcion_Corta; }
        }
        public string Animal_DescripcionLarga
        {
            get { return Animal.Descripcion_Larga; }
        }
        public string Marca_DescripcionCorta
        {
            get { return Marca.Descripcion_Corta; }
        }
        public string Marca_DescripcionLarga
        {
            get { return Marca.Descripcion_Larga; }
        }
        public string TipoProducto_DescripcionCorta
        {
            get { return TipoProducto.Descripcion_Corta; }
        }
        public string TipoProducto_DescripcionLarga
        {
            get { return TipoProducto.Descripcion_Larga; }
        }
        #endregion
        #endregion
    }
}
