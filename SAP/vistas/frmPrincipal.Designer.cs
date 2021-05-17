
namespace SAP.vistas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_form7 = new System.Windows.Forms.Button();
            this.btn_form6 = new System.Windows.Forms.Button();
            this.btn_form5 = new System.Windows.Forms.Button();
            this.btn_form4 = new System.Windows.Forms.Button();
            this.btn_form2 = new System.Windows.Forms.Button();
            this.btn_form1 = new System.Windows.Forms.Button();
            this.btn_form3 = new System.Windows.Forms.Button();
            this.pnlRenderizar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 63);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "En este sistema puedes generar la fecturación básica para una pizzeria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido a Pizza Carlo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAP.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btn_form7);
            this.panel2.Controls.Add(this.btn_form6);
            this.panel2.Controls.Add(this.btn_form5);
            this.panel2.Controls.Add(this.btn_form4);
            this.panel2.Controls.Add(this.btn_form2);
            this.panel2.Controls.Add(this.btn_form1);
            this.panel2.Controls.Add(this.btn_form3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 480);
            this.panel2.TabIndex = 1;
            // 
            // btn_form7
            // 
            this.btn_form7.BackColor = System.Drawing.Color.Firebrick;
            this.btn_form7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_form7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_form7.ForeColor = System.Drawing.Color.White;
            this.btn_form7.Location = new System.Drawing.Point(12, 428);
            this.btn_form7.Name = "btn_form7";
            this.btn_form7.Size = new System.Drawing.Size(154, 35);
            this.btn_form7.TabIndex = 16;
            this.btn_form7.Text = "Estados";
            this.btn_form7.UseVisualStyleBackColor = false;
            this.btn_form7.Click += new System.EventHandler(this.renderizar_Click);
            // 
            // btn_form6
            // 
            this.btn_form6.BackColor = System.Drawing.Color.Firebrick;
            this.btn_form6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_form6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_form6.ForeColor = System.Drawing.Color.White;
            this.btn_form6.Location = new System.Drawing.Point(12, 360);
            this.btn_form6.Name = "btn_form6";
            this.btn_form6.Size = new System.Drawing.Size(154, 35);
            this.btn_form6.TabIndex = 18;
            this.btn_form6.Text = "Cuentas";
            this.btn_form6.UseVisualStyleBackColor = false;
            this.btn_form6.Click += new System.EventHandler(this.renderizar_Click);
            // 
            // btn_form5
            // 
            this.btn_form5.BackColor = System.Drawing.Color.Firebrick;
            this.btn_form5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_form5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_form5.ForeColor = System.Drawing.Color.White;
            this.btn_form5.Location = new System.Drawing.Point(12, 292);
            this.btn_form5.Name = "btn_form5";
            this.btn_form5.Size = new System.Drawing.Size(154, 35);
            this.btn_form5.TabIndex = 19;
            this.btn_form5.Text = "Clientes";
            this.btn_form5.UseVisualStyleBackColor = false;
            this.btn_form5.Click += new System.EventHandler(this.renderizar_Click);
            // 
            // btn_form4
            // 
            this.btn_form4.BackColor = System.Drawing.Color.Firebrick;
            this.btn_form4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_form4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_form4.ForeColor = System.Drawing.Color.White;
            this.btn_form4.Location = new System.Drawing.Point(12, 224);
            this.btn_form4.Name = "btn_form4";
            this.btn_form4.Size = new System.Drawing.Size(154, 35);
            this.btn_form4.TabIndex = 17;
            this.btn_form4.Text = "Productos";
            this.btn_form4.UseVisualStyleBackColor = false;
            this.btn_form4.Click += new System.EventHandler(this.renderizar_Click);
            // 
            // btn_form2
            // 
            this.btn_form2.BackColor = System.Drawing.Color.Firebrick;
            this.btn_form2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_form2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_form2.ForeColor = System.Drawing.Color.White;
            this.btn_form2.Location = new System.Drawing.Point(12, 88);
            this.btn_form2.Name = "btn_form2";
            this.btn_form2.Size = new System.Drawing.Size(154, 35);
            this.btn_form2.TabIndex = 14;
            this.btn_form2.Text = "Nuevo Pedido";
            this.btn_form2.UseVisualStyleBackColor = false;
            this.btn_form2.Click += new System.EventHandler(this.renderizar_Click);
            // 
            // btn_form1
            // 
            this.btn_form1.BackColor = System.Drawing.Color.Firebrick;
            this.btn_form1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_form1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_form1.ForeColor = System.Drawing.Color.White;
            this.btn_form1.Location = new System.Drawing.Point(12, 20);
            this.btn_form1.Name = "btn_form1";
            this.btn_form1.Size = new System.Drawing.Size(154, 35);
            this.btn_form1.TabIndex = 21;
            this.btn_form1.Text = "Listado pedidos";
            this.btn_form1.UseVisualStyleBackColor = false;
            this.btn_form1.Click += new System.EventHandler(this.renderizar_Click);
            // 
            // btn_form3
            // 
            this.btn_form3.BackColor = System.Drawing.Color.Firebrick;
            this.btn_form3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_form3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_form3.ForeColor = System.Drawing.Color.White;
            this.btn_form3.Location = new System.Drawing.Point(12, 156);
            this.btn_form3.Name = "btn_form3";
            this.btn_form3.Size = new System.Drawing.Size(154, 35);
            this.btn_form3.TabIndex = 15;
            this.btn_form3.Text = "Movimientos";
            this.btn_form3.UseVisualStyleBackColor = false;
            this.btn_form3.Click += new System.EventHandler(this.renderizar_Click);
            // 
            // pnlRenderizar
            // 
            this.pnlRenderizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRenderizar.Location = new System.Drawing.Point(182, 63);
            this.pnlRenderizar.Name = "pnlRenderizar";
            this.pnlRenderizar.Size = new System.Drawing.Size(780, 480);
            this.pnlRenderizar.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 543);
            this.Controls.Add(this.pnlRenderizar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPrincipal";
            this.Text = "Pizza Carlo - Sistema Administrador";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_form2;
        private System.Windows.Forms.Button btn_form5;
        private System.Windows.Forms.Button btn_form6;
        private System.Windows.Forms.Button btn_form4;
        private System.Windows.Forms.Button btn_form7;
        private System.Windows.Forms.Button btn_form3;
        private System.Windows.Forms.Panel pnlRenderizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_form1;
    }
}