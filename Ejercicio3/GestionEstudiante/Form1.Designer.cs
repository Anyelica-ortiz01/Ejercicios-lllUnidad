namespace Ejercicio3;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblNombre = new Label();
        lblCarrera = new Label();
        lblPromedio = new Label();
        lblBuscarCarrera = new Label();
        txtNombre = new TextBox();
        txtCarrera = new TextBox();
        txtPromedio = new TextBox();
        txtBuscarCarrera = new TextBox();
        btnRegistrar = new Button();
        btnMostrarTodos = new Button();
        btnBuscar = new Button();
        dgvEstudiantes = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
        SuspendLayout();
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Location = new Point(14, 27);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(67, 20);
        lblNombre.TabIndex = 21;
        lblNombre.Text = "Nombre:";
        // 
        // lblCarrera
        // 
        lblCarrera.AutoSize = true;
        lblCarrera.Location = new Point(306, 27);
        lblCarrera.Name = "lblCarrera";
        lblCarrera.Size = new Size(60, 20);
        lblCarrera.TabIndex = 19;
        lblCarrera.Text = "Carrera:";
        // 
        // lblPromedio
        // 
        lblPromedio.AutoSize = true;
        lblPromedio.Location = new Point(14, 82);
        lblPromedio.Name = "lblPromedio";
        lblPromedio.Size = new Size(77, 20);
        lblPromedio.TabIndex = 17;
        lblPromedio.Text = "Promedio:";
        // 
        // lblBuscarCarrera
        // 
        lblBuscarCarrera.AutoSize = true;
        lblBuscarCarrera.Location = new Point(14, 130);
        lblBuscarCarrera.Name = "lblBuscarCarrera";
        lblBuscarCarrera.Size = new Size(105, 20);
        lblBuscarCarrera.TabIndex = 13;
        lblBuscarCarrera.Text = "Buscar carrera:";
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(87, 20);
        txtNombre.Margin = new Padding(3, 4, 3, 4);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(205, 27);
        txtNombre.TabIndex = 20;
        // 
        // txtCarrera
        // 
        txtCarrera.Location = new Point(372, 20);
        txtCarrera.Margin = new Padding(3, 4, 3, 4);
        txtCarrera.Name = "txtCarrera";
        txtCarrera.Size = new Size(239, 27);
        txtCarrera.TabIndex = 18;
        // 
        // txtPromedio
        // 
        txtPromedio.Location = new Point(97, 79);
        txtPromedio.Margin = new Padding(3, 4, 3, 4);
        txtPromedio.Name = "txtPromedio";
        txtPromedio.Size = new Size(91, 27);
        txtPromedio.TabIndex = 16;
        // 
        // txtBuscarCarrera
        // 
        txtBuscarCarrera.Location = new Point(125, 130);
        txtBuscarCarrera.Margin = new Padding(3, 4, 3, 4);
        txtBuscarCarrera.Name = "txtBuscarCarrera";
        txtBuscarCarrera.Size = new Size(228, 27);
        txtBuscarCarrera.TabIndex = 12;
        // 
        // btnRegistrar
        // 
        btnRegistrar.Location = new Point(250, 74);
        btnRegistrar.Margin = new Padding(3, 4, 3, 4);
        btnRegistrar.Name = "btnRegistrar";
        btnRegistrar.Size = new Size(103, 36);
        btnRegistrar.TabIndex = 15;
        btnRegistrar.Text = "Registrar";
        btnRegistrar.UseVisualStyleBackColor = true;
        btnRegistrar.Click += btnRegistrar_Click;
        // 
        // btnMostrarTodos
        // 
        btnMostrarTodos.Location = new Point(388, 74);
        btnMostrarTodos.Margin = new Padding(3, 4, 3, 4);
        btnMostrarTodos.Name = "btnMostrarTodos";
        btnMostrarTodos.Size = new Size(183, 36);
        btnMostrarTodos.TabIndex = 14;
        btnMostrarTodos.Text = "Mostrar por promedio";
        btnMostrarTodos.UseVisualStyleBackColor = true;
        btnMostrarTodos.Click += btnMostrarTodos_Click;
        // 
        // btnBuscar
        // 
        btnBuscar.Location = new Point(437, 130);
        btnBuscar.Margin = new Padding(3, 4, 3, 4);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(91, 36);
        btnBuscar.TabIndex = 11;
        btnBuscar.Text = "Buscar";
        btnBuscar.UseVisualStyleBackColor = true;
        btnBuscar.Click += btnBuscar_Click;
        // 
        // dgvEstudiantes
        // 
        dgvEstudiantes.AllowUserToAddRows = false;
        dgvEstudiantes.AllowUserToDeleteRows = false;
        dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvEstudiantes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
        dgvEstudiantes.Location = new Point(14, 196);
        dgvEstudiantes.Margin = new Padding(3, 4, 3, 4);
        dgvEstudiantes.Name = "dgvEstudiantes";
        dgvEstudiantes.ReadOnly = true;
        dgvEstudiantes.RowHeadersVisible = false;
        dgvEstudiantes.RowHeadersWidth = 51;
        dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEstudiantes.Size = new Size(594, 284);
        dgvEstudiantes.TabIndex = 10;
        dgvEstudiantes.CellContentClick += dgvEstudiantes_CellContentClick;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.HeaderText = "Id";
        dataGridViewTextBoxColumn1.MinimumWidth = 6;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.HeaderText = "Nombre";
        dataGridViewTextBoxColumn2.MinimumWidth = 6;
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.HeaderText = "Carrera";
        dataGridViewTextBoxColumn3.MinimumWidth = 6;
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.HeaderText = "Promedio";
        dataGridViewTextBoxColumn4.MinimumWidth = 6;
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Azure;
        ClientSize = new Size(633, 508);
        Controls.Add(dgvEstudiantes);
        Controls.Add(btnBuscar);
        Controls.Add(txtBuscarCarrera);
        Controls.Add(lblBuscarCarrera);
        Controls.Add(btnMostrarTodos);
        Controls.Add(btnRegistrar);
        Controls.Add(txtPromedio);
        Controls.Add(lblPromedio);
        Controls.Add(txtCarrera);
        Controls.Add(lblCarrera);
        Controls.Add(txtNombre);
        Controls.Add(lblNombre);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de estudiantes";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblNombre;
    private Label lblCarrera;
    private Label lblPromedio;
    private Label lblBuscarCarrera;
    private TextBox txtNombre;
    private TextBox txtCarrera;
    private TextBox txtPromedio;
    private TextBox txtBuscarCarrera;
    private Button btnRegistrar;
    private Button btnMostrarTodos;
    private Button btnBuscar;
    private DataGridView dgvEstudiantes;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
}
