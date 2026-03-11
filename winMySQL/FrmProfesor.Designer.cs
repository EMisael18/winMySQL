namespace WinMySQL.Vistas
{
    partial class FrmProfesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            txtPaterno = new TextBox();
            txtMaterno = new TextBox();
            txtArea = new TextBox();
            txtMaterias = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 137);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 13;
            label5.Text = "Numero de Materias";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 137);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 12;
            label4.Text = "Area de trabajo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(646, 33);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 11;
            label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 10;
            label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(24, 65);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 31);
            txtNombre.TabIndex = 15;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(333, 65);
            txtPaterno.Margin = new Padding(4, 5, 4, 5);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(248, 31);
            txtPaterno.TabIndex = 16;
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(646, 65);
            txtMaterno.Margin = new Padding(4, 5, 4, 5);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(248, 31);
            txtMaterno.TabIndex = 17;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(24, 167);
            txtArea.Margin = new Padding(4, 5, 4, 5);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(248, 31);
            txtArea.TabIndex = 18;
            // 
            // txtMaterias
            // 
            txtMaterias.Location = new Point(333, 167);
            txtMaterias.Margin = new Padding(4, 5, 4, 5);
            txtMaterias.Name = "txtMaterias";
            txtMaterias.Size = new Size(248, 31);
            txtMaterias.TabIndex = 19;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(222, 228);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(167, 38);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmProfesor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 308);
            Controls.Add(btnAceptar);
            Controls.Add(txtMaterias);
            Controls.Add(txtArea);
            Controls.Add(txtMaterno);
            Controls.Add(txtPaterno);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmProfesor";
            Text = "Profesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtPaterno;
        private TextBox txtMaterno;
        private TextBox txtArea;
        private TextBox txtMaterias;
        private Button btnAceptar;
    }
}