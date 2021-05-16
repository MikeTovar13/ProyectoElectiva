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
            table.Columns.Add("Producto", typeof(String));
            table.Columns.Add("Cantidad", typeof(int));
            table.Columns.Add("Valor", typeof(String));
            dgvProductos.DataSource = table;
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
            //txtNombre.Text = "";
            txtId.Text = "";
            //txtValor.Text = "";
            //txtDescripción.Text = "";

            btn_modificar.Text = "Agregar";
            //btn_editar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            string id = txtId.Text;
            int id_cliente = int.Parse(cbxCliente.SelectedValue.ToString());
            int id_cuenta = int.Parse(cbxCuenta.SelectedValue.ToString());
            bool isDomicilio = cbxDomicilio.Checked;
            MessageBox.Show(isDomicilio.ToString());

            foreach (DataGridViewRow row in dgvProductos.Rows) {
                for (int i = 0; i < dgvProductos.ColumnCount; i++) {
                    MessageBox.Show(row.Cells[i].Value.ToString());
                }
            }
            //string valor = txtValor.Text;
            //string descripcion = txtDescripción.Text;

            //if (!String.IsNullOrWhiteSpace(nombre) &&
            //    !String.IsNullOrWhiteSpace(valor)) {
            //    int valor_num = (int)Convert.ToDouble(txtValor.Text);
            //    Producto p = new Producto(valor_num, nombre, descripcion);
            //    if (String.IsNullOrWhiteSpace(id)) {
            //        conn.executeNQ(p.insert());
            //        MessageBox.Show("Producto creado correctamente", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    } else {
            //        p.id = int.Parse(id);
            //        conn.executeNQ(p.update());
            //        MessageBox.Show("Producto actualizado correctamente", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //    clean();
            //    cargar_productos();
            //} else { 
            //    MessageBox.Show("Llena el nombre y el valor", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            clean();
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
                table.Rows.Add(table_prod.Rows[x]["Nombre"], y, ((Int64)table_prod.Rows[x]["val_original"] * y).ToString("C"));
            } else {
                MessageBox.Show("Esriba una cantidad para el producto", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e) {
            //if (dgvProductos.SelectedRows.Count > 0) {
            //    DataGridViewRow row = dgvProductos.SelectedRows[0];
            //    txtId.Text = row.Cells["Id"].Value.ToString();
            //    txtNombre.Text = row.Cells["Nombre"].Value.ToString();
            //    txtValor.Text = Convert.ToDouble(row.Cells["val_original"].Value).ToString("#,#");

            //    btn_modificar.Text = "Guardar";
            //    btn_editar.Enabled = false;
            //} else {
            //    MessageBox.Show("Selecciona un producto para editar", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
        private void btn_eliminar_Click(object sender, EventArgs e) {
            //if (dgvProductos.SelectedRows.Count > 0) {
            //    DataGridViewRow row = dgvProductos.SelectedRows[0];
            //    conn.executeNQ(string.Format("update producto set eliminado = 1, fecha_modificacion = '{0}' where producto_id ={1}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), row.Cells["Id"].Value));
            //    cargar_productos();
            //} else {
            //    MessageBox.Show("Seleccione un producto para eliminar", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
