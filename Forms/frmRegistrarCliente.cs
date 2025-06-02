using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuPrincipalClub.Entidades;
using MenuPrincipalClub.Servicios;

namespace MenuPrincipalClub.Forms
{
    public partial class frmRegistrarCliente : Form
    {
        public frmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {


            // Instanciar un objeto Cliente usando el constructor
            Cliente nuevoCliente = new Cliente(         // Si NCliente es string, aunque en la BD es INT autoincrementado
                nombre: txtNombre.Text,
                apellido: txtApellido.Text,
                documento: txtDocumento.Text,
                email: txtEmail.Text,
                telefono: txtTelefono.Text

            );

            ServicioCliente agregarCliente = new ServicioCliente();

            agregarCliente.RegistrarCliente(nuevoCliente);
        }
    }
}
