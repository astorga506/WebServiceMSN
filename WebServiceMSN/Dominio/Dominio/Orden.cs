using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMSN.Dominio
{
    public class Orden
    {
        private int numOrden;
        private DateTime fecha;
        private String estado;
        private List<ItemOrden> detalle;

        public Orden()
        {
            detalle = new List<ItemOrden>();
        }

        public Orden(int numOrden, DateTime fecha, String estado, List<ItemOrden> detalle)
        {
            this.numOrden = numOrden;
            this.fecha = fecha;
            this.estado = estado;
            this.detalle = detalle;
        }

        public List<ItemOrden> Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        

        public int NumOrden
        {
            get { return numOrden; }
            set { numOrden = value; }
        }
        

    }
}
