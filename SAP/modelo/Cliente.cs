using System;
using System.Collections.Generic;
using System.Text;

namespace SAP.modelo {
    class Cliente {
        public int id;
        private string nombre, direccion, telefono;

        public Cliente(string nombre, string direccion, string telefono) {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        public string insert() {
            string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = "INSERT INTO cliente (nombre, direccion, telefono, fecha_creacion, fecha_modificacion) values ('{0}', '{1}','{2}', '{3}', '{4}')";
            return string.Format(query, this.nombre, this.direccion, this.telefono, now, now);
        }
        public string update() {
            string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = "Update cliente set nombre = '{0}', direccion= '{1}', telefono = '{2}', fecha_modificacion = '{3}' where cliente_id = {4}";
            return string.Format(query, this.nombre, this.direccion, this.telefono, now, this.id);
        }

    }
}
