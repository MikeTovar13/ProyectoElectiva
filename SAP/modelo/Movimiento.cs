using System;
using System.Collections.Generic;
using System.Text;

namespace SAP.modelo {
    class Movimiento {
        public int id;
        private string tipo, descripcion;
        private int cuenta_id, valor;

        public Movimiento(string tipo, int cuenta_id, string descripcion, int valor) {
            this.tipo = tipo;
            this.cuenta_id = cuenta_id;
            this.descripcion = descripcion;
            this.valor = valor;
        }
        public string insert() {
            string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = "INSERT INTO movimiento (tipo_movimiento, cuenta_id, desripcion, valor, fecha_movimiento, fecha_creacion, fecha_modificacion)"+
                            "values ('{0}', {1}, '{2}', {3}, '{4}', '{5}', '{6}')";
            return string.Format(query, this.tipo, this.cuenta_id, this.descripcion, this.valor, now, now, now);
        }
        public string update() {
            string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = "Update movimiento set tipo_movimiento = '{0}', cuenta_id = {1}, desripcion = '{2}', valor = {3}, fecha_modificacion = '{4}' where movimiento_id = {5}";
            return string.Format(query, this.tipo, this.cuenta_id, this.descripcion, this.valor, now, this.id);
        }

    }
}
