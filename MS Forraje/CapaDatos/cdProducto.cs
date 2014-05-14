using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidad;
namespace CapaDatos
{
    public class cdProducto
    {
        public static List<ceProducto> GetAll()
        {
            List<ceProducto> lista = new List<ceProducto>();
            using (SqlConnection con = conexionSQL.Connection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("LEER_PRODUCTOS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(Cargar(dr));
                }
            }
            return lista;
        }
        public static bool Existe(string codigo)
        {
            int record = 0;
            using (SqlConnection con = conexionSQL.Connection())
            {

                con.Open();
                SqlCommand cm = new SqlCommand("PRODUCTOBY_COD", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@cod", codigo);
                record = Convert.ToInt32(cm.ExecuteScalar());
            }
            return record > 0;
        }
        public static ceProducto AgregarNuevo(ceProducto nuevo)
        {
            using (SqlConnection con = conexionSQL.Connection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("PRODUCTO_ADD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codproducto", nuevo.Codigo);
                cmd.Parameters.AddWithValue("@codmarca", nuevo.Marca.Codigo);
                cmd.Parameters.AddWithValue("@codtipoproducto", nuevo.TipoProducto.Codigo);
                cmd.Parameters.AddWithValue("@codanimal", nuevo.Animal.Codigo);
                cmd.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                cmd.Parameters.AddWithValue("@ingreso", nuevo.Fecha_Ingreso);
                cmd.Parameters.AddWithValue("@modificacion", nuevo.Fecha_Modificacion);
                cmd.Parameters.AddWithValue("@stock", nuevo.Stock_Limite);
                cmd.Parameters.AddWithValue("@habilitado", nuevo.Habilitado);
                cmd.ExecuteNonQuery();
            }
            return nuevo;
        }
        private static ceProducto Cargar(IDataReader reader)
        {
            ceProducto nuevo = new ceProducto();
            ceAnimal animal = new ceAnimal();
            ceTipoProducto tipo = new ceTipoProducto();
            ceMarca marca = new ceMarca();

            animal.Codigo = Convert.ToString(reader["cod_animal"]);
            animal.Descripcion_Corta = Convert.ToString(reader["animales.descripcion_corta"]);
            animal.Descripcion_Larga = Convert.ToString(reader["animales.descripcion_larga"]);

            tipo.Codigo = Convert.ToString(reader["cod_tipoproducto"]);
            tipo.Descripcion_Corta = Convert.ToString(reader["tipoproductos.descripcion_corta"]);
            tipo.Descripcion_Larga = Convert.ToString(reader["tipoproductos.descripcion_larga"]);

            marca.Codigo = Convert.ToString(reader["cod_marca"]);
            marca.Descripcion_Corta = Convert.ToString(reader["marcas.descripcion_corta"]);
            marca.Descripcion_Larga = Convert.ToString(reader["marcas.descripcion_larga"]);

            nuevo.Animal = animal;
            nuevo.TipoProducto = tipo;
            nuevo.Marca = marca;
            nuevo.Codigo = Convert.ToString(reader["cod_producto"]);
            nuevo.Nombre = Convert.ToString(reader["nombre_producto"]);
            nuevo.Fecha_Ingreso = Convert.ToDateTime(reader["fecha_ingreso"]);
            nuevo.Fecha_Modificacion = Convert.ToDateTime(reader["fecha_modificacion"]);
            nuevo.Stock_Limite = Convert.ToSingle(reader["stock_limite"]);
            nuevo.Habilitado = Convert.ToBoolean(reader["habilitado"]);
            return nuevo;
        }
    }
}
