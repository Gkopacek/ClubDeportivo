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
            chkAptoFisico.Enabled = false; // Deshabilitamos el checkbox de Apto Físico al inicio
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos si el usuario es "Socio" o "No Socio" si es socio habilitamos el checkbox
            if (cboTipo.Text == "Socio")
            {
                chkAptoFisico.Enabled = true; // Habilitamos el checkbox de Apto Físico
            }
            else
            {
                chkAptoFisico.Enabled = false; // Deshabilitamos el checkbox de Apto Físico
                chkAptoFisico.Checked = false; // Desmarcamos el checkbox si no es Socio
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //verificamos si existe el usuario en la db
            //si existe, mostramos un mensaje de error
            //si no existe, lo agregamos a la db
            var servicioCliente = new MenuPrincipalClub.Servicios.ServicioCliente();
            var documento = txtDocumento.Text.Trim();
            var usuario = servicioCliente.ObtenerUsuarioPorDocumento(documento);
            if (usuario != null)
            {
                MessageBox.Show("El usuario ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //verificamos si el combo box es "Socio" o "No Socio", si es socio hacemos el proceso de registro socio


                if (cboTipo.Text == "Socio")

                {
                    // Aquí puedes agregar el código para registrar el nuevo socio
                    // Por ejemplo, llamar a un método en ServicioCliente para agregar el usuario
                    var nuevoUsuario = new Socio
                    {
                        Nombre = txtNombreYapellido.Text.Trim(),
                        Documento = documento,
                        Estado = Estado.Inactivo,
                        Fecha_Inscripcion = DateTime.Now,
                        Tipo = "socio", // Asignamos el tipo de socio
                        Apto_Fisico = chkAptoFisico.Checked // Asignamos si presentó apto físico
                    };
                    servicioCliente.InsertarUsuario(nuevoUsuario);// Asegúrate de que este método exista en ServicioCliente
                    //luego si entrego apto fisico le mostramos un cartel con un boton que diga imprimir carnet
                    if (chkAptoFisico.Checked)
                    {
                        MessageBox.Show("Socio registrado exitosamente. Por favor, imprima su carnet.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Socio registrado exitosamente. Recuerde presentar el apto físico en su próxima visita.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //se abre un modal con los datos del socio y si tiene el apto fisico hay un boton que dice imprimir carnet sin funcionalidad implementada
                    // Aquí podrías abrir un formulario modal para mostrar los datos del socio

                    //consultamos si quiere realizar el pago ahora primero mediante un mensaje
                    var resultado = MessageBox.Show("¿Desea realizar el pago ahora?", "Pago de Socio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        // Si el usuario acepta, abrimos el formulario de registro de pago
                        frmRegistrarPago frmRegistrarPago = new frmRegistrarPago(nuevoUsuario.Nombre, nuevoUsuario.Documento);
                        frmRegistrarPago.ShowDialog(); // Mostramos el formulario modal para registrar el pago
                        // Luego de registrar el pago, cerramos el formulario de registro de Socio
                        MessageBox.Show("Pago registrado exitosamente. Gracias por su colaboración.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Puede realizar el pago en cualquier momento. Gracias por registrarse.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    frmRegistrarSocio.ActiveForm.Close();
                }

                if (cboTipo.Text == "No Socio")
                {
                    // Hacemos registro de no socio
                    var nuevoNoSocio = new NoSocio
                    {
                        Nombre = txtNombreYapellido.Text.Trim(),
                        Documento = documento,
                        Estado = Estado.Activo,
                        Fecha_Inscripcion = DateTime.Now,
                        Tipo = "no socio", // Asignamos el tipo de No Socio
                        Apto_Fisico = false // No aplica para No Socio


                    };
                    //insertamos el no socio
                    servicioCliente.InsertarNoSocio(nuevoNoSocio); // Asegúrate de que este método exista en ServicioCliente
                    // el socio tiene que realizar el pago en el momento por lo que abre el modal de Registrar pago con el documento del no socio
                    MessageBox.Show("No Socio registrado exitosamente. Por favor, realice el pago correspondiente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Aquí podrías abrir un formulario modal para registrar el pago del No Socio
                    frmRegistrarPago frmRegistrarPago = new frmRegistrarPago(nuevoNoSocio.Nombre, nuevoNoSocio.Documento);
                    frmRegistrarPago.ShowDialog(); // Mostramos el formulario modal para registrar el pago
                    // Luego de registrar el pago, cerramos el formulario de registro de No Socio
                    //frmRegistrarPago.ActiveForm.Close(); // Esto no es necesario ya que el formulario se cierra al finalizar el diálogo
                    MessageBox.Show("Pago registrado exitosamente. Gracias por su colaboración.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    frmRegistrarSocio.ActiveForm.Close(); // Cerramos el formulario después de registrar al No Socio
                }


            }
            //luego se cierra el form
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //cerramos el form
            frmRegistrarSocio.ActiveForm.Close();
        }
    }
}
