namespace MenuPrincipalClub
{
    partial class frmLogin
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
            btnIngresar = new Button();
            btnLimpiar = new Button();
            lblBienvenida = new Label();
            lblUsuario = new Label();
            lblContrasenia = new Label();
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(249, 284);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(460, 284);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(295, 19);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(155, 15);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "Bienvenido a club deportivo";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(123, 112);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(123, 166);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(67, 15);
            lblContrasenia.TabIndex = 4;
            lblContrasenia.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(249, 109);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(286, 23);
            txtUsuario.TabIndex = 5;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(249, 163);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(286, 23);
            txtContrasenia.TabIndex = 6;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(lblBienvenida);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnLimpiar;
        private Label lblBienvenida;
        private Label lblUsuario;
        private Label lblContrasenia;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
    }
}
