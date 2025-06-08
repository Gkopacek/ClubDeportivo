namespace MenuPrincipalClub.Forms
{
    partial class frmRegistrarCliente
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblDocumento = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            btnAgregarCliente = new Button();
            chkHacerSocio = new CheckBox();
            btnRegistrarSocio = new Button();
            lblTipo = new Label();
            lblMonto = new Label();
            label1 = new Label();
            chkentregoApto = new CheckBox();
            txtTipo = new TextBox();
            txtMonto = new TextBox();
            lblcantidad = new Label();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(46, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(46, 82);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(46, 127);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(46, 174);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(46, 222);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(135, 79);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(135, 124);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 23);
            txtDocumento.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(135, 171);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(135, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 9;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(261, 110);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(106, 48);
            btnAgregarCliente.TabIndex = 10;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // chkHacerSocio
            // 
            chkHacerSocio.AutoSize = true;
            chkHacerSocio.Location = new Point(135, 257);
            chkHacerSocio.Name = "chkHacerSocio";
            chkHacerSocio.Size = new Size(89, 19);
            chkHacerSocio.TabIndex = 11;
            chkHacerSocio.Text = "Hacer Socio";
            chkHacerSocio.UseVisualStyleBackColor = true;
            chkHacerSocio.CheckedChanged += chkHacerSocio_CheckedChanged;
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.Location = new Point(268, 358);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(106, 48);
            btnRegistrarSocio.TabIndex = 12;
            btnRegistrarSocio.Text = "Hacer Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = true;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(70, 343);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 13;
            lblTipo.Text = "Tipo";
            lblTipo.Click += lblTipo_Click;
            // 
            // lblMonto
            // 
            lblMonto.Location = new Point(0, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(100, 23);
            lblMonto.TabIndex = 20;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 19;
            // 
            // chkentregoApto
            // 
            chkentregoApto.AutoSize = true;
            chkentregoApto.Location = new Point(135, 293);
            chkentregoApto.Name = "chkentregoApto";
            chkentregoApto.Size = new Size(109, 19);
            chkentregoApto.TabIndex = 18;
            chkentregoApto.Text = "Apto Entregado";
            chkentregoApto.UseVisualStyleBackColor = true;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(135, 340);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 1;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(135, 383);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 0;
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(70, 386);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(43, 15);
            lblcantidad.TabIndex = 22;
            lblcantidad.Text = "Monto";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(261, 189);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(106, 48);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmRegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 285);
            Controls.Add(btnLimpiar);
            Controls.Add(lblcantidad);
            Controls.Add(txtMonto);
            Controls.Add(txtTipo);
            Controls.Add(chkentregoApto);
            Controls.Add(label1);
            Controls.Add(lblMonto);
            Controls.Add(lblTipo);
            Controls.Add(btnRegistrarSocio);
            Controls.Add(chkHacerSocio);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDocumento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmRegistrarCliente";
            Text = "frmRegistrarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDocumento;
        private Label lblTelefono;
        private Label lblEmail;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Button btnAgregarCliente;
        private CheckBox chkHacerSocio;
        private Button btnRegistrarSocio;
        private Label lblTipo;
        private Label lblMonto;
        private Label label1;
        private CheckBox chkentregoApto;
        private TextBox txtTipo;
        private TextBox txtMonto;
        private Label lblcantidad;
        private Button btnLimpiar;
        // private CheckBox chkAptoEntregado;
    }
}