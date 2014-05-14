using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
    public class ceTipoProducto
    {
        string cod_tipoproducto;
        string descripcion_corta;
        string descripcion_larga;

        public ceTipoProducto()
        {
            descripcion_corta = string.Empty;
            descripcion_larga = string.Empty;
        }

        #region TipoProductos
        public string Codigo
        {
            get { return cod_tipoproducto; }
            set { cod_tipoproducto = value; }
        }
        public string Descripcion_Corta
        {
            get { return descripcion_corta; }
            set { descripcion_corta = value; }
        }
        public string Descripcion_Larga
        {
            get { return descripcion_larga; }
            set { descripcion_larga = value; }
        }
        #endregion

    }
}
