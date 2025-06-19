namespace MenuPrincipalClub.Forms
{
    partial class frmCarnet
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
            txtDocumento = new Label();
            txtNombre = new Label();
            txtFecha = new Label();
            SuspendLayout();
            // 
            // txtDocumento
            // 
            txtDocumento.AutoSize = true;
            txtDocumento.Location = new Point(293, 116);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(38, 15);
            txtDocumento.TabIndex = 0;
            txtDocumento.Text = "label1";
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Location = new Point(293, 196);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(38, 15);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "label2";
            // 
            // txtFecha
            // 
            txtFecha.AutoSize = true;
            txtFecha.Location = new Point(293, 281);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(38, 15);
            txtFecha.TabIndex = 2;
            txtFecha.Text = "label3";
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFecha);
            Controls.Add(txtNombre);
            Controls.Add(txtDocumento);
            Name = "frmCarnet";
            Text = "frmCarnet";
            Load += frmCarnet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtDocumento;
        private Label txtNombre;
        private Label txtFecha;
    }
}