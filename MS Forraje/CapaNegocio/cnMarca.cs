using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocio
{
    public static class cnMarca
    {
        public static List<ceMarca> GetAll()
        {
            return cdMarca.GetAll();
        }
        public static bool Existe(string codigo)
        {
            return cdProducto.Existe(codigo);
        }
    }
}
