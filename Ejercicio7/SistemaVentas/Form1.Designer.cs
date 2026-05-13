namespace SistemaVentas
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
            label1 = new Label();
            txtCliente = new TextBox();
            label2 = new Label();
            txtProducto = new TextBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            btnGuardar = new Button();
            btnMostrar = new Button();
            btnTotal = new Button();
            btnMasvendido = new Button();
            dgvVentas = new DataGridView();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 58);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(88, 50);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 116);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(88, 108);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 173);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(88, 165);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 232);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(88, 224);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(28, 303);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(130, 303);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 9;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(28, 357);
            btnTotal.Name = "btnTotal";
            btnTotal.RightToLeft = RightToLeft.No;
            btnTotal.Size = new Size(85, 23);
            btnTotal.TabIndex = 10;
            btnTotal.Text = "Total General";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnMasvendido
            // 
            btnMasvendido.Location = new Point(130, 357);
            btnMasvendido.Name = "btnMasvendido";
            btnMasvendido.Size = new Size(86, 23);
            btnMasvendido.TabIndex = 11;
            btnMasvendido.Text = "Más Vendido";
            btnMasvendido.UseVisualStyleBackColor = true;
            btnMasvendido.Click += btnMasvendido_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(327, 50);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(401, 276);
            dgvVentas.TabIndex = 12;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(380, 368);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 13;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(dgvVentas);
            Controls.Add(btnMasvendido);
            Controls.Add(btnTotal);
            Controls.Add(btnMostrar);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(txtProducto);
            Controls.Add(label2);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCliente;
        private Label label2;
        private TextBox txtProducto;
        private Label label3;
        private TextBox txtCantidad;
        private Label label4;
        private TextBox txtPrecio;
        private Button btnGuardar;
        private Button btnMostrar;
        private Button btnTotal;
        private Button btnMasvendido;
        private DataGridView dgvVentas;
        private Label lblResultado;
    }
}
