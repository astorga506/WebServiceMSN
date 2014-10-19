using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        private int idCliente;
        private String nombreCliente;
        private String telefono;
        private String correo;

        public Cliente()
        {

        }

        public Cliente(int idCliente, String nombreCliente, String telefono, String correo)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.telefono = telefono;
            this.correo = correo;
        }

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        

        public String NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
        

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        



    }
}
