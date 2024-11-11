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
            lstProductos = new ListBox();
            button1 = new Button();
            label6 = new Label();
            txtID = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidadMovimiento).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 93);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombres del producto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(251, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(cbxTipoMovimiento);
            groupBox1.Controls.Add(nupCantidadMovimiento);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(55, 300);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 128);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion de movimientos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(383, 27);
            button3.Name = "button3";
            button3.Size = new Size(123, 23);
            button3.TabIndex = 5;
            button3.Text = "Modificar stock";
            button3.UseVisualStyleBackColor = true;
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
            nupCantidadMovimiento.Location = new Point(166, 27);
            nupCantidadMovimiento.Name = "nupCantidadMovimiento";
            nupCantidadMovimiento.Size = new Size(139, 23);
            nupCantidadMovimiento.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 79);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 1;
            label5.Text = "Tipo Mocimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 35);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "Cantidad";
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 15;
            lstProductos.Location = new Point(65, 185);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(305, 94);
            lstProductos.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(448, 50);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 7;
            button1.Text = "Agregrar Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 52);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 8;
            label6.Text = "Identificador Producto";
            label6.Click += label6_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(251, 50);
            txtID.Name = "txtID";
            txtID.Size = new Size(119, 23);
            txtID.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(55, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(536, 282);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gestion de Productos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(lstProductos);
            Controls.Add(groupBox1);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Sistema Gestion de Producto";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidadMovimiento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private ListBox lstProductos;
        private Button button1;
        private Button button3;
        private ComboBox cbxTipoMovimiento;
        private NumericUpDown nupCantidadMovimiento;
        private Label label5;
        private Label label4;
        private Label label6;
        private TextBox txtID;
        private GroupBox groupBox2;
    }
}
