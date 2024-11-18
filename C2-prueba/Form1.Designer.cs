namespace C2_prueba
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            txtNombre = new TextBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            cbxTipoMovimiento = new ComboBox();
            nupCantidadMovimiento = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            label6 = new Label();
            txtID = new TextBox();
            groupBox2 = new GroupBox();
            dgvProductos = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidadMovimiento).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 153);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombres del producto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(178, 150);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 23);
            txtNombre.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(cbxTipoMovimiento);
            groupBox1.Controls.Add(nupCantidadMovimiento);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 360);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 128);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion de movimientos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(383, 28);
            button3.Name = "button3";
            button3.Size = new Size(123, 28);
            button3.TabIndex = 5;
            button3.Text = "Modificar stock";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // cbxTipoMovimiento
            // 
            cbxTipoMovimiento.Items.AddRange(new object[] { "Comprar", "Vender" });
            cbxTipoMovimiento.Location = new Point(166, 76);
            cbxTipoMovimiento.Name = "cbxTipoMovimiento";
            cbxTipoMovimiento.Size = new Size(139, 23);
            cbxTipoMovimiento.TabIndex = 6;
            // 
            // nupCantidadMovimiento
            // 
            nupCantidadMovimiento.Location = new Point(166, 33);
            nupCantidadMovimiento.Name = "nupCantidadMovimiento";
            nupCantidadMovimiento.Size = new Size(139, 23);
            nupCantidadMovimiento.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 76);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 1;
            label5.Text = "Tipo Mocimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 35);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "Cantidad";
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(383, 37);
            button1.Name = "button1";
            button1.Size = new Size(123, 32);
            button1.TabIndex = 7;
            button1.Text = "Agregrar Producto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 112);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 8;
            label6.Text = "Identificador Producto";
            label6.Click += label6_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(178, 110);
            txtID.Name = "txtID";
            txtID.Size = new Size(149, 23);
            txtID.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvProductos);
            groupBox2.Controls.Add(button1);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(536, 282);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gestion de Productos";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(10, 122);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(520, 154);
            dgvProductos.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(100, 19);
            label1.Name = "label1";
            label1.Size = new Size(370, 37);
            label1.TabIndex = 11;
            label1.Text = "Sistema Gestion de Productos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(580, 507);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestion de Producto";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidadMovimiento).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private Button button1;
        private Button button3;
        private ComboBox cbxTipoMovimiento;
        private NumericUpDown nupCantidadMovimiento;
        private Label label5;
        private Label label4;
        private Label label6;
        private TextBox txtID;
        private GroupBox groupBox2;
        private Label label1;
        private DataGridView dgvProductos;
    }
}
