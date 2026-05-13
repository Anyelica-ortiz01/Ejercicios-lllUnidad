namespace SistemaMedico;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblNombre = new Label();
        lblEdad = new Label();
        lblDiagnostico = new Label();
        lblBuscarNombre = new Label();
        txtNombre = new TextBox();
        txtEdad = new TextBox();
        txtDiagnostico = new TextBox();
        txtBuscarNombre = new TextBox();
        btnRegistrar = new Button();
        btnBuscarNombre = new Button();
        btnMayores60 = new Button();
        dgvPacientes = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
        SuspendLayout();
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Location = new Point(14, 20);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(67, 20);
        lblNombre.TabIndex = 21;
        lblNombre.Text = "Nombre:";
        // 
        // lblEdad
        // 
        lblEdad.AutoSize = true;
        lblEdad.Location = new Point(306, 20);
        lblEdad.Name = "lblEdad";
        lblEdad.Size = new Size(46, 20);
        lblEdad.TabIndex = 19;
        lblEdad.Text = "Edad:";
        // 
        // lblDiagnostico
        // 
        lblDiagnostico.AutoSize = true;
        lblDiagnostico.Location = new Point(14, 65);
        lblDiagnostico.Name = "lblDiagnostico";
        lblDiagnostico.Size = new Size(92, 20);
        lblDiagnostico.TabIndex = 17;
        lblDiagnostico.Text = "Diagnóstico:";
        // 
        // lblBuscarNombre
        // 
        lblBuscarNombre.AutoSize = true;
        lblBuscarNombre.Location = new Point(14, 119);
        lblBuscarNombre.Name = "lblBuscarNombre";
        lblBuscarNombre.Size = new Size(111, 20);
        lblBuscarNombre.TabIndex = 14;
        lblBuscarNombre.Text = "Buscar nombre:";
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(82, 16);
        txtNombre.Margin = new Padding(3, 4, 3, 4);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(205, 27);
        txtNombre.TabIndex = 20;
        // 
        // txtEdad
        // 
        txtEdad.Location = new Point(354, 16);
        txtEdad.Margin = new Padding(3, 4, 3, 4);
        txtEdad.Name = "txtEdad";
        txtEdad.Size = new Size(68, 27);
        txtEdad.TabIndex = 18;
        // 
        // txtDiagnostico
        // 
        txtDiagnostico.Location = new Point(105, 61);
        txtDiagnostico.Margin = new Padding(3, 4, 3, 4);
        txtDiagnostico.Name = "txtDiagnostico";
        txtDiagnostico.Size = new Size(399, 27);
        txtDiagnostico.TabIndex = 16;
        // 
        // txtBuscarNombre
        // 
        txtBuscarNombre.Location = new Point(134, 116);
        txtBuscarNombre.Margin = new Padding(3, 4, 3, 4);
        txtBuscarNombre.Name = "txtBuscarNombre";
        txtBuscarNombre.Size = new Size(251, 27);
        txtBuscarNombre.TabIndex = 13;
        // 
        // btnRegistrar
        // 
        btnRegistrar.Location = new Point(523, 59);
        btnRegistrar.Margin = new Padding(3, 4, 3, 4);
        btnRegistrar.Name = "btnRegistrar";
        btnRegistrar.Size = new Size(103, 36);
        btnRegistrar.TabIndex = 15;
        btnRegistrar.Text = "Registrar";
        btnRegistrar.UseVisualStyleBackColor = true;
        btnRegistrar.Click += btnRegistrar_Click;
        // 
        // btnBuscarNombre
        // 
        btnBuscarNombre.Location = new Point(392, 150);
        btnBuscarNombre.Margin = new Padding(3, 4, 3, 4);
        btnBuscarNombre.Name = "btnBuscarNombre";
        btnBuscarNombre.Size = new Size(91, 36);
        btnBuscarNombre.TabIndex = 12;
        btnBuscarNombre.Text = "Buscar";
        btnBuscarNombre.UseVisualStyleBackColor = true;
        btnBuscarNombre.Click += btnBuscarNombre_Click;
        // 
        // btnMayores60
        // 
        btnMayores60.Location = new Point(496, 150);
        btnMayores60.Margin = new Padding(3, 4, 3, 4);
        btnMayores60.Name = "btnMayores60";
        btnMayores60.Size = new Size(137, 36);
        btnMayores60.TabIndex = 11;
        btnMayores60.Text = "Mayores de 60";
        btnMayores60.UseVisualStyleBackColor = true;
        btnMayores60.Click += btnMayores60_Click;
        // 
        // dgvPacientes
        // 
        dgvPacientes.AllowUserToAddRows = false;
        dgvPacientes.AllowUserToDeleteRows = false;
        dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPacientes.BackgroundColor = SystemColors.Control;
        dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPacientes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
        dgvPacientes.Location = new Point(14, 194);
        dgvPacientes.Margin = new Padding(3, 4, 3, 4);
        dgvPacientes.Name = "dgvPacientes";
        dgvPacientes.ReadOnly = true;
        dgvPacientes.RowHeadersVisible = false;
        dgvPacientes.RowHeadersWidth = 51;
        dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPacientes.Size = new Size(613, 294);
        dgvPacientes.TabIndex = 10;
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
        dataGridViewTextBoxColumn3.HeaderText = "Edad";
        dataGridViewTextBoxColumn3.MinimumWidth = 6;
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.HeaderText = "Diagnostico";
        dataGridViewTextBoxColumn4.MinimumWidth = 6;
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 192, 255);
        ClientSize = new Size(645, 515);
        Controls.Add(dgvPacientes);
        Controls.Add(btnMayores60);
        Controls.Add(btnBuscarNombre);
        Controls.Add(txtBuscarNombre);
        Controls.Add(lblBuscarNombre);
        Controls.Add(btnRegistrar);
        Controls.Add(txtDiagnostico);
        Controls.Add(lblDiagnostico);
        Controls.Add(txtEdad);
        Controls.Add(lblEdad);
        Controls.Add(txtNombre);
        Controls.Add(lblNombre);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Sistema médico";
        ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblNombre;
    private Label lblEdad;
    private Label lblDiagnostico;
    private Label lblBuscarNombre;
    private TextBox txtNombre;
    private TextBox txtEdad;
    private TextBox txtDiagnostico;
    private TextBox txtBuscarNombre;
    private Button btnRegistrar;
    private Button btnBuscarNombre;
    private Button btnMayores60;
    private DataGridView dgvPacientes;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
}
