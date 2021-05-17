using SAP.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAP.vistas {
    public partial class frmCliente : Form {

        DbConnection conn;
        DataTable table;
        public frmCliente() {
            InitializeComponent();
            conn = DbConnection.getConnection();
            cargar_clientes();

        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cargar_clientes() {
            string query ="select cliente_id Id, nombre Nombre, telefono Telefono, direccion Direccion from cliente where eliminado = 0";
            table = conn.execute(query);
            dgvClientes.DataSource = table;
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDirección.Text;

            if (!String.IsNullOrWhiteSpace(nombre) &&
                !String.IsNullOrWhiteSpace(telefono) &&
                !String.IsNullOrWhiteSpace(direccion)) {
                Cliente c = new Cliente(nombre, direccion, telefono);
                if (String.IsNullOrWhiteSpace(id)) {
                    conn.executeNQ(c.insert());
                    MessageBox.Show("Cliente creado correctamente","Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    c.id = int.Parse(id);
                    conn.executeNQ(c.update());
                    MessageBox.Show("Cliente actualizado correctamente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                clean();
                cargar_clientes();
            } else {
                MessageBox.Show("Complete todos los campos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clean() {
            txtNombre.Text = "";
            txtDirección.Text = "";
            txtTelefono.Text = "";
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
                txtDirección.Text = row.Cells[3].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
                txtTelefono.Text = row.Cells[2].Value.ToString();

                btnAgregar.Text = "Guardar";
                btn_editar.Enabled = false;
            } else {
                MessageBox.Show("Seleccione un cliente para editar", "Cliente", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e) {
            if (dgvClientes.SelectedRows.Count > 0) {
                DataGridViewRow row = dgvClientes.SelectedRows[0];
                conn.executeNQ(string.Format("update cliente set eliminado = 1, fecha_modificacion = '{0}' where cliente_id ={1}", DateTime.Now, row.Cells["Id"].Value));
                cargar_clientes();
            } else {
                MessageBox.Show("Seleccione un cliente para eliminar", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
