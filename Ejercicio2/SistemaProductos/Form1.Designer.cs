namespace SistemaProductos
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
            flowAcciones = new FlowLayoutPanel();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnMostrarLista = new Button();
            btnLimpiar = new Button();
            flowBuscar = new FlowLayoutPanel();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            lblResultadoBusqueda = new Label();
            dgvProductos = new DataGridView();
            txtStock = new TextBox();
            lblStock = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            groupDatos = new GroupBox();
            flowAcciones.SuspendLayout();
            flowBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupDatos.SuspendLayout();
            SuspendLayout();
            // 
            // flowAcciones
            // 
            flowAcciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowAcciones.BackColor = Color.FromArgb(192, 255, 255);
            flowAcciones.Controls.Add(btnInsertar);
            flowAcciones.Controls.Add(btnActualizar);
            flowAcciones.Controls.Add(btnMostrarLista);
            flowAcciones.Controls.Add(btnLimpiar);
            flowAcciones.Location = new Point(12, 124);
            flowAcciones.Name = "flowAcciones";
            flowAcciones.Padding = new Padding(0, 2, 0, 2);
            flowAcciones.Size = new Size(449, 42);
            flowAcciones.TabIndex = 1;
            flowAcciones.WrapContents = false;
            // 
            // btnInsertar
            // 
            btnInsertar.AutoSize = true;
            btnInsertar.Location = new Point(3, 5);
            btnInsertar.Margin = new Padding(3, 3, 10, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 33);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.AutoSize = true;
            btnActualizar.Location = new Point(110, 5);
            btnActualizar.Margin = new Padding(3, 3, 10, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 33);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnMostrarLista
            // 
            btnMostrarLista.AutoSize = true;
            btnMostrarLista.Location = new Point(217, 5);
            btnMostrarLista.Margin = new Padding(3, 3, 10, 3);
            btnMostrarLista.Name = "btnMostrarLista";
            btnMostrarLista.Size = new Size(110, 33);
            btnMostrarLista.TabIndex = 2;
            btnMostrarLista.Text = "Mostrar lista";
            btnMostrarLista.UseVisualStyleBackColor = true;
            btnMostrarLista.Click += btnMostrarLista_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSize = true;
            btnLimpiar.Location = new Point(340, 5);
            btnLimpiar.Margin = new Padding(3, 3, 10, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 33);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // flowBuscar
            // 
            flowBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowBuscar.BackColor = Color.FromArgb(192, 255, 255);
            flowBuscar.Controls.Add(lblBuscar);
            flowBuscar.Controls.Add(txtBuscar);
            flowBuscar.Controls.Add(btnBuscar);
            flowBuscar.Controls.Add(lblResultadoBusqueda);
            flowBuscar.Location = new Point(12, 172);
            flowBuscar.Name = "flowBuscar";
            flowBuscar.Padding = new Padding(0, 2, 0, 2);
            flowBuscar.Size = new Size(523, 56);
            flowBuscar.TabIndex = 2;
            flowBuscar.WrapContents = false;
            flowBuscar.Paint += flowBuscar_Paint;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(3, 10);
            lblBuscar.Margin = new Padding(3, 8, 6, 0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(55, 20);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar:";
            lblBuscar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(67, 5);
            txtBuscar.Margin = new Padding(3, 3, 10, 3);
            txtBuscar.MinimumSize = new Size(180, 0);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "nombre";
            txtBuscar.Size = new Size(220, 27);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.AutoSize = true;
            btnBuscar.Location = new Point(300, 5);
            btnBuscar.Margin = new Padding(3, 3, 16, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 33);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblResultadoBusqueda
            // 
            lblResultadoBusqueda.AutoSize = true;
            lblResultadoBusqueda.ForeColor = SystemColors.GrayText;
            lblResultadoBusqueda.Location = new Point(413, 10);
            lblResultadoBusqueda.Margin = new Padding(3, 8, 3, 0);
            lblResultadoBusqueda.Name = "lblResultadoBusqueda";
            lblResultadoBusqueda.Size = new Size(0, 20);
            lblResultadoBusqueda.TabIndex = 3;
            lblResultadoBusqueda.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.DarkGray;
            dgvProductos.BorderStyle = BorderStyle.Fixed3D;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.GridColor = SystemColors.ControlLight;
            dgvProductos.Location = new Point(12, 246);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(576, 178);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(290, 62);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(90, 27);
            txtStock.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(230, 65);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(48, 20);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(95, 62);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 27);
            txtPrecio.TabIndex = 2;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(13, 65);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(95, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(384, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(13, 31);
            lblNombre.Margin = new Padding(3, 6, 3, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // groupDatos
            // 
            groupDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupDatos.BackColor = Color.FromArgb(192, 255, 255);
            groupDatos.Controls.Add(lblNombre);
            groupDatos.Controls.Add(txtNombre);
            groupDatos.Controls.Add(lblPrecio);
            groupDatos.Controls.Add(txtPrecio);
            groupDatos.Controls.Add(lblStock);
            groupDatos.Controls.Add(txtStock);
            groupDatos.Location = new Point(12, 12);
            groupDatos.Name = "groupDatos";
            groupDatos.Padding = new Padding(10, 8, 10, 10);
            groupDatos.Size = new Size(576, 106);
            groupDatos.TabIndex = 0;
            groupDatos.TabStop = false;
            groupDatos.Text = "Datos del producto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(600, 440);
            Controls.Add(dgvProductos);
            Controls.Add(flowBuscar);
            Controls.Add(flowAcciones);
            Controls.Add(groupDatos);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(520, 380);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos — EF";
            Load += Form1_Load;
            flowAcciones.ResumeLayout(false);
            flowAcciones.PerformLayout();
            flowBuscar.ResumeLayout(false);
            flowBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupDatos.ResumeLayout(false);
            groupDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowAcciones;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnMostrarLista;
        private Button btnLimpiar;
        private FlowLayoutPanel flowBuscar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label lblResultadoBusqueda;
        private DataGridView dgvProductos;
        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtNombre;
        private Label lblNombre;
        private GroupBox groupDatos;
    }
}
