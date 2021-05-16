using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAP.vistas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void AbrirFormEnPanel(object formhija)
        {
            if (this.pnlRenderizar.Controls.Count > 0)
                this.pnlRenderizar.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlRenderizar.Controls.Add(fh);
            this.pnlRenderizar.Tag = fh;
            fh.Show();
        }

        private void renderizar_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            switch (b.Name)
            {
                case "btn_form1":
                    this.AbrirFormEnPanel(new frmPedido());
                    break;
                case "btn_form2":
                    this.AbrirFormEnPanel(new frmPedido());
                    break;
                case "btn_form3":
                    this.AbrirFormEnPanel(new frmEstado());
                    break;
                case "btn_form4":
                    this.AbrirFormEnPanel(new frmProducto());
                    break;
                case "btn_form5":
                    this.AbrirFormEnPanel(new frmCuenta());
                    break;
                case "btn_form6":
                    this.AbrirFormEnPanel(new frmCliente());
                    break;
            }
        }
    }
}
