namespace MenuPrincipalClub

   
{
    partial class frmPrincipal
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
            btnMostrarAfiliados = new Button();
            lblMenuOpciones = new Label();
            dbgrdAfiliadosDeudores = new DataGridView();
            btnRegistrarPersona = new Button();
            btnListaDeudores = new Button();
            btnRealizarPago = new Button();
            ((System.ComponentModel.ISupportInitialize)dbgrdAfiliadosDeudores).BeginInit();
            SuspendLayout();
            // 
            // btnMostrarAfiliados
            // 
            btnMostrarAfiliados.Location = new Point(92, 82);
            btnMostrarAfiliados.Name = "btnMostrarAfiliados";
            btnMostrarAfiliados.Size = new Size(173, 59);
            btnMostrarAfiliados.TabIndex = 0;
            btnMostrarAfiliados.Text = "Mostrar Afiliados";
            btnMostrarAfiliados.UseVisualStyleBackColor = true;
            btnMostrarAfiliados.Click += btnMostrarAfiliados_Click;
            // 
            // lblMenuOpciones
            // 
            lblMenuOpciones.AutoSize = true;
            lblMenuOpciones.Location = new Point(322, 43);
            lblMenuOpciones.Name = "lblMenuOpciones";
            lblMenuOpciones.Size = new Size(107, 15);
            lblMenuOpciones.TabIndex = 1;
            lblMenuOpciones.Text = "Menu de Opciones";
            lblMenuOpciones.Click += lblMenuOpciones_Click;
            // 
            // dbgrdAfiliadosDeudores
            // 
            dbgrdAfiliadosDeudores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbgrdAfiliadosDeudores.Location = new Point(69, 275);
            dbgrdAfiliadosDeudores.Name = "dbgrdAfiliadosDeudores";
            dbgrdAfiliadosDeudores.Size = new Size(666, 150);
            dbgrdAfiliadosDeudores.TabIndex = 2;
            dbgrdAfiliadosDeudores.CellContentClick += dbgrdAfiliadosDeudores_CellContentClick;
            // 
            // btnRegistrarPersona
            // 
            btnRegistrarPersona.Location = new Point(313, 82);
            btnRegistrarPersona.Name = "btnRegistrarPersona";
            btnRegistrarPersona.Size = new Size(171, 59);
            btnRegistrarPersona.TabIndex = 3;
            btnRegistrarPersona.Text = "Resgistrar Persona";
            btnRegistrarPersona.UseVisualStyleBackColor = true;
            btnRegistrarPersona.Click += btnRegistrarPersona_Click;
            // 
            // btnListaDeudores
            // 
            btnListaDeudores.Location = new Point(94, 176);
            btnListaDeudores.Name = "btnListaDeudores";
            btnListaDeudores.Size = new Size(171, 60);
            btnListaDeudores.TabIndex = 6;
            btnListaDeudores.Text = "Lista Deudores";
            btnListaDeudores.UseVisualStyleBackColor = true;
            btnListaDeudores.Click += btnListaDeudores_Click_1;
            // 
            // btnRealizarPago
            // 
            btnRealizarPago.Location = new Point(313, 175);
            btnRealizarPago.Name = "btnRealizarPago";
            btnRealizarPago.Size = new Size(171, 61);
            btnRealizarPago.TabIndex = 7;
            btnRealizarPago.Text = "Realizar Pago";
            btnRealizarPago.UseVisualStyleBackColor = true;
            btnRealizarPago.Click += btnRealizarPago_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRealizarPago);
            Controls.Add(btnListaDeudores);
            Controls.Add(btnRegistrarPersona);
            Controls.Add(dbgrdAfiliadosDeudores);
            Controls.Add(lblMenuOpciones);
            Controls.Add(btnMostrarAfiliados);
            Name = "frmPrincipal";
            Text = "Menu Principal";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dbgrdAfiliadosDeudores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrarAfiliados;
        private Label lblMenuOpciones;
        public DataGridView dbgrdAfiliadosDeudores;
        private Button btnRegistrarPersona;
        private Button btnListaDeudores;
        private Button btnRealizarPago;
    }
}