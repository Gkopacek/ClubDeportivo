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

namespace MenuPrincipalClub.Forms
{
    public partial class frmRegistrarSocio : Form
    {
        public frmRegistrarSocio()
        {
            InitializeComponent();
        }

        private void frmRegistrarSocio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verificamos si existe el usuario en la db
            //si existe, mostramos un mensaje de error
            //si no existe, lo agregamos a la db
            var servicioCliente = new MenuPrincipalClub.Servicios.ServicioCliente();
            var documento = textBox1.Text.Trim();
            var usuario = servicioCliente.ObtenerUsuarioPorDocumento(documento);
            if (usuario != null)
            {
                MessageBox.Show("El usuario ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //verificamos si el combo box es "Socio" o "No Socio", si es socio hacemos el proceso de registro socio


                if (comboBox1.Text == "Socio")

                {
                    // Aquí puedes agregar el código para registrar el nuevo socio
                    // Por ejemplo, llamar a un método en ServicioCliente para agregar el usuario
                    var nuevoUsuario = new Socio
                    {
                        Nombre = textBox2.Text.Trim(),
                        Documento = documento,
                        Estado = Estado.Activo,
                        Fecha_Inscripcion = DateTime.Now // Asignar la fecha actual
                    };
                    servicioCliente.InsertarUsuario(nuevoUsuario); // Asegúrate de que este método exista en ServicioCliente

                    frmRegistrarSocio.ActiveForm.Close();
                }

                if (comboBox1.Text == "No Socio")
                {
                    //hacemos un message box que el registro de no socio no esta implementado
                    MessageBox.Show("El registro de No Socio no está implementado en esta versión.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            //luego se cierra el form

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cerramos el form
            frmRegistrarSocio.ActiveForm.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
