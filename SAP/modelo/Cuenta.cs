using System;
using System.Collections.Generic;
using System.Text;

namespace SAP.modelo {
    class Cuenta {
        public int id;
        private string nombre;

        public Cuenta(string nombre) {
            this.nombre = nombre;
        }
        public string insert() {
            string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = "INSERT INTO cuenta (cuenta, fecha_creacion, fecha_modificacion) values ('{0}', '{1}','{2}')";
            return string.Format(query, this.nombre, now, now);
        }
        public string update() {
            string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = "Update cuenta set cuenta = '{0}', fecha_modificacion = '{1}' where cuenta_id = {2}";
            return string.Format(query, this.nombre, now, this.id);
        }

    }
}
