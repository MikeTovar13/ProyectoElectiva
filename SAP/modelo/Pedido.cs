using System;
using System.Collections.Generic;
using System.Text;

namespace SAP.modelo {
    struct prod_pedido{
        public Producto producto { get; set; } 
        public int cantidad { get; set; }
    }
    class Pedido {
        public int id { get; set; }
        private int cliente { get; set; }
        private int domicilio { get; set; }
        private int estado { get; set; }
        private int cuenta { get; set; }
        private List<prod_pedido> productos { get; set; }

        public Pedido(int cliente, int domicilio, int cuenta, int estado, List<prod_pedido> productos) {
            this.cliente = cliente;
            this.domicilio = domicilio;
            this.cuenta = cuenta;
            this.estado = estado;
            this.productos = productos;
        }

        public double get_total() {
            double valor = 0;
            foreach (var producto in this.productos) {
                valor += producto.producto.valor;
            }
            return valor;
        }
        public string insert() {
            string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = "INSERT INTO pedido (cliente_id, domicilio, fecha_creacion, fecha_modificacion) values ({0}, {1},'{2}', '{3}')";
            return string.Format(query, this.cliente, this.domicilio, now, now);
        }

        public string insert_estado() {
            string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = "INSERT INTO estado_pedido (pedido_id, estado_id, activo, fecha_creacion) values ({0}, {1}, {2}, '{3}')";
            return string.Format(query, this.id, this.estado, 1, now);
        }

        public string insert_productos() {
            string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = "INSERT INTO producto_pedido (pedido_id, producto_id, cantidad, valor, fecha_creacion, fecha_modificacion) values ";
            string values = "({0}, {1}, {2}, {3}, '{4}', '{5}'),";
            for (int i = 0; i < productos.Count; i++) {
                query += string.Format(values, this.id, productos[i].producto.id, productos[i].cantidad, productos[i].producto.valor, now, now);
            }

            return query.Remove(query.Length-1);
        }

        public string insert_movimiento() {
            string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = "INSERT INTO movimiento (tipo_movimiento, cuenta_id, desripcion, valor, pedido_id, fecha_movimiento, fecha_creacion, fecha_modificacion) values ('{0}', {1}, '{2}', {3}, {4}, '{5}', '{6}', '{7}')";
            return string.Format(query, "Ingreso", this.cuenta, "PEDIDO N° "+this.id, get_total(), this.id, now, now, now);
        }

    }
}
