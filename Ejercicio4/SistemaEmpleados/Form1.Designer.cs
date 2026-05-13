namespace SistemaEmpleados
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
            btnGuardar = new Button();
            btnMostrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnTotal = new Button();
            btnMayor = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblResultados = new Label();
            dgvEmpleados = new DataGridView();
            txtNombre = new TextBox();
            txtCargo = new TextBox();
            txtSalario = new TextBox();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(31, 301);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(31, 346);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(31, 398);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(152, 301);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(152, 346);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(102, 23);
            btnTotal.TabIndex = 4;
            btnTotal.Text = "Total Salarios";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnMayor
            // 
            btnMayor.Location = new Point(152, 398);
            btnMayor.Name = "btnMayor";
            btnMayor.Size = new Size(102, 23);
            btnMayor.TabIndex = 5;
            btnMayor.Text = "Salario Más Alto";
            btnMayor.UseVisualStyleBackColor = true;
            btnMayor.Click += btnMayor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 53);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 95);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Cargo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 137);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "Salario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 184);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 9;
            label4.Text = "Id";
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(413, 382);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(59, 15);
            lblResultados.TabIndex = 10;
            lblResultados.Text = "Resultado";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(347, 45);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(366, 279);
            dgvEmpleados.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 12;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(98, 87);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 23);
            txtCargo.TabIndex = 13;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(98, 129);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 14;
            // 
            // txtId
            // 
            txtId.Location = new Point(98, 176);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(txtSalario);
            Controls.Add(txtCargo);
            Controls.Add(txtNombre);
            Controls.Add(dgvEmpleados);
            Controls.Add(lblResultados);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMayor);
            Controls.Add(btnTotal);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnMostrar);
            Controls.Add(btnGuardar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnMostrar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnTotal;
        private Button btnMayor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblResultados;
        private DataGridView dgvEmpleados;
        private TextBox txtNombre;
        private TextBox txtCargo;
        private TextBox txtSalario;
        private TextBox txtId;
    }
}
