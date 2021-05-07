using System;
using System.Collections.Generic;
using System.Text;

namespace SAP.modelo {
    class Producto {
        public int id { get; set; }
        public int valor{ get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }

        public Producto(int valor, string nombre, string descripcion) {
            this.valor = valor;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        public string insert() {
            string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            string query = "INSERT INTO producto (producto, valor, descripcion, fecha_creacion, fecha_modificacion) values ('{0}', '{1}','{2}', '{3}', '{4}')";
            return string.Format(query, this.nombre, this.valor, this.descripcion, now, now);
        }

        public string update() {
            string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = "UPDATE producto  SET producto = '{0}', valor = {1}, descripcion= '{4}' ,fecha_modificacion  ='{2}' where producto_id = {3}";
            return string.Format(query, this.nombre, this.valor, now, this.id);
        }
    }
}
