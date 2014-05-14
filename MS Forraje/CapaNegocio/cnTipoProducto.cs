using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocio
{
    public static class cnTipoProducto
    {
        public static List<ceTipoProducto> GetAll()
        {
            return cdTipoProducto.GetAll();
        }
    }
}
