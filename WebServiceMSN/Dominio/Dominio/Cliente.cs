using LibreriaMSN.Dominio;
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
        private Carrito carrito;

	public Carrito Carrito
	{
		get { return carrito;}
		set { carrito = value;}
	}
	

        public Cliente()
        {
            carrito = new Carrito();
        }

        public Cliente(int idCliente, String nombreCliente, String telefono, String correo, Carrito carrito)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.telefono = telefono;
            this.correo = correo;
            this.carrito = carrito;
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
