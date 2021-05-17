using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using SAP.modelo;

namespace SAP.vistas {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
            cargar_pedidos();
        }

        private void cargar_pedidos() {
            DbConnection con = DbConnection.getConnection();
            //dgvPedidos.DataSource = pedidos;
        }
        private void frmMain_Load(object sender, EventArgs e) {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }
        
        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btn_open_form(object sender, EventArgs e) {
            Button b = sender as Button;
            Form x = null;
            switch (b.Name) {
                case "btn_cliente":
                    x = new frmCliente();
                    break;
                case "btn_producto":
                    x = new frmProducto();
                    break;
                case "btn_estado":
                    x = new frmEstado();
                    break;
                case "btn_cuenta":
                    x = new frmCuenta();
                    break;
                case "btn_pedido":
                    x = new frmPedido();
                    break;
            }
            x.Show();
        }
    }
}
