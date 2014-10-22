using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMSN.Dominio
{
    public class Carrito
    {
        private List<ItemCarrito> items;

        public Carrito()
        {
            items = new List<ItemCarrito>();
        }

        public Carrito(List<ItemCarrito> items)
        {
            this.items = items;
        }

        public List<ItemCarrito> Items
        {
            get { return items; }
            set { items = value; }
        }
        

    }
}
