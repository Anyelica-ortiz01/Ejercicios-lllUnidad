namespace FacturacionTransaccion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblDetalle = new Label();
            dgvDetalle = new DataGridView();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(14, 20);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(91, 16);
            txtCliente.Margin = new Padding(3, 4, 3, 4);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(342, 27);
            txtCliente.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(446, 20);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(503, 16);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(171, 27);
            dtpFecha.TabIndex = 3;
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Location = new Point(14, 59);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(221, 20);
            lblDetalle.TabIndex = 6;
            lblDetalle.Text = "DetalleFactura (varios registros):";
            // 
            // dgvDetalle
            // 
            dgvDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalle.BackgroundColor = SystemColors.ButtonFace;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colProducto, colCantidad, colPrecio });
            dgvDetalle.GridColor = SystemColors.InactiveBorder;
            dgvDetalle.Location = new Point(14, 85);
            dgvDetalle.Margin = new Padding(3, 4, 3, 4);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.Size = new Size(887, 390);
            dgvDetalle.TabIndex = 4;
            dgvDetalle.CellContentClick += dgvDetalle_CellContentClick;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.Width = 350;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.Width = 120;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.Width = 120;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegistrar.Location = new Point(763, 547);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(137, 37);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar factura";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(914, 600);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvDetalle);
            Controls.Add(lblDetalle);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(683, 518);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 9 - Facturación con transacción";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblDetalle;
        private DataGridView dgvDetalle;
        private Button btnRegistrar;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
    }
}
