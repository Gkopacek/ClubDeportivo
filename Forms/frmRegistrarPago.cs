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

namespace MenuPrincipalClub.Forms
{
    public partial class frmRegistrarPago : Form
    {
        public frmRegistrarPago()
        {
            InitializeComponent();

            //Ponemos disables el textBox3
            txtNombre.Enabled = false;
        }

        private void frmRegistrarPago_Load(object sender, EventArgs e)
        {

        }


        //CONSTRUCTOR FUERA DE SERVICIO
        //public frmRegistrarPago(string nombre, string documento)
        //{
        //    InitializeComponent();
        //    //ponemos el nombre y el documento en los textBox
        //    txtNombre.Text = nombre;
        //    txtDocumento.Text = documento;
        //    //ponemos disables el textBox3
        //    txtNombre.Enabled = false;
        //    txtDocumento.Enabled = false; // Deshabilitamos el textBox2 para que no se pueda modificar el documento una vez ingresado
        //}

        //hacemos constructor para registrar pago socio
        public frmRegistrarPago(Socio socio)
        {
            InitializeComponent();
            //ponemos el nombre y el documento en los textBox
            txtNombre.Text = socio.Nombre;
            txtDocumento.Text = socio.Documento;
            //ponemos el concepto como "mensualidad" por defecto y lo deshabilitamos
            cboTipo.SelectedItem = "mensualidad"; // Asignamos el concepto de pago como "mensualidad"



            //ponemos disables el textBox3
            cboTipo.Enabled = false; // Deshabilitamos el comboBox para que no se pueda modificar el concepto una vez ingresado
            txtNombre.Enabled = false;
            txtDocumento.Enabled = false; // Deshabilitamos el textBox2 para que no se pueda modificar el documento una vez ingresado
        }

        //hacemos constructor para registar pago no socio
        public frmRegistrarPago(NoSocio noSocio)
        {
            InitializeComponent();
            //ponemos el nombre y el documento en los textBox
            txtNombre.Text = noSocio.Nombre;
            txtDocumento.Text = noSocio.Documento;
            //ponemos el concepto como "actividad" por defecto y lo deshabilitamos
            cboTipo.SelectedItem = "actividad"; // Asignamos el concepto de pago como "actividad"
            cboTipo.Enabled = false; // Deshabilitamos el comboBox para que no se pueda modificar el concepto una vez ingresado
            //ponemos disables el textBox3
            txtNombre.Enabled = false;
            txtDocumento.Enabled = false; // Deshabilitamos el textBox2 para que no se pueda modificar el documento una vez ingresado
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //cerramos el formulario
            this.Close();
            // tiramos // un mensaje de que se ha cancelado el registro de pago
            this.DialogResult = DialogResult.Cancel; // Establecemos el resultado del diálogo como Cancel
            MessageBox.Show("Registro de pago cancelado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Concepto = cboTipo.SelectedItem.ToString() // Obtenemos el método de pago seleccionado
                };
                // Llamamos al servicio para registrar el pago
                ServicioCliente servicioCliente = new ServicioCliente();
                bool exito = servicioCliente.RegistrarPago(nuevoPago);

                //aclaramos que el pago se realizo con exito en messagebox
                if (exito)
                {
                    MessageBox.Show("Pago registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al registrar el pago. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salimos del método si hubo un error al registrar el pago
                }

                // Limpiamos los campos después de registrar el pago
                txtDocumento.Clear();
                txtNombre.Clear();
                txtMonto.Clear();
                cboTipo.SelectedIndex = -1; // Reseteamos el comboBox


                //cerramos el formulario
                this.DialogResult = DialogResult.OK; // Establecemos el resultado del diálogo como OK
                this.Close();
            }
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
                Persona? persona = servicioCliente.ObtenerPersonaPorDocumento(txtDocumento.Text);
                if (persona != null)
                {
                    // Si el usuario existe, habilitamos el textBox3 quiero que quede cargado pero no se pueda modificar
                    // y mostramos su nombre en el textBox3

                    txtNombre.Text = persona.Nombre; // Asignamos el nombre del usuario al textBox3

                    //si el usuario es un socio, mostramos el concepto de pago como "mensualidad" y lo deshabilitamos
                    if (persona is Socio)
                    {
                        cboTipo.SelectedItem = "mensualidad"; // Asignamos el concepto de pago como "mensualidad"
                        cboTipo.Enabled = false; // Deshabilitamos el comboBox para que no se pueda modificar el concepto una vez ingresado
                    }
                    else if (persona is NoSocio)
                    {
                        cboTipo.SelectedItem = "actividad"; // Asignamos el concepto de pago como "actividad"
                        cboTipo.Enabled = false; // Deshabilitamos el comboBox para que no se pueda modificar el concepto una vez ingresado
                    }
                }
                else
                {
                    // Si no existe, mostramos un mensaje de error
                    MessageBox.Show("El documento ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Enabled = false; // Deshabilitamos el textBox3 si no se encuentra el usuario
                }
            }
        }
    }
}
