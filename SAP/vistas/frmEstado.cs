using SAP.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAP.vistas {
    public partial class frmEstado : Form {

        DbConnection conn;
        DataTable table;
        public frmEstado() {
            InitializeComponent();
            conn = DbConnection.getConnection();
            cargar_estados();

        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cargar_estados() {
            string query ="select estado_id Id, estado Nombre from estado where eliminado = 0";
            table = conn.execute(query);
            dgvClientes.DataSource = table;
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            string id = txtId.Text;
            string nombre = txtNombre.Text;

            if (!String.IsNullOrWhiteSpace(nombre)) {
                Estado c = new Estado(nombre);
                if (String.IsNullOrWhiteSpace(id)) {
                    conn.executeNQ(c.insert());
                    MessageBox.Show("Estado creado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    c.id = int.Parse(id);
                    conn.executeNQ(c.update());
                    MessageBox.Show("Estado actualizado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                clean();
                cargar_estados();
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
                txtId.Text = row.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();

                btnAgregar.Text = "Guardar";
                btn_editar.Enabled = false;
            } else {
                MessageBox.Show("Seleccione un estado para editar", "Estado", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e) {
            if (dgvClientes.SelectedRows.Count > 0) {
                DataGridViewRow row = dgvClientes.SelectedRows[0];
                conn.executeNQ(string.Format("update estado set eliminado = 1, fecha_modificacion = '{0}' where estado_id ={1}", DateTime.Now, row.Cells["Id"].Value));
                cargar_estados();
            } else {
                MessageBox.Show("Seleccione un estado para eliminar", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
