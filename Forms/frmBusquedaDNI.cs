using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuPrincipalClub.Servicios;
using MenuPrincipalClub;

namespace MenuPrincipalClub.Forms
{
    public partial class frmBusquedaDNI : Form
    {
        public frmBusquedaDNI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verificamos que existe un usuario con el documento ingresado
            ServicioCliente servicioCliente = new ServicioCliente();
            var usuario = servicioCliente.ObtenerPersonaPorDocumento(textBox1.Text);
            //si lo encontramos emitimos un mensaje y lo mostramos en el grid del frm principal

            if (usuario != null)
            {
                MessageBox.Show("Usuario encontrado: " + usuario.Nombre, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Obtener el formulario principal de forma segura
                
                
            }
            else
            {
                MessageBox.Show("No se encontró un usuario con ese documento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
