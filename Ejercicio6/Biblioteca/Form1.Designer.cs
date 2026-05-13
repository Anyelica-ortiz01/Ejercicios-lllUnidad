namespace Biblioteca
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
            lblTitulo = new Label();
            lblAutor = new Label();
            lblAño = new Label();
            lblDisponible = new Label();
            lblBuscarAutor = new Label();
            lblId = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtAño = new TextBox();
            txtBuscarAutor = new TextBox();
            txtId = new TextBox();
            chkDisponible = new CheckBox();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnMostrarDisponibles = new Button();
            btnBuscarAutor = new Button();
            dgvLibros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(26, 27);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(47, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(26, 68);
            lblAutor.Margin = new Padding(2, 0, 2, 0);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(46, 20);
            lblAutor.TabIndex = 1;
            lblAutor.Text = "Autor";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(26, 114);
            lblAño.Margin = new Padding(2, 0, 2, 0);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(36, 20);
            lblAño.TabIndex = 2;
            lblAño.Text = "Año";
            // 
            // lblDisponible
            // 
            lblDisponible.AutoSize = true;
            lblDisponible.Location = new Point(26, 157);
            lblDisponible.Margin = new Padding(2, 0, 2, 0);
            lblDisponible.Name = "lblDisponible";
            lblDisponible.Size = new Size(81, 20);
            lblDisponible.TabIndex = 3;
            lblDisponible.Text = "Disponible";
            // 
            // lblBuscarAutor
            // 
            lblBuscarAutor.AutoSize = true;
            lblBuscarAutor.Location = new Point(26, 196);
            lblBuscarAutor.Margin = new Padding(2, 0, 2, 0);
            lblBuscarAutor.Name = "lblBuscarAutor";
            lblBuscarAutor.Size = new Size(91, 20);
            lblBuscarAutor.TabIndex = 4;
            lblBuscarAutor.Text = "Buscar autor";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(26, 237);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 5;
            lblId.Text = "Id";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(148, 22);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(121, 27);
            txtTitulo.TabIndex = 6;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(148, 68);
            txtAutor.Margin = new Padding(2);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(121, 27);
            txtAutor.TabIndex = 7;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(148, 114);
            txtAño.Margin = new Padding(2);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(121, 27);
            txtAño.TabIndex = 8;
            // 
            // txtBuscarAutor
            // 
            txtBuscarAutor.Location = new Point(148, 196);
            txtBuscarAutor.Margin = new Padding(2);
            txtBuscarAutor.Name = "txtBuscarAutor";
            txtBuscarAutor.Size = new Size(121, 27);
            txtBuscarAutor.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.Location = new Point(148, 237);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(121, 27);
            txtId.TabIndex = 10;
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.Location = new Point(170, 157);
            chkDisponible.Margin = new Padding(2);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(103, 24);
            chkDisponible.TabIndex = 11;
            chkDisponible.Text = "Disponible";
            chkDisponible.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(380, 27);
            btnRegistrar.Margin = new Padding(2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(106, 40);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(380, 89);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(106, 45);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar disponibilidad";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnMostrarDisponibles
            // 
            btnMostrarDisponibles.Location = new Point(380, 153);
            btnMostrarDisponibles.Margin = new Padding(2);
            btnMostrarDisponibles.Name = "btnMostrarDisponibles";
            btnMostrarDisponibles.Size = new Size(106, 60);
            btnMostrarDisponibles.TabIndex = 14;
            btnMostrarDisponibles.Text = "Mostrar disponibles";
            btnMostrarDisponibles.UseVisualStyleBackColor = true;
            btnMostrarDisponibles.Click += btnMostrarDisponibles_Click;
            // 
            // btnBuscarAutor
            // 
            btnBuscarAutor.Location = new Point(380, 227);
            btnBuscarAutor.Margin = new Padding(2);
            btnBuscarAutor.Name = "btnBuscarAutor";
            btnBuscarAutor.Size = new Size(106, 47);
            btnBuscarAutor.TabIndex = 15;
            btnBuscarAutor.Text = "Buscar autor";
            btnBuscarAutor.UseVisualStyleBackColor = true;
            btnBuscarAutor.Click += btnBuscarAutor_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.BackgroundColor = SystemColors.AppWorkspace;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(26, 312);
            dgvLibros.Margin = new Padding(2);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 62;
            dgvLibros.Size = new Size(548, 199);
            dgvLibros.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(640, 559);
            Controls.Add(dgvLibros);
            Controls.Add(btnBuscarAutor);
            Controls.Add(btnMostrarDisponibles);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(chkDisponible);
            Controls.Add(txtId);
            Controls.Add(txtBuscarAutor);
            Controls.Add(txtAño);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblId);
            Controls.Add(lblBuscarAutor);
            Controls.Add(lblDisponible);
            Controls.Add(lblAño);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Sistema de biblioteca";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblAutor;
        private Label lblAño;
        private Label lblDisponible;
        private Label lblBuscarAutor;
        private Label lblId;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtAño;
        private TextBox txtBuscarAutor;
        private TextBox txtId;
        private CheckBox chkDisponible;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnMostrarDisponibles;
        private Button btnBuscarAutor;
        private DataGridView dgvLibros;
    }
}
