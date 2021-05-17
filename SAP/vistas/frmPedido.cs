using SAP.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAP.vistas {
    public partial class frmPedido : Form {

        DbConnection conn;
        DataTable table_prod, table_client, table, table_cuenta;
        public frmPedido() {
            InitializeComponent();
            conn = DbConnection.getConnection();
            cargar_combobox();
        }

        private void cargar_combobox() {
            string query = "select producto_id Id, producto Nombre, valor val_original from producto where eliminado = 0";
            table_prod = conn.execute(query);
            cbxProductos.DataSource = table_prod;
            cbxProductos.DisplayMember = "Nombre";
            cbxProductos.ValueMember = "Id";
            query = "select cliente_id Id, nombre Nombre from  cliente where eliminado = 0";
            table_client = conn.execute(query);
            cbxCliente.DataSource = table_client;
            cbxCliente.DisplayMember = "Nombre";
            cbxCliente.ValueMember = "Id";
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Producto", typeof(String));
            table.Columns.Add("Cantidad", typeof(int));
            table.Columns.Add("Valor", typeof(String));
            dgvProductos.DataSource = table;
            dgvProductos.Columns["ID"].Visible = false;
            query = "select cuenta_id Id, cuenta Nombre from cuenta where eliminado = 0";
            table_cuenta = conn.execute(query);
            cbxCuenta.DataSource = table_cuenta;
            cbxCuenta.DisplayMember = "Nombre";
            cbxCuenta.ValueMember = "Id";
        }
        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void clean() {
            txtId.Text = "";
            txtCantidad.Text = "";
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Producto", typeof(String));
            table.Columns.Add("Cantidad", typeof(int));
            table.Columns.Add("Valor", typeof(String));
            dgvProductos.DataSource = table;
            dgvProductos.Columns["ID"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            string id = txtId.Text;
            int id_cliente = int.Parse(cbxCliente.SelectedValue.ToString());
            int id_cuenta = int.Parse(cbxCuenta.SelectedValue.ToString());
            bool isDomicilio = cbxDomicilio.Checked;

            List<prod_pedido> listado_productos = new List<prod_pedido>();

            foreach (DataGridViewRow row in dgvProductos.Rows) {
                Producto p = new Producto(Convert.ToDouble(row.Cells["Valor"].Value.ToString().Replace("$", "")), "", "");
                p.id = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                prod_pedido pp = new prod_pedido();
                pp.producto = p;
                pp.cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());

                listado_productos.Add(pp);
            }

            Pedido pedido = new Pedido(id_cliente, Convert.ToInt32(isDomicilio), id_cuenta, 1, listado_productos);
            long id_pedido = conn.executeNQ(pedido.insert());
            pedido.id = (int)id_pedido;

            conn.executeNQ(pedido.insert_estado());
            conn.executeNQ(pedido.insert_movimiento());
            conn.executeNQ(pedido.insert_productos());

            MessageBox.Show("El pedido se creo con exito");
            clean();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            clean();
        }

        private void btn_quitar_producto_Click(object sender, EventArgs e) {
            if (dgvProductos.SelectedRows.Count > 0) {
                DataGridViewRow row = dgvProductos.SelectedRows[0];
                table.Rows[row.Index].Delete();
                table.AcceptChanges();
                dgvProductos.Refresh();
            } else {
                MessageBox.Show("Seleccione un producto para eliminar", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e) {
            if (Char.IsDigit(e.KeyChar)) {
                e.Handled = false;
            } else if (Char.IsControl(e.KeyChar)) { //permitir teclas de control como retroceso
                e.Handled = false;
            } else {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e) {
            if (Char.IsDigit(e.KeyChar)) {
                e.Handled = false;
            } else if (Char.IsControl(e.KeyChar)) { //permitir teclas de control como retroceso
                e.Handled = false;
            } else {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void btn_agregar_producto_Click(object sender, EventArgs e) {
            int x = cbxProductos.SelectedIndex;
            int y;
            int.TryParse(txtCantidad.Text, out y);
            if (y != 0) {
                table.Rows.Add(table_prod.Rows[x]["Id"], table_prod.Rows[x]["Nombre"], y, ((Int64)table_prod.Rows[x]["val_original"] * y).ToString("C"));
            } else {
                MessageBox.Show("Esriba una cantidad para el producto", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
