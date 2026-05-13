namespace SistemaUniversitario
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
            txtCarrera = new TextBox();
            btnGuardarCarrera = new Button();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtEdad = new TextBox();
            label4 = new Label();
            cbCarreras = new ComboBox();
            btnGuardarEstudiante = new Button();
            btnMostrar = new Button();
            cbFiltro = new ComboBox();
            btnFiltrar = new Button();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 59);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Carrera";
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(85, 51);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(100, 23);
            txtCarrera.TabIndex = 1;
            // 
            // btnGuardarCarrera
            // 
            btnGuardarCarrera.Location = new Point(24, 99);
            btnGuardarCarrera.Name = "btnGuardarCarrera";
            btnGuardarCarrera.Size = new Size(117, 23);
            btnGuardarCarrera.TabIndex = 2;
            btnGuardarCarrera.Text = "Guardar Carrera";
            btnGuardarCarrera.UseVisualStyleBackColor = true;
            btnGuardarCarrera.Click += btnGuardarCarrera_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 151);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 204);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(85, 196);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 281);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Carrera";
            // 
            // cbCarreras
            // 
            cbCarreras.FormattingEnabled = true;
            cbCarreras.Location = new Point(85, 273);
            cbCarreras.Name = "cbCarreras";
            cbCarreras.Size = new Size(121, 23);
            cbCarreras.TabIndex = 8;
            // 
            // btnGuardarEstudiante
            // 
            btnGuardarEstudiante.Location = new Point(24, 338);
            btnGuardarEstudiante.Name = "btnGuardarEstudiante";
            btnGuardarEstudiante.Size = new Size(117, 23);
            btnGuardarEstudiante.TabIndex = 9;
            btnGuardarEstudiante.Text = "Guardar Estudiante";
            btnGuardarEstudiante.UseVisualStyleBackColor = true;
            btnGuardarEstudiante.Click += btnGuardarEstudiante_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(24, 397);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 10;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // cbFiltro
            // 
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Location = new Point(136, 397);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(121, 23);
            cbFiltro.TabIndex = 11;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(326, 396);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 12;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(370, 51);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(383, 310);
            dgvDatos.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDatos);
            Controls.Add(btnFiltrar);
            Controls.Add(cbFiltro);
            Controls.Add(btnMostrar);
            Controls.Add(btnGuardarEstudiante);
            Controls.Add(cbCarreras);
            Controls.Add(label4);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(btnGuardarCarrera);
            Controls.Add(txtCarrera);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCarrera;
        private Button btnGuardarCarrera;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtEdad;
        private Label label4;
        private ComboBox cbCarreras;
        private Button btnGuardarEstudiante;
        private Button btnMostrar;
        private ComboBox cbFiltro;
        private Button btnFiltrar;
        private DataGridView dgvDatos;
    }
}
