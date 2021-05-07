using System;
using System.Collections.Generic;
using System.Text;

namespace SAP.modelo {
    struct prod_pedido{
        public Producto producto { get; set; } 
        public int cantidad { get; set; }
    }
    class Pedido {
        private int id { get; set; }
        private Cliente cliente { get; set; }
        private List<prod_pedido> productos { get; set; }
        public int get_total() {
            int valor = 0;
            foreach (var producto in this.productos) {
                valor += producto.cantidad * producto.producto.valor;
            }
            return valor;
        }
    }

   
}
