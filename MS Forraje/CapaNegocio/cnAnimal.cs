using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocio
{
    public static class cnAnimal
    {
        public static List<ceAnimal> GetAll()
        {
            return cdAnimal.GetAll();
        }
    }
}
