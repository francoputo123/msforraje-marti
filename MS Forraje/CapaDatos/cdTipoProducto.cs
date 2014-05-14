using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public static class cdTipoProducto
    {
        public static List<ceTipoProducto> GetAll()
        {
            List<ceTipoProducto> lista = new List<ceTipoProducto>();
            using (SqlConnection con = conexionSQL.Connection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("LEER_TIPOPRODUCTOS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Cargar(dr));
                }
            }
            return lista;
        }
        private static ceTipoProducto Cargar(IDataReader reader)
        {
            ceTipoProducto nuevo = new ceTipoProducto();
            nuevo.Codigo = Convert.ToString(reader["cod_tipoproducto"]);
            nuevo.Descripcion_Corta = Convert.ToString(reader["tipoproductos.descripcion_corta"]);
            nuevo.Descripcion_Larga = Convert.ToString(reader["tipoproductos.descripcion_larga"]);
            return nuevo;
        }
    }
}
