
namespace SAP.vistas {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label2 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_producto = new System.Windows.Forms.Button();
            this.btn_movimiento = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_pedido = new System.Windows.Forms.Button();
            this.btn_cuenta = new System.Windows.Forms.Button();
            this.btn_estado = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pizzeria Carlo";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Firebrick;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(692, 386);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 31);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_cliente.Location = new System.Drawing.Point(33, 290);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(115, 60);
            this.btn_cliente.TabIndex = 9;
            this.btn_cliente.Text = "Clientes";
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_open_form);
            // 
            // btn_producto
            // 
            this.btn_producto.BackColor = System.Drawing.Color.Firebrick;
            this.btn_producto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_producto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_producto.ForeColor = System.Drawing.Color.White;
            this.btn_producto.Location = new System.Drawing.Point(154, 290);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(115, 60);
            this.btn_producto.TabIndex = 10;
            this.btn_producto.Text = "Productos";
            this.btn_producto.UseVisualStyleBackColor = false;
            this.btn_producto.Click += new System.EventHandler(this.btn_open_form);
            // 
            // btn_movimiento
            // 
            this.btn_movimiento.BackColor = System.Drawing.Color.Firebrick;
            this.btn_movimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_movimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_movimiento.ForeColor = System.Drawing.Color.White;
            this.btn_movimiento.Location = new System.Drawing.Point(33, 168);
            this.btn_movimiento.Name = "btn_movimiento";
            this.btn_movimiento.Size = new System.Drawing.Size(115, 60);
            this.btn_movimiento.TabIndex = 11;
            this.btn_movimiento.Text = "Movimientos";
            this.btn_movimiento.UseVisualStyleBackColor = false;
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.Firebrick;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reporte.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reporte.ForeColor = System.Drawing.Color.White;
            this.btn_reporte.Location = new System.Drawing.Point(154, 169);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(115, 60);
            this.btn_reporte.TabIndex = 12;
            this.btn_reporte.Text = "Reportes";
            this.btn_reporte.UseVisualStyleBackColor = false;
            // 
            // btn_pedido
            // 
            this.btn_pedido.BackColor = System.Drawing.Color.Firebrick;
            this.btn_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pedido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pedido.ForeColor = System.Drawing.Color.White;
            this.btn_pedido.Location = new System.Drawing.Point(33, 117);
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.Size = new System.Drawing.Size(236, 45);
            this.btn_pedido.TabIndex = 13;
            this.btn_pedido.Text = "Nuevo Pedido";
            this.btn_pedido.UseVisualStyleBackColor = false;
            this.btn_pedido.Click += new System.EventHandler(this.btn_open_form);
            // 
            // btn_cuenta
            // 
            this.btn_cuenta.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cuenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cuenta.ForeColor = System.Drawing.Color.White;
            this.btn_cuenta.Location = new System.Drawing.Point(33, 356);
            this.btn_cuenta.Name = "btn_cuenta";
            this.btn_cuenta.Size = new System.Drawing.Size(115, 60);
            this.btn_cuenta.TabIndex = 14;
            this.btn_cuenta.Text = "Cuentas";
            this.btn_cuenta.UseVisualStyleBackColor = false;
            this.btn_cuenta.Click += new System.EventHandler(this.btn_open_form);
            // 
            // btn_estado
            // 
            this.btn_estado.BackColor = System.Drawing.Color.Firebrick;
            this.btn_estado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_estado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_estado.ForeColor = System.Drawing.Color.White;
            this.btn_estado.Location = new System.Drawing.Point(154, 356);
            this.btn_estado.Name = "btn_estado";
            this.btn_estado.Size = new System.Drawing.Size(115, 60);
            this.btn_estado.TabIndex = 15;
            this.btn_estado.Text = "Estados";
            this.btn_estado.UseVisualStyleBackColor = false;
            this.btn_estado.Click += new System.EventHandler(this.btn_open_form);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(741, 10);
            this.label6.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 10);
            this.label3.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 82);
            this.panel1.TabIndex = 22;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_estado);
            this.Controls.Add(this.btn_cuenta);
            this.Controls.Add(this.btn_pedido);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.btn_movimiento);
            this.Controls.Add(this.btn_producto);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 30, 30);
            this.Text = "Sistema administrador";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_producto;
        private System.Windows.Forms.Button btn_movimiento;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_pedido;
        private System.Windows.Forms.Button btn_cuenta;
        private System.Windows.Forms.Button btn_estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}