using Dominio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceMSN
{
    /// <summary>
    /// Summary description for MSN
    /// </summary>
    [WebService(Namespace = "http://msn.cr/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MSN : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["MSN"].ConnectionString))
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM msn.cliente;";
                cmd.Connection = con;
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = dr.GetInt32("idCliente");
                    cliente.NombreCliente = dr.GetString("nombreCliente");
                    cliente.Correo = dr.GetString("correo");
                    cliente.Telefono = dr.GetString("telefono");                    
                    clientes.Add(cliente);
                }//while
                
            }//using
            
            return clientes;
        }//ObtenerClientes

        [WebMethod]
        public Boolean EsCliente(string contrasena, string correo)
        {
            Boolean retVal = false;
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["MSN"].ConnectionString))
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM msn.cliente WHERE correo=\""+correo+"\" AND contrasena=\""+contrasena+"\";";
                cmd.Connection = con;
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    retVal = true;
                }//if

            }//using    
            return retVal;
        }//esCliente


    }//class
}//namespace
