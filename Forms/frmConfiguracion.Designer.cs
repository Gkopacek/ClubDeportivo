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
            lblServidor = new Label();
            lblPuerto = new Label();
            lblUsuario = new Label();
            lblContrasena = new Label();
            lblBaseDatos = new Label();
            btnAceptar = new Button();
            txtServidor = new TextBox();
            txtPuerto = new TextBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            txtBaseDatos = new TextBox();
            SuspendLayout();
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Location = new Point(194, 71);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(50, 15);
            lblServidor.TabIndex = 0;
            lblServidor.Text = "Servidor";
            // 
            // lblPuerto
            // 
            lblPuerto.AutoSize = true;
            lblPuerto.Location = new Point(194, 107);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(42, 15);
            lblPuerto.TabIndex = 1;
            lblPuerto.Text = "Puerto";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(194, 155);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(194, 201);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contrasena";
            // 
            // lblBaseDatos
            // 
            lblBaseDatos.AutoSize = true;
            lblBaseDatos.Location = new Point(194, 244);
            lblBaseDatos.Name = "lblBaseDatos";
            lblBaseDatos.Size = new Size(64, 15);
            lblBaseDatos.TabIndex = 4;
            lblBaseDatos.Text = "Base Datos";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(326, 316);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
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
            Controls.Add(btnAceptar);
            Controls.Add(lblBaseDatos);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(lblPuerto);
            Controls.Add(lblServidor);
            Name = "frmConfiguracion";
            Text = "Configuracion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServidor;
        private Label lblPuerto;
        private Label lblUsuario;
        private Label lblContrasena;
        private Label lblBaseDatos;
        private Button btnAceptar;
        private TextBox txtServidor;
        private TextBox txtPuerto;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private TextBox txtBaseDatos;
    }
}