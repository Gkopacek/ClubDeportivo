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
using MenuPrincipalClub.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuPrincipalClub.Forms
{
    public partial class frmRegistrarSocio : Form
    {
        public frmRegistrarSocio()
        {
            InitializeComponent();

            //Ponemos disables el textBox3
            txtNombre.Enabled = false;
            btnRegistrarSocio.Hide();
            lblNotificacion.Hide();
            lblNo_Documento.Hide();
            lblNo_Nombre.Hide();
            lblNo_Monto.Hide();
            lblNo_Tipo.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cerramos el formulario
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrarPago_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // verificamos que el documento existe textBox2 en la db
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un documento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí deberías implementar la lógica para verificar si el documento existe en la base de datos
                // Si existe, habilitamos el textBox3
                // tomamos desde el textBox2 el documento y lo pasamos al servicio cliente
                ServicioCliente servicioCliente = new ServicioCliente();
                Socio? usuario = servicioCliente.ObtenerUsuarioPorDocumento(txtDocumento.Text);
                if (usuario != null)
                {
                    // Si el usuario existe, habilitamos el textBox3 quiero que quede cargado pero no se pueda modificar
                    // y mostramos su nombre en el textBox3

                    txtNombre.Text = usuario.Nombre; // Asignamos el nombre del usuario al textBox3
                }
                else
                {
                    // Si no existe, mostramos un mensaje de error
                    MessageBox.Show("El documento ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Enabled = true; // Deshabilitamos el textBox3 si no se encuentra el usuario
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verificamos que el nombre, el documento no esten vacios, el pago y el tipo de pago
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDocumento.Text) ||
                string.IsNullOrWhiteSpace(txtMonto.Text) || string.IsNullOrWhiteSpace(cboTipo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                // Creamos una instancia de Pago con los datos ingresados
                Pago nuevoPago = new Pago
                {
                    Documento = txtDocumento.Text,
                    Fecha = DateTime.Now, // Asignamos la fecha actual
                    Monto = decimal.Parse(txtMonto.Text), // Convertimos el monto a decimal
                    MetodoPago = cboTipo.SelectedItem.ToString() // Obtenemos el método de pago seleccionado
                };
                // Llamamos al servicio para registrar el pago
                ServicioCliente servicioCliente = new ServicioCliente();
                bool exito = servicioCliente.RegistrarPago(nuevoPago);

                MessageBox.Show("Pago registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos los campos después de registrar el pago
                txtDocumento.Clear();
                txtNombre.Clear();
                txtMonto.Clear();
                cboTipo.SelectedIndex = -1; // Reseteamos el comboBox
            }

        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {

            bool existeSocio;
            //Verificamos que el nombre, el documento no esten vacios, el pago y el tipo de pago
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtMonto.Text) || string.IsNullOrWhiteSpace(cboTipo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (string.IsNullOrWhiteSpace(txtDocumento.Text))
                {
                    lblNo_Documento.Show();
                }
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    lblNo_Nombre.Show();
                }
                if (string.IsNullOrWhiteSpace(txtMonto.Text))
                {
                    lblNo_Monto.Show();
                }
                if (string.IsNullOrWhiteSpace(cboTipo.Text))
                {
                    lblNo_Tipo.Show();
                }

            }
            else
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
                    
                    // Aquí puedes agregar el código para registrar el nuevo socio
                    // Por ejemplo, llamar a un método en ServicioCliente para agregar el usuario
                    var nuevoUsuario = new Socio
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Documento = documento,
                        Estado = Estado.Activo,
                        Fecha_Inscripcion = DateTime.Now // Asignar la fecha actual
                    };

                    servicioCliente.RegistrarSocio(nuevoUsuario);

                    // Creamos una instancia de Pago con los datos ingresados
                    Pago nuevoPago = new Pago
                    {
                        Documento = txtDocumento.Text,
                        Fecha = DateTime.Now, // Asignamos la fecha actual
                        Monto = decimal.Parse(txtMonto.Text), // Convertimos el monto a decimal
                        MetodoPago = cboTipo.SelectedItem.ToString() // Obtenemos el método de pago seleccionado
                    };
                    // Llamamos al servicio para registrar el pago
                    bool exito = servicioCliente.RegistrarPago(nuevoPago);

                    if (exito)
                    {
                        // Limpiamos los campos después de registrar el pago
                        txtDocumento.Clear();
                        txtNombre.Clear();
                        txtMonto.Clear();
                        cboTipo.SelectedIndex = -1; // Reseteamos el comboBox
                         // Asegúrate de que este método exista en ServicioCliente
                    }

                    

                    frmRegistrarSocio.ActiveForm.Close();
                }
                //luego se cierra el form
            }
        }

        private void txtDocumento_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //Verificamos que el nombre, el documento no esten vacios, el pago y el tipo de pago
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDocumento.Text) ||
                string.IsNullOrWhiteSpace(txtMonto.Text) || string.IsNullOrWhiteSpace(cboTipo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                // Creamos una instancia de Pago con los datos ingresados
                Pago nuevoPago = new Pago
                {
                    Documento = txtDocumento.Text,
                    Fecha = DateTime.Now, // Asignamos la fecha actual
                    Monto = decimal.Parse(txtMonto.Text), // Convertimos el monto a decimal
                    MetodoPago = cboTipo.SelectedItem.ToString() // Obtenemos el método de pago seleccionado
                };
                // Llamamos al servicio para registrar el pago
                ServicioCliente servicioCliente = new ServicioCliente();
                bool exito = servicioCliente.RegistrarPago(nuevoPago);

                MessageBox.Show("Pago registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos los campos después de registrar el pago
                txtDocumento.Clear();
                txtNombre.Clear();
                txtMonto.Clear();
                cboTipo.SelectedIndex = -1; // Reseteamos el comboBox
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //cerramos el formulario
            this.Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // verificamos que el documento existe textBox2 en la db
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un documento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                // Aquí deberías implementar la lógica para verificar si el documento existe en la base de datos
                // Si existe, habilitamos el textBox3
                // tomamos desde el textBox2 el documento y lo pasamos al servicio cliente
                ServicioCliente servicioCliente = new ServicioCliente();
                Socio? usuario = servicioCliente.ObtenerUsuarioPorDocumento(txtDocumento.Text);
                if (usuario != null)
                {
                    // Si el usuario existe, habilitamos el textBox3 quiero que quede cargado pero no se pueda modificar
                    // y mostramos su nombre en el textBox3
                    txtNombre.Text = usuario.Nombre; // Asignamos el nombre del usuario al textBox3
                }
                else
                {
                    btnRegistrarSocio.Show();
                    btnPagar.Hide();
                    lblNotificacion.Show();
                    txtNombre.Clear();
                    btnRegistrarSocio.Enabled = true;
                    // Si no existe, mostramos un mensaje de error
                    MessageBox.Show("El documento ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Enabled = true; // Deshabilitamos el textBox3 si no se encuentra el usuario
                }
            }
        }
    }
}
