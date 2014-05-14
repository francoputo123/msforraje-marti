using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
namespace CapaDatos
{
    public static class cdAnimal
    {
        public static List<ceAnimal> GetAll()
        {
            List<ceAnimal> lista = new List<ceAnimal>();
            using (SqlConnection con = conexionSQL.Connection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("LEER_ANIMALES", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Cargar(dr));
                }
            }
            return lista;
        }
        private static ceAnimal Cargar(IDataReader reader)
        {
            ceAnimal nuevo = new ceAnimal();
            nuevo.Codigo = Convert.ToString(reader["cod_animal"]);
            nuevo.Descripcion_Corta = Convert.ToString(reader["animales.descripcion_corta"]);
            nuevo.Descripcion_Larga = Convert.ToString(reader["animales.descripcion_larga"]);
            return nuevo;
        }
    }
}
