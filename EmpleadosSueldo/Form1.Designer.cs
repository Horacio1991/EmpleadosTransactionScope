namespace EmpleadosSueldo
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
            txtApellidoNombre = new TextBox();
            txtDni = new TextBox();
            txtSueldoBruto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAgregar = new Button();
            btnConfirmarCambios = new Button();
            btnListar = new Button();
            dgvEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // txtApellidoNombre
            // 
            txtApellidoNombre.BorderStyle = BorderStyle.FixedSingle;
            txtApellidoNombre.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoNombre.Location = new Point(221, 41);
            txtApellidoNombre.Name = "txtApellidoNombre";
            txtApellidoNombre.Size = new Size(307, 31);
            txtApellidoNombre.TabIndex = 0;
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDni.Location = new Point(221, 115);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(307, 31);
            txtDni.TabIndex = 1;
            // 
            // txtSueldoBruto
            // 
            txtSueldoBruto.BorderStyle = BorderStyle.FixedSingle;
            txtSueldoBruto.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSueldoBruto.Location = new Point(221, 189);
            txtSueldoBruto.Name = "txtSueldoBruto";
            txtSueldoBruto.Size = new Size(307, 31);
            txtSueldoBruto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 43);
            label1.Name = "label1";
            label1.Size = new Size(184, 22);
            label1.TabIndex = 3;
            label1.Text = "Apellido y Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 117);
            label2.Name = "label2";
            label2.Size = new Size(48, 22);
            label2.TabIndex = 4;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 191);
            label3.Name = "label3";
            label3.Size = new Size(129, 22);
            label3.TabIndex = 5;
            label3.Text = "Sueldo Bruto:";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(14, 260);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 39);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnConfirmarCambios
            // 
            btnConfirmarCambios.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmarCambios.Location = new Point(159, 260);
            btnConfirmarCambios.Name = "btnConfirmarCambios";
            btnConfirmarCambios.Size = new Size(224, 39);
            btnConfirmarCambios.TabIndex = 7;
            btnConfirmarCambios.Text = "Confirmar Cambios";
            btnConfirmarCambios.UseVisualStyleBackColor = true;
            btnConfirmarCambios.Click += btnConfirmarCambios_Click;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListar.Location = new Point(389, 260);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(139, 39);
            btnListar.TabIndex = 8;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(14, 322);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(684, 187);
            dgvEmpleados.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 521);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnListar);
            Controls.Add(btnConfirmarCambios);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSueldoBruto);
            Controls.Add(txtDni);
            Controls.Add(txtApellidoNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApellidoNombre;
        private TextBox txtDni;
        private TextBox txtSueldoBruto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAgregar;
        private Button btnConfirmarCambios;
        private Button btnListar;
        private DataGridView dgvEmpleados;
    }
}
