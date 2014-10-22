using LibreriaMSN.Dominio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMSN.DAO
{
    public class ProductoDAO : ConexionDB
    {
        public ProductoDAO()
        {

        }

        public Producto GetProducto(int codProducto)
        {
            Producto producto = new Producto();
            String cmdTxt = "SELECT * FROM msn.prodcuto WHERE codProducto=\"" + codProducto + "\";";
            MySqlCommand cmd = new MySqlCommand(cmdTxt, Conexion);  
            Conexion.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                producto.CodProducto = dr.GetInt32("codProducto");
                producto.NombreProducto = dr.GetString("nombreProducto");
                producto.Precio = dr.GetFloat("precio");
                producto.Descripcion = dr.GetString("descripcion");
                producto.Detalles = dr.GetString("detalles");
                producto.CantDisponibles = dr.GetInt32("cantDisponibles");
                producto.Categoria = new CategoriaDAO().GetCategoria(dr.GetInt32("codCategoria"));

            }//if
   
            return producto;
        }//GetProducto

        public List<Producto> GetProductos(String clave)
        {
            List<Producto> productos = new List<Producto>();
            String cmdTxt = "SELECT * FROM msn.prodcuto WHERE nombreProducto=\"" + clave + "\";";//Mejorar consulta; usar clasula LIKE para el nombre, y descripcion.
            MySqlCommand cmd = new MySqlCommand(cmdTxt, Conexion);  
            Conexion.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Producto producto = new Producto();
                producto.CodProducto = dr.GetInt32("codProducto");
                producto.NombreProducto = dr.GetString("nombreProducto");
                producto.Precio = dr.GetFloat("precio");
                producto.Descripcion = dr.GetString("descripcion");
                producto.Detalles = dr.GetString("detalles");
                producto.CantDisponibles = dr.GetInt32("cantDisponibles");
                producto.Categoria = new CategoriaDAO().GetCategoria(dr.GetInt32("codCategoria"));

            }//while  
            return productos;
        }//GetProductos

        public List<Producto> GetProductos(int categoria)
        {
            List<Producto> productos = new List<Producto>();
            String cmdTxt = "SELECT * FROM msn.prodcuto WHERE codCategoria=\"" + categoria + "\";";
            MySqlCommand cmd = new MySqlCommand(cmdTxt, Conexion);  
            Conexion.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Producto producto = new Producto();
                producto.CodProducto = dr.GetInt32("codProducto");
                producto.NombreProducto = dr.GetString("nombreProducto");
                producto.Precio = dr.GetFloat("precio");
                producto.Descripcion = dr.GetString("descripcion");
                producto.Detalles = dr.GetString("detalles");
                producto.CantDisponibles = dr.GetInt32("cantDisponibles");
                producto.Categoria = new CategoriaDAO().GetCategoria(dr.GetInt32("codCategoria"));

            }//if 
            return productos;
        }//GetProductos

        public List<Producto> GetProductos(int categoria, String clave)
        {
            List<Producto> productos = new List<Producto>();              
            String cmdTxt = "SELECT * FROM msn.prodcuto WHERE codCategoria=\"" + categoria + "\" AND nombreProducto=\"" + clave + "\";";
            MySqlCommand cmd = new MySqlCommand(cmdTxt, Conexion);                
            MySqlDataReader dr = cmd.ExecuteReader();
            Conexion.Open();
            while (dr.Read())
            {
                Producto producto = new Producto();
                producto.CodProducto = dr.GetInt32("codProducto");
                producto.NombreProducto = dr.GetString("nombreProducto");
                producto.Precio = dr.GetFloat("precio");
                producto.Descripcion = dr.GetString("descripcion");
                producto.Detalles = dr.GetString("detalles");
                producto.CantDisponibles = dr.GetInt32("cantDisponibles");
                producto.Categoria = new CategoriaDAO().GetCategoria(dr.GetInt32("codCategoria"));

            }//if
            return productos;
        }//GetProductos

        public Producto InsertarProducto(Producto producto)
        {
            String cmdTxt = "sp_insertar_producto";
            MySqlCommand cmd = new MySqlCommand(cmdTxt, Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codProducto", MySqlDbType.Int32);
            cmd.Parameters["@codProducto"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new MySqlParameter("@nombreProducto", producto.NombreProducto));
            cmd.Parameters.Add(new MySqlParameter("@precio", producto.Precio));
            cmd.Parameters.Add(new MySqlParameter("@descripcion", producto.Descripcion));
            cmd.Parameters.Add(new MySqlParameter("@detalles", producto.Detalles));
            cmd.Parameters.Add(new MySqlParameter("@cantDisponibles", producto.CantDisponibles));
            cmd.Parameters.Add(new MySqlParameter("@codCategoria", producto.Categoria.CodCategoria));


            cmd.ExecuteNonQuery();

            producto.CodProducto = Convert.ToInt32(cmd.Parameters["@output"].Value.ToString());

            Conexion.Close();

            return producto;
        }//InsertarProducto

    }
}
