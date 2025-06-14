namespace MenuPrincipalClub.Forms
{
    partial class frmConfiguracion
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            txtServidor = new TextBox();
            txtPuerto = new TextBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            txtBaseDatos = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 71);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Servidor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 107);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Puerto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 155);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 201);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Contrasena";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(194, 244);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 4;
            label5.Text = "Base Datos";
            // 
            // button1
            // 
            button1.Location = new Point(326, 316);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(421, 63);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(100, 23);
            txtServidor.TabIndex = 6;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(421, 99);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(100, 23);
            txtPuerto.TabIndex = 7;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(421, 147);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 8;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(421, 193);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 9;
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Location = new Point(421, 236);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Size = new Size(100, 23);
            txtBaseDatos.TabIndex = 10;
            // 
            // frmConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBaseDatos);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(txtPuerto);
            Controls.Add(txtServidor);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmConfiguracion";
            Text = "frmConfiguracion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox txtServidor;
        private TextBox txtPuerto;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private TextBox txtBaseDatos;
    }
}