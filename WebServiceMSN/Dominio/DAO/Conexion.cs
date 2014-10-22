using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMSN.DAO
{
    public class ConexionDB
    {
        private MySqlConnection conexion;        

        public ConexionDB()
        {
            conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["MSN"].ConnectionString);
        }

        public MySqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }

    }
    
}
