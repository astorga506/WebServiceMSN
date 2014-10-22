using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMSN.Dominio
{
    public class Tienda
    {
        private int codTienda;
        private String direccion;
        private String telefono;
        private String horario;

        public Tienda()
        {

        }

        public Tienda(int codTienda, String direccion, String telefono, String horario)
        {
            this.codTienda = codTienda;
            this.direccion = direccion;
            this.telefono = telefono;
            this.horario = horario;
        }

        public String Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        

        public int CodTienda
        {
            get { return codTienda; }
            set { codTienda = value; }
        }
        

    }
}
