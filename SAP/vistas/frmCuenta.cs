using SAP.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAP.vistas {
    public partial class frmCuenta : Form {

        DbConnection conn;
        DataTable table;
        public frmCuenta() {
            InitializeComponent();
            conn = DbConnection.getConnection();
            cargar_cuentas();

        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cargar_cuentas() {
            string query ="select cuenta_id Id, cuenta Nombre from cuenta where eliminado = 0";
            table = conn.execute(query);
            dgvClientes.DataSource = table;
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            string id = txtId.Text;
            string nombre = txtNombre.Text;

            if (!String.IsNullOrWhiteSpace(nombre)) {
                Cuenta c = new Cuenta(nombre);
                if (String.IsNullOrWhiteSpace(id)) {
                    conn.executeNQ(c.insert());
                    MessageBox.Show("Cuenta creada correctamente", "Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    c.id = int.Parse(id);
                    conn.executeNQ(c.update());
                    MessageBox.Show("Cuenta actualizada correctamente", "ClieCuentante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                clean();
                cargar_cuentas();
            } else {
                MessageBox.Show("Complete todos los campos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clean() {
            txtNombre.Text = "";
            txtId.Text = "";

            btnAgregar.Text = "Agregar";
            btn_editar.Enabled = true;

        }

        private void frmCliente_Load(object sender, EventArgs e) {

        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            this.clean();
        }

        private void btn_editar_Click(object sender, EventArgs e) {
            if (dgvClientes.SelectedRows.Count > 0) {
                DataGridViewRow row = dgvClientes.SelectedRows[0];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();

                btnAgregar.Text = "Guardar";
                btn_editar.Enabled = false;
            } else {
                MessageBox.Show("Seleccione una cuenta para editar", "Cuenta", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e) {
            if (dgvClientes.SelectedRows.Count > 0) {
                DataGridViewRow row = dgvClientes.SelectedRows[0];
                conn.executeNQ(string.Format("update cuenta set eliminado = 1, fecha_modificacion = '{0}' where cuenta_id ={1}", DateTime.Now, row.Cells["Id"].Value));
                cargar_cuentas();
            } else {
                MessageBox.Show("Seleccione una cuenta para eliminar", "Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
