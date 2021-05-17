using SAP.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAP.vistas {
    public partial class frmMovimientos : Form {

        struct tipos {
            public string nombre { get; set; }

        }

        DbConnection conn;
        DataTable table, table_cuenta;
        public frmMovimientos() {
            InitializeComponent();
            conn = DbConnection.getConnection();
            cargar_movimientos();
            string query;
            query = "select cuenta_id Id, cuenta Nombre from cuenta where eliminado = 0";
            table_cuenta = conn.execute(query);
            cbxCuenta.DataSource = table_cuenta;
            cbxCuenta.DisplayMember = "Nombre";
            cbxCuenta.ValueMember = "Id";

            List<tipos> listado_tipo = new List<tipos>();
            listado_tipo.Add(new tipos() { nombre = "Ingreso" });
            listado_tipo.Add(new tipos() { nombre = "Salida" });
            cbxTipo.DataSource = listado_tipo;
            cbxTipo.DisplayMember = "nombre";
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cargar_movimientos() {
            string query ="select movimiento_id Id, tipo_movimiento Tipo, m.cuenta_id Cuenta_ID, c.cuenta Cuenta, desripcion Descripcion, valor Valor_Original from movimiento as m INNER JOIN cuenta as c ON c.cuenta_id = m.cuenta_id where m.eliminado = 0 ORDER BY movimiento_id DESC";
            table = conn.execute(query);
            dgvMovimientos.DataSource = table;
            table.Columns.Add("Valor", typeof(string));
            foreach (DataRow row in table.Rows) {
                double sl = Convert.ToDouble(row.ItemArray[5]);
                row.SetField("Valor", sl.ToString("C"));
            }
            dgvMovimientos.Columns[0].Visible = false;
            dgvMovimientos.Columns["Cuenta_ID"].Visible = false;
            dgvMovimientos.Columns["Valor_Original"].Visible = false;
            dgvMovimientos.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            string id = txtId.Text;
            string valor = txtValor.Text;
            string descripcion = txtDescripcion.Text;
            string tipo = cbxTipo.Text;
            int cuenta_id = int.Parse(cbxCuenta.SelectedValue.ToString());


            if (!String.IsNullOrWhiteSpace(valor) &&
                !String.IsNullOrWhiteSpace(descripcion)) {
                Movimiento m = new Movimiento(tipo, cuenta_id, descripcion, int.Parse(valor));
                if (String.IsNullOrWhiteSpace(id)) {
                    conn.executeNQ(m.insert());
                    MessageBox.Show("Movimiento creado correctamente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    m.id = int.Parse(id);
                    conn.executeNQ(m.update());
                    MessageBox.Show("Movimiento actualizado correctamente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                clean();
                cargar_movimientos();
            } else {
                MessageBox.Show("Complete todos los campos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clean() {
            txtDescripcion.Text = "";
            txtValor.Text = "";
            txtId.Text = "";
            btnAgregar.Text = "Agregar";
            btn_editar.Enabled = true;

        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            this.clean();
        }

        private void btn_editar_Click(object sender, EventArgs e) {
            if (dgvMovimientos.SelectedRows.Count > 0) {
                DataGridViewRow row = dgvMovimientos.SelectedRows[0];
                txtId.Text = row.Cells[0].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtValor.Text = row.Cells["Valor_Original"].Value.ToString();
                cbxCuenta.SelectedValue = row.Cells["Cuenta_ID"].Value;
                cbxTipo.Text = row.Cells["Tipo"].Value.ToString();

                btnAgregar.Text = "Guardar";
                btn_editar.Enabled = false;
            } else {
                MessageBox.Show("Seleccione un movimiento para editar", "Movimiento", MessageBoxButtons.OK,MessageBoxIcon.Information);
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

    }
}
