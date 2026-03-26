namespace WinMySQL.Vistas
{
    partial class FrmMateria
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
            label1 = new Label();
            label2 = new Label();
            txtMateria = new TextBox();
            txtClaveMateria = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 128);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 1;
            label2.Text = "Clave de Materia";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(30, 53);
            txtMateria.Margin = new Padding(4, 5, 4, 5);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(537, 31);
            txtMateria.TabIndex = 2;
            // 
            // txtClaveMateria
            // 
            txtClaveMateria.Location = new Point(30, 178);
            txtClaveMateria.Margin = new Padding(4, 5, 4, 5);
            txtClaveMateria.Name = "txtClaveMateria";
            txtClaveMateria.Size = new Size(357, 31);
            txtClaveMateria.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(461, 177);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(107, 38);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmMateria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 292);
            Controls.Add(btnAceptar);
            Controls.Add(txtClaveMateria);
            Controls.Add(txtMateria);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMateria";
            Text = "Materia";
            Load += FrmMateria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMateria;
        private TextBox txtClaveMateria;
        private Button btnAceptar;
    }
}