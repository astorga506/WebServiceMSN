using LibreriaMSN.Dominio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMSN.DAO
{
    public class CarritoDAO : ConexionDB
    {
        public CarritoDAO()
        {

        }

        public Carrito GetCarrito(string idCliente)
        {
            Carrito carrito = new Carrito();
            using (Conexion)
            {
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT * FROM msn.carrito WHERE idCliente=\"" + idCliente + "\";";
                cmd.Connection = Conexion;
                Conexion.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ItemCarrito item = new ItemCarrito();
                    item.Cantidad = dr.GetInt32("cantidad");
                    item.Producto = new ProductoDAO().GetProducto(dr.GetInt32("codProducto"));
                    carrito.Items.Add(item);
                }
            }//using    
            return carrito;
        }//GetCarrito

    }
}
