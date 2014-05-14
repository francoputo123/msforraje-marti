using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
    public class ceAnimal
    {


        public ceAnimal()
        {
            this.Codigo = string.Empty;
            this.Descripcion_Corta = string.Empty;
            this.Descripcion_Larga = string.Empty;
        }

        #region Encapsulamiento
        public string Codigo
        {get;set;}
        public string Descripcion_Corta
        { get; set; }
        public string Descripcion_Larga
        { get; set; }
        #endregion
    }
}
