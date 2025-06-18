namespace MenuPrincipalClub.Forms
{
    partial class frmRegistrarPago
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
            SuspendLayout();
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(399, 351);
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
            cboTipo.Items.AddRange(new object[] { "actividad", "mensualidad" });
            cboTipo.Location = new Point(388, 284);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(195, 351);
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
            lblTipo.Size = new Size(59, 15);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Concepto";
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
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(218, 144);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
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
            btnVerificar.Location = new Point(573, 65);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 10;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // frmRegistrarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "frmRegistrarPago";
            Text = "Registrar Pago";
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
    }
}