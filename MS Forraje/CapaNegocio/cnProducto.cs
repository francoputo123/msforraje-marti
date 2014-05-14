using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public static class cnProducto
    {
        public static List<ceProducto> GetAll()
        {
            return cdProducto.GetAll();
        }
        public static bool Existe(string codigo)
        {
            return cdProducto.Existe(codigo);
        }
        public static ceProducto AgregarNuevo(ceProducto nuevo)
        {
            return cdProducto.AgregarNuevo(nuevo);
        }
        public static bool Validacion(ref ceProducto producto, out string msj_error)
        {
            bool resul=true;
            msj_error = "";
            producto.Codigo = producto.Codigo.Replace("-", "");
            producto.Nombre = producto.Nombre.Trim();

            if (producto.Codigo.Length < 6)
            {
                resul = false;
                msj_error = "Debe completar el Codigo:";
            }
            if (producto.Codigo.Length < 3)
            {
                resul = false;
                msj_error += "Debe completar el Nombre:";
            }
            if (producto.Marca.Codigo == null || producto.Marca.Codigo == "")
            {
                resul = false;
                msj_error += "Complete una marca del producto:";
            }
            if (producto.TipoProducto.Codigo == null || producto.TipoProducto.Codigo=="")
            {
                resul = false;
                msj_error += "Debe completar un tipo de producto del producto :";
            }
            if (producto.Animal.Codigo == null || producto.Animal.Codigo =="")
            {
                resul = false;
                msj_error += "Debe completar un animal del producto:";
            }
            if (producto.Stock_Limite < 1)
            {
                resul = false;
                msj_error += "Debe ingresar un valor de Stock valido:";
            }

            return resul;
        }
    }
}
