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
            btnRegistrar = new Button();
            lblDocumento = new Label();
            lblNombreYapellido = new Label();
            txtDocumento = new TextBox();
            txtNombreYapellido = new TextBox();
            btnCancelar = new Button();
            cboTipo = new ComboBox();
            lblTipo = new Label();
            chkAptoFisico = new CheckBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(453, 328);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(129, 48);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(184, 98);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 1;
            lblDocumento.Text = "Documento";
            // 
            // lblNombreYapellido
            // 
            lblNombreYapellido.AutoSize = true;
            lblNombreYapellido.Location = new Point(184, 226);
            lblNombreYapellido.Name = "lblNombreYapellido";
            lblNombreYapellido.Size = new Size(107, 15);
            lblNombreYapellido.TabIndex = 2;
            lblNombreYapellido.Text = "Nombre y Apellido";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(406, 95);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(201, 23);
            txtDocumento.TabIndex = 3;
            // 
            // txtNombreYapellido
            // 
            txtNombreYapellido.Location = new Point(406, 218);
            txtNombreYapellido.Name = "txtNombreYapellido";
            txtNombreYapellido.Size = new Size(201, 23);
            txtNombreYapellido.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(174, 328);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 48);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Socio", "No Socio" });
            cboTipo.Location = new Point(406, 142);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(201, 23);
            cboTipo.TabIndex = 6;
            cboTipo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(184, 145);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "Tipo";
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Location = new Point(644, 144);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(85, 19);
            chkAptoFisico.TabIndex = 9;
            chkAptoFisico.Text = "Apto Fisico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkAptoFisico);
            Controls.Add(lblTipo);
            Controls.Add(cboTipo);
            Controls.Add(btnCancelar);
            Controls.Add(txtNombreYapellido);
            Controls.Add(txtDocumento);
            Controls.Add(lblNombreYapellido);
            Controls.Add(lblDocumento);
            Controls.Add(btnRegistrar);
            Name = "frmRegistrarSocio";
            Text = "Registrar Socio";
            Load += frmRegistrarSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Label lblDocumento;
        private Label lblNombreYapellido;
        private TextBox txtDocumento;
        private TextBox txtNombreYapellido;
        private Button btnCancelar;
        private ComboBox cboTipo;
        private Label lblTipo;
        private CheckBox chkAptoFisico;
    }
}