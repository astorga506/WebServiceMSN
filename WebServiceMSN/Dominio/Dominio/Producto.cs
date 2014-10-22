using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMSN.Dominio
{
    public class Producto
    {
        private int codProducto;
        private String nombreProducto;
        private float precio;
        private String descripcion;
        private String detalles;
        private int cantDisponibles;
        private Categoria categoria;

        public Producto()
        {
            categoria = new Categoria();
        }

        public Producto(int codProducto, String nombreProducto, float precio, String descripcion, 
            String detalles, int cantDisponibles, Categoria categoria)
        {
            this.codProducto = codProducto;
            this.nombreProducto = nombreProducto;
            this.precio = precio;
            this.descripcion = descripcion;
            this.detalles = detalles;
            this.cantDisponibles = cantDisponibles;
            this.categoria = categoria;
        }

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        

        public int CantDisponibles
        {
            get { return cantDisponibles; }
            set { cantDisponibles = value; }
        }
        

        public String Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }
        

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        

        public String NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }
        

        public int CodProducto
        {
            get { return codProducto; }
            set { codProducto = value; }
        }
        

    }
}
