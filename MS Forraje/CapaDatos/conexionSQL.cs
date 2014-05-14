using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
namespace CapaDatos
{
    public static class conexionSQL
    {
        public static SqlConnection Connection()
        {
            string cadena = CapaDatos.Properties.Settings.Default.base_local.ToString();
            SqlConnection cn = new SqlConnection(cadena);
             return cn;
        }

    }
}
