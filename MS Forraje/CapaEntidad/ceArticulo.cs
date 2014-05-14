using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CapaEntidad
{
    public class ceArticulo
    {
        ceProducto _producto;
        int _idarticulo;
        string _descripcion;
        ceUnidad _unidad;
        bool _habilitado;
        DateTime _fecha_ingreso;
        DateTime _fecha_modificacion;
        public ceArticulo()
        {
            _producto = new ceProducto();
            _idarticulo = 0;
            _descripcion = "";
            _unidad = new ceUnidad();
            _habilitado = true;
            _fecha_ingreso = DateTime.MinValue;
            _fecha_modificacion = DateTime.MinValue;
        }
        public ceArticulo(int iIdproducto, string sDescripcion, double iCantunidad, DateTime dFecha, bool bHabilitado, double dCosto, double dVenta)
        {

            
        }
        #region Propiedades
        public int IdArticulo
        {
            get { return _idarticulo; }
            set { _idarticulo = value; }
        }
        public ceProducto Producto_Art
        {
            get { return _producto; }
            set { _producto = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
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
        public ceUnidad Unidad_Art
        {
            get { return _unidad; }
            set { _unidad = value; }
        }
        public bool Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = true; }
        }
        #endregion // propiedades


    }
}
