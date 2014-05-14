using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class cdMarca
    {
        public static List<ceMarca> GetAll()
        {
            List<ceMarca> lista = new List<ceMarca>();
            using (SqlConnection con = conexionSQL.Connection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("LEER_MARCAS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Cargar(dr));
                }
            }
            return lista;
        }
        private static ceMarca Cargar(IDataReader reader)
        {
            ceMarca nuevo = new ceMarca();
            nuevo.Codigo = Convert.ToString(reader["cod_marca"]);
            nuevo.Descripcion_Corta = Convert.ToString(reader["marcas.descripcion_corta"]);
            nuevo.Descripcion_Larga = Convert.ToString(reader["marcas.descripcion_larga"]);
            return nuevo;
        }
    }
}
