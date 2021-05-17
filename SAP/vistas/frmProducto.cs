using SAP.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAP.vistas {
    public partial class frmProducto : Form {

        DbConnection conn;
        DataTable table;
        public frmProducto() {
            InitializeComponent();
            conn = DbConnection.getConnection();
            cargar_productos();
        }

        private void cargar_productos() {
            string query = "select producto_id Id, producto Nombre, valor val_original, descripcion Descripcion from producto where eliminado = 0";
            table = conn.execute(query);
            table.Columns.Add("Valor", typeof(string));
            foreach (DataRow row in table.Rows) {
                double sl = Convert.ToDouble(row.ItemArray[2]);
                row.SetField("Valor", sl.ToString("C"));
            }
            dgvProductos.DataSource = table;
            dgvProductos.Columns["val_original"].Visible = false;
            dgvProductos.Columns["Id"].Visible = false;
            dgvProductos.ClearSelection();
        }
        private void label2_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void clean() {
            txtNombre.Text = "";
            txtId.Text = "";
            txtValor.Text = "";
            txtDescripción.Text = "";

            btnAgregar.Text = "Agregar";
            btn_editar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string valor = txtValor.Text;
            string descripcion = txtDescripción.Text;

            if (!String.IsNullOrWhiteSpace(nombre) &&
                !String.IsNullOrWhiteSpace(valor)) {
                int valor_num = (int)Convert.ToDouble(txtValor.Text);
                Producto p = new Producto(valor_num, nombre, descripcion);
                if (String.IsNullOrWhiteSpace(id)) {
                    conn.executeNQ(p.insert());
                    MessageBox.Show("Producto creado correctamente", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                } else {
                    p.id = int.Parse(id);
                    conn.executeNQ(p.update());
                    MessageBox.Show("Producto actualizado correctamente", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                clean();
                cargar_productos();
            } else { 
                MessageBox.Show("Llena el nombre y el valor", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
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

        private void txtValor_Leave(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(txtValor.Text)) {
                double sl = Convert.ToDouble(txtValor.Text);
                txtValor.Text = sl.ToString("#,#");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e) {
            if (dgvProductos.SelectedRows.Count > 0) {
                DataGridViewRow row = dgvProductos.SelectedRows[0];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtValor.Text = Convert.ToDouble(row.Cells["val_original"].Value).ToString("#,#");

                btnAgregar.Text = "Guardar";
                btn_editar.Enabled = false;
            } else {
                MessageBox.Show("Selecciona un producto para editar", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e) {
            btn_editar.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void btn_eliminar_Click(object sender, EventArgs e) {
            if (dgvProductos.SelectedRows.Count > 0) {
                DataGridViewRow row = dgvProductos.SelectedRows[0];
                conn.executeNQ(string.Format("update producto set eliminado = 1, fecha_modificacion = '{0}' where producto_id ={1}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), row.Cells["Id"].Value));
                cargar_productos();
            } else {
                MessageBox.Show("Seleccione un producto para eliminar", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
