using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMSN.Dominio
{
    public class Categoria
    {
        private int codCategoria;
        private String nombre;

        public Categoria()
        {

        }

        public Categoria(int codCategoria, String nombre)
        {
            this.codCategoria = codCategoria;
            this.nombre = nombre;
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

        public int CodCategoria
        {
            get { return codCategoria; }
            set { codCategoria = value; }
        }
        
    }
}
