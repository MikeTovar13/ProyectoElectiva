
namespace SAP.vistas {
    partial class frmPedido {
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDomicilio = new System.Windows.Forms.CheckBox();
            this.cbxProductos = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btn_agregar_producto = new System.Windows.Forms.Button();
            this.btn_quitar_producto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCuenta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(730, 10);
            this.label6.TabIndex = 32;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Firebrick;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(413, 163);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 32);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_modificar.FlatAppearance.BorderSize = 2;
            this.btn_modificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(671, 124);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(89, 73);
            this.btn_modificar.TabIndex = 29;
            this.btn_modificar.Text = "Crear pedido";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(153, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 28;
            this.txtId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pedidos";
            // 
            // cbxDomicilio
            // 
            this.cbxDomicilio.AutoSize = true;
            this.cbxDomicilio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxDomicilio.Location = new System.Drawing.Point(30, 90);
            this.cbxDomicilio.Name = "cbxDomicilio";
            this.cbxDomicilio.Size = new System.Drawing.Size(91, 24);
            this.cbxDomicilio.TabIndex = 34;
            this.cbxDomicilio.Text = "Domicilo";
            this.cbxDomicilio.UseVisualStyleBackColor = true;
            // 
            // cbxProductos
            // 
            this.cbxProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxProductos.FormattingEnabled = true;
            this.cbxProductos.Location = new System.Drawing.Point(113, 158);
            this.cbxProductos.Name = "cbxProductos";
            this.cbxProductos.Size = new System.Drawing.Size(130, 28);
            this.cbxProductos.TabIndex = 35;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad.Location = new System.Drawing.Point(346, 160);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(44, 26);
            this.txtCantidad.TabIndex = 36;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(30, 230);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(636, 230);
            this.dgvProductos.TabIndex = 39;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.BackColor = System.Drawing.Color.Firebrick;
            this.btn_agregar_producto.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_agregar_producto.FlatAppearance.BorderSize = 2;
            this.btn_agregar_producto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn_agregar_producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_agregar_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_agregar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar_producto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar_producto.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_producto.Location = new System.Drawing.Point(414, 124);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(88, 32);
            this.btn_agregar_producto.TabIndex = 40;
            this.btn_agregar_producto.Text = "Agregar";
            this.btn_agregar_producto.UseVisualStyleBackColor = false;
            this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
            // 
            // btn_quitar_producto
            // 
            this.btn_quitar_producto.BackColor = System.Drawing.Color.Firebrick;
            this.btn_quitar_producto.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_quitar_producto.FlatAppearance.BorderSize = 2;
            this.btn_quitar_producto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn_quitar_producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_quitar_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_quitar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_quitar_producto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_quitar_producto.ForeColor = System.Drawing.Color.White;
            this.btn_quitar_producto.Location = new System.Drawing.Point(672, 409);
            this.btn_quitar_producto.Name = "btn_quitar_producto";
            this.btn_quitar_producto.Size = new System.Drawing.Size(88, 51);
            this.btn_quitar_producto.TabIndex = 41;
            this.btn_quitar_producto.Text = "Eliminar producto";
            this.btn_quitar_producto.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(262, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Cantidad";
            // 
            // cbxCliente
            // 
            this.cbxCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(97, 124);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(293, 28);
            this.cbxCliente.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Firebrick;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 460);
            this.label5.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(30, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Forma de pago";
            // 
            // cbxCuenta
            // 
            this.cbxCuenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxCuenta.FormattingEnabled = true;
            this.cbxCuenta.Location = new System.Drawing.Point(158, 192);
            this.cbxCuenta.Name = "cbxCuenta";
            this.cbxCuenta.Size = new System.Drawing.Size(232, 28);
            this.cbxCuenta.TabIndex = 47;
            this.cbxCuenta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 480);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxCuenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_quitar_producto);
            this.Controls.Add(this.btn_agregar_producto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbxProductos);
            this.Controls.Add(this.cbxDomicilio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedido";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 30, 30);
            this.Text = "Administración de productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxDomicilio;
        private System.Windows.Forms.ComboBox cbxProductos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btn_agregar_producto;
        private System.Windows.Forms.Button btn_quitar_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxCuenta;
    }
}