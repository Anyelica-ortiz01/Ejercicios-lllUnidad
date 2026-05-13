namespace RegistroClientes;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblTelefono = new Label();
        txtTelefono = new TextBox();
        lblCorreo = new Label();
        txtCorreo = new TextBox();
        btnGuardar = new Button();
        btnEliminar = new Button();
        btnActualizar = new Button();
        dgvClientes = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
        SuspendLayout();
        lblNombre.AutoSize = true;
        lblNombre.Location = new Point(76, 27);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(67, 20);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "Nombre:";
        lblNombre.TextAlign = ContentAlignment.MiddleLeft;
        lblNombre.Click += lblNombre_Click;
        txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtNombre.BackColor = Color.White;
        txtNombre.Location = new Point(169, 20);
        txtNombre.Margin = new Padding(3, 4, 3, 4);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(330, 27);
        txtNombre.TabIndex = 1;
        lblTelefono.AutoSize = true;
        lblTelefono.Location = new Point(73, 62);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new Size(70, 20);
        lblTelefono.TabIndex = 0;
        lblTelefono.Text = "Teléfono:";
        txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtTelefono.BackColor = Color.White;
        txtTelefono.Location = new Point(169, 55);
        txtTelefono.Margin = new Padding(3, 4, 3, 4);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new Size(330, 27);
        txtTelefono.TabIndex = 2;
        lblCorreo.AutoSize = true;
        lblCorreo.Location = new Point(73, 96);
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Size = new Size(57, 20);
        lblCorreo.TabIndex = 0;
        lblCorreo.Text = "Correo:";
        txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtCorreo.BackColor = Color.White;
        txtCorreo.Location = new Point(169, 93);
        txtCorreo.Margin = new Padding(3, 4, 3, 4);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.Size = new Size(330, 27);
        txtCorreo.TabIndex = 3;
        btnGuardar.BackColor = Color.White;
        btnGuardar.Location = new Point(76, 150);
        btnGuardar.Margin = new Padding(3, 4, 3, 4);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(99, 42);
        btnGuardar.TabIndex = 4;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += btnGuardar_Click;
        btnEliminar.BackColor = Color.White;
        btnEliminar.Location = new Point(262, 150);
        btnEliminar.Margin = new Padding(3, 4, 3, 4);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(100, 42);
        btnEliminar.TabIndex = 5;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = false;
        btnEliminar.Click += btnEliminar_Click;
        btnActualizar.BackColor = Color.White;
        btnActualizar.Location = new Point(438, 150);
        btnActualizar.Margin = new Padding(3, 4, 3, 4);
        btnActualizar.Name = "btnActualizar";
        btnActualizar.Size = new Size(103, 42);
        btnActualizar.TabIndex = 6;
        btnActualizar.Text = "Actualizar";
        btnActualizar.UseVisualStyleBackColor = false;
        btnActualizar.Click += btnActualizar_Click;
        dgvClientes.AllowUserToAddRows = false;
        dgvClientes.AllowUserToDeleteRows = false;
        dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvClientes.BackgroundColor = SystemColors.ControlLight;
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvClientes.Location = new Point(35, 211);
        dgvClientes.Margin = new Padding(3, 4, 3, 4);
        dgvClientes.MultiSelect = false;
        dgvClientes.Name = "dgvClientes";
        dgvClientes.ReadOnly = true;
        dgvClientes.RowHeadersVisible = false;
        dgvClientes.RowHeadersWidth = 51;
        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClientes.Size = new Size(546, 246);
        dgvClientes.TabIndex = 7;
        dgvClientes.CellContentClick += dgvClientes_CellContentClick;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.MistyRose;
        ClientSize = new Size(626, 480);
        Controls.Add(dgvClientes);
        Controls.Add(btnActualizar);
        Controls.Add(btnEliminar);
        Controls.Add(btnGuardar);
        Controls.Add(txtCorreo);
        Controls.Add(lblCorreo);
        Controls.Add(txtTelefono);
        Controls.Add(lblTelefono);
        Controls.Add(txtNombre);
        Controls.Add(lblNombre);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Clientes";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblTelefono;
    private TextBox txtTelefono;
    private Label lblCorreo;
    private TextBox txtCorreo;
    private Button btnGuardar;
    private Button btnEliminar;
    private Button btnActualizar;
    private DataGridView dgvClientes;
}
