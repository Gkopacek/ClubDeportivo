namespace MenuPrincipalClub.Forms
{
    partial class frmRegistrarSocio
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
            btnPagar = new Button();
            txtMonto = new TextBox();
            lblMonto = new Label();
            cboTipo = new ComboBox();
            btnCancelar = new Button();
            lblTipo = new Label();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnVerificar = new Button();
            btnRegistrarSocio = new Button();
            lblNotificacion = new Label();
            lblNo_Nombre = new Label();
            lblNo_Monto = new Label();
            lblNo_Tipo = new Label();
            lblNo_Documento = new Label();
            SuspendLayout();
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(409, 351);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(100, 48);
            btnPagar.TabIndex = 0;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(388, 220);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 1;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(218, 220);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Efectivo", "Transferencia" });
            cboTipo.Location = new Point(388, 284);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(218, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 48);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(218, 284);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(218, 68);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 6;
            lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(388, 65);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 23);
            txtDocumento.TabIndex = 7;
            txtDocumento.Click += txtDocumento_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(218, 144);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label4_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(388, 141);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 9;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(634, 65);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 10;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.Location = new Point(409, 351);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(100, 48);
            btnRegistrarSocio.TabIndex = 11;
            btnRegistrarSocio.Text = "Registrar Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = true;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // lblNotificacion
            // 
            lblNotificacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotificacion.ForeColor = Color.Black;
            lblNotificacion.Location = new Point(218, 20);
            lblNotificacion.Name = "lblNotificacion";
            lblNotificacion.Size = new Size(506, 42);
            lblNotificacion.TabIndex = 12;
            lblNotificacion.Text = "Para registrar un nuevo socio agregue Nombre, Monto y Tipo de pago.";
            // 
            // lblNo_Nombre
            // 
            lblNo_Nombre.AutoSize = true;
            lblNo_Nombre.ForeColor = Color.Red;
            lblNo_Nombre.Location = new Point(494, 149);
            lblNo_Nombre.Name = "lblNo_Nombre";
            lblNo_Nombre.Size = new Size(110, 15);
            lblNo_Nombre.TabIndex = 13;
            lblNo_Nombre.Text = "* Ingrese el nombre";
            // 
            // lblNo_Monto
            // 
            lblNo_Monto.AutoSize = true;
            lblNo_Monto.ForeColor = Color.Red;
            lblNo_Monto.Location = new Point(494, 228);
            lblNo_Monto.Name = "lblNo_Monto";
            lblNo_Monto.Size = new Size(104, 15);
            lblNo_Monto.TabIndex = 14;
            lblNo_Monto.Text = "* Ingrese el monto";
            // 
            // lblNo_Tipo
            // 
            lblNo_Tipo.AutoSize = true;
            lblNo_Tipo.ForeColor = Color.Red;
            lblNo_Tipo.Location = new Point(515, 292);
            lblNo_Tipo.Name = "lblNo_Tipo";
            lblNo_Tipo.Size = new Size(99, 15);
            lblNo_Tipo.TabIndex = 15;
            lblNo_Tipo.Text = "* Elija una opción";
            // 
            // lblNo_Documento
            // 
            lblNo_Documento.AutoSize = true;
            lblNo_Documento.ForeColor = Color.Red;
            lblNo_Documento.Location = new Point(494, 69);
            lblNo_Documento.Name = "lblNo_Documento";
            lblNo_Documento.Size = new Size(130, 15);
            lblNo_Documento.TabIndex = 16;
            lblNo_Documento.Text = "* Ingrese el documento";
            // 
            // frmRegistrarSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNo_Documento);
            Controls.Add(lblNo_Tipo);
            Controls.Add(lblNo_Monto);
            Controls.Add(lblNo_Nombre);
            Controls.Add(lblNotificacion);
            Controls.Add(btnRegistrarSocio);
            Controls.Add(btnVerificar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(lblTipo);
            Controls.Add(btnCancelar);
            Controls.Add(cboTipo);
            Controls.Add(lblMonto);
            Controls.Add(txtMonto);
            Controls.Add(btnPagar);
            Name = "frmRegistrarSocio";
            Text = "frmRegistrarSocio";
            Load += frmRegistrarPago_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPagar;
        private TextBox txtMonto;
        private Label lblMonto;
        private ComboBox cboTipo;
        private Button btnCancelar;
        private Label lblTipo;
        private Label lblDocumento;
        private TextBox txtDocumento;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnVerificar;
        private Button btnRegistrarSocio;
        private Label lblNotificacion;
        private Label lblNo_Nombre;
        private Label lblNo_Monto;
        private Label lblNo_Tipo;
        private Label lblNo_Documento;
    }
}