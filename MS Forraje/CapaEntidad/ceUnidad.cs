using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
    public class ceUnidad
    {
        private int _idunidad;
        private string _descripcion_corta;
        private string _descripcion_larga;

        public ceUnidad()
        {

        }
        public ceUnidad(int iIdunidad, string sDesc_corta, string sDesc_larga)
        {
            this.IdUnidad = iIdunidad;
            this.Descripcion_Corta = sDesc_corta;
            this.Descripcion_Larga = sDesc_larga;
        }

        public int IdUnidad
        {
            get { return _idunidad; }
            set { _idunidad = value; }
        }
        public string Descripcion_Corta
        {
            get { return _descripcion_corta; }
            set { _descripcion_corta = value; }
        }
        public string Descripcion_Larga
        {
            get { return _descripcion_larga; }
            set { _descripcion_larga = value; }
        }
    }
}
