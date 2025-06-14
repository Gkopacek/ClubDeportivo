using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuPrincipalClub.Datos;

namespace MenuPrincipalClub.Forms
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string servidor = txtServidor.Text;
            string puerto = txtPuerto.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            string baseDatos = txtBaseDatos.Text;

            try
            {
                Conexion.Configurar(servidor, puerto, usuario, contrasena, baseDatos);

                //testeamos la conexion
                using (var conexion = Conexion.CrearConexion())
                {
                    conexion.Open();
                    // Si llegamos aquí, la conexión fue exitosa
                }

                MessageBox.Show("Configuración exitosa.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ///
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al configurar la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
