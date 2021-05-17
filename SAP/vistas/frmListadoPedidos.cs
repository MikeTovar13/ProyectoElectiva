using SAP.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAP.vistas {
    public partial class frmListadoPedidos : Form {

        DbConnection conn;
        DataTable table, table_estado;
        public frmListadoPedidos() {
            InitializeComponent();
            conn = DbConnection.getConnection();
            cargar_pedidos();
            string query;
            query = "select estado_id Id, estado Estado from estado where eliminado = 0";
            table_estado = conn.execute(query);
            cbxEstado.DataSource = table_estado;
            cbxEstado.DisplayMember = "Estado";
            cbxEstado.ValueMember = "Id";
        }

        private void btn_editar_Click(object sender, EventArgs e) {
            if (dgvPedidos.SelectedRows.Count > 0) {
                DataGridViewRow row = dgvPedidos.SelectedRows[0];
                string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                string query = "UPDATE estado_pedido SET activo = 0 WHERE pedido_id = {0}";
                conn.executeNQ(string.Format(query, row.Cells["ID"].Value.ToString()));
                query = "INSERT INTO estado_pedido (pedido_id, estado_id, activo, fecha_creacion) values ({0},{1},{2},'{3}')";
                conn.executeNQ(string.Format(query, row.Cells["ID"].Value.ToString(), cbxEstado.SelectedValue, 1, now));
            } else {
                MessageBox.Show("Seleccione un pedido para editar su estado", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cargar_pedidos();
        }

        private void cargar_pedidos() {
            string query ="select p.pedido_id ID, e.estado Estado, 'PEDIDO N°' || p.pedido_id Pedido,  case when domicilio = 1 then 'Domicilio' when domicilio = 0 then 'En tienda' end 'Tipo entrega', m.valor Valor_Original"+
                " from pedido as p INNER JOIN estado_pedido as ep ON ep.pedido_id = p.pedido_id INNER JOIN estado e on e.estado_id = ep.estado_id INNER JOIN movimiento as m ON m.pedido_id = p.pedido_id "+
                " where p.eliminado = 0 and ep.activo = 1 ORDER BY p.pedido_id DESC";
            table = conn.execute(query);
            dgvPedidos.DataSource = table;
            table.Columns.Add("Valor", typeof(string));
            foreach (DataRow row in table.Rows) {
                double sl = Convert.ToDouble(row.ItemArray[4]);
                row.SetField("Valor", sl.ToString("C"));
            }
            dgvPedidos.Columns[0].Visible = false;
            dgvPedidos.Columns["Valor_Original"].Visible = false;
            dgvPedidos.ClearSelection();
        }

    }
}
