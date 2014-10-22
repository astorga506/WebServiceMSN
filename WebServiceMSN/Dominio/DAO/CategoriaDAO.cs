using LibreriaMSN.Dominio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMSN.DAO
{
    public class CategoriaDAO : ConexionDB
    {

        public CategoriaDAO()
        {

        }

        public Categoria GetCategoria(int codCategoria)
        {
            Categoria categoria = new Categoria();
            using (Conexion)
            {
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT * FROM msn.categoria WHERE codCategoria=\"" + codCategoria + "\";";
                cmd.Connection = Conexion;
                Conexion.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    categoria.CodCategoria = dr.GetInt32("codCategoria");
                    categoria.Nombre = dr.GetString("nombre");

                }//if

            }//using    
            return categoria;
        }//GetCategoria


    }
}
