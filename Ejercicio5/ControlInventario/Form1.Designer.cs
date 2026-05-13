namespace ControlInventario
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
            lblProducto = new Label();
            txtProducto = new TextBox();
            txtCategoria = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            lblCategoria = new Label();
            label2 = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            btnRegistrar = new Button();
            btnStock = new Button();
            btnValorTotal = new Button();
            dvgInventario = new DataGridView();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvgInventario).BeginInit();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(20, 49);
            lblProducto.Margin = new Padding(2, 0, 2, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(133, 49);
            txtProducto.Margin = new Padding(2, 2, 2, 2);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(182, 27);
            txtProducto.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(133, 98);
            txtCategoria.Margin = new Padding(2, 2, 2, 2);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(182, 27);
            txtCategoria.TabIndex = 2;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(133, 147);
            txtCantidad.Margin = new Padding(2, 2, 2, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(121, 27);
            txtCantidad.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(133, 197);
            txtPrecio.Margin = new Padding(2, 2, 2, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 27);
            txtPrecio.TabIndex = 4;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(20, 98);
            lblCategoria.Margin = new Padding(2, 0, 2, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 191);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(30, 197);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(22, 147);
            lblCantidad.Margin = new Padding(2, 0, 2, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(448, 49);
            btnRegistrar.Margin = new Padding(2, 2, 2, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 44);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(448, 122);
            btnStock.Margin = new Padding(2, 2, 2, 2);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(112, 45);
            btnStock.TabIndex = 10;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnValorTotal
            // 
            btnValorTotal.Location = new Point(448, 197);
            btnValorTotal.Margin = new Padding(2, 2, 2, 2);
            btnValorTotal.Name = "btnValorTotal";
            btnValorTotal.Size = new Size(112, 41);
            btnValorTotal.TabIndex = 11;
            btnValorTotal.Text = "ValorTotal";
            btnValorTotal.UseVisualStyleBackColor = true;
            btnValorTotal.Click += btnValorTotal_Click;
            // 
            // dvgInventario
            // 
            dvgInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgInventario.Location = new Point(41, 279);
            dvgInventario.Margin = new Padding(2, 2, 2, 2);
            dvgInventario.Name = "dvgInventario";
            dvgInventario.RowHeadersWidth = 62;
            dvgInventario.Size = new Size(544, 214);
            dvgInventario.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(118, 539);
            txtTotal.Margin = new Padding(2, 2, 2, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(121, 27);
            txtTotal.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(640, 585);
            Controls.Add(txtTotal);
            Controls.Add(dvgInventario);
            Controls.Add(btnValorTotal);
            Controls.Add(btnStock);
            Controls.Add(btnRegistrar);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(label2);
            Controls.Add(lblCategoria);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(txtCategoria);
            Controls.Add(txtProducto);
            Controls.Add(lblProducto);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvgInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private TextBox txtProducto;
        private TextBox txtCategoria;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Label lblCategoria;
        private Label label2;
        private Label lblPrecio;
        private Label lblCantidad;
        private Button btnRegistrar;
        private Button btnStock;
        private Button btnValorTotal;
        private DataGridView dvgInventario;
        private TextBox txtTotal;
    }
}
