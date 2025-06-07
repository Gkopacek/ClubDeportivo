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
            textBox3.Enabled = false;
        }


        public frmRegistrarPago(string nombre, string documento)
        {
            InitializeComponent();
            //ponemos el nombre y el documento en los textBox
            textBox3.Text = nombre;
            textBox2.Text = documento;
            //ponemos disables el textBox3
            textBox3.Enabled = false;
            textBox2.Enabled = false; // Deshabilitamos el textBox2 para que no se pueda modificar el documento una vez ingresado
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
            if (textBox2.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un documento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí deberías implementar la lógica para verificar si el documento existe en la base de datos
                // Si existe, habilitamos el textBox3
                // tomamos desde el textBox2 el documento y lo pasamos al servicio cliente
                ServicioCliente servicioCliente = new ServicioCliente();
                Socio? usuario = servicioCliente.ObtenerUsuarioPorDocumento(textBox2.Text);
                if (usuario != null)
                {
                    // Si el usuario existe, habilitamos el textBox3 quiero que quede cargado pero no se pueda modificar
                    // y mostramos su nombre en el textBox3

                    textBox3.Text = usuario.Nombre; // Asignamos el nombre del usuario al textBox3
                }
                else
                {
                    // Si no existe, mostramos un mensaje de error
                    MessageBox.Show("El documento ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Enabled = false; // Deshabilitamos el textBox3 si no se encuentra el usuario
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verificamos que el nombre, el documento no esten vacios, el pago y el tipo de pago
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                // Creamos una instancia de Pago con los datos ingresados
                Pago nuevoPago = new Pago
                {
                    Documento = textBox2.Text,
                    Fecha = DateTime.Now, // Asignamos la fecha actual
                    Monto = decimal.Parse(textBox1.Text), // Convertimos el monto a decimal
                    MetodoPago = comboBox1.SelectedItem.ToString() // Obtenemos el método de pago seleccionado
                };
                // Llamamos al servicio para registrar el pago
                ServicioCliente servicioCliente = new ServicioCliente();
                bool exito = servicioCliente.RegistrarPago(nuevoPago);

                MessageBox.Show("Pago registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos los campos después de registrar el pago
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Clear();
                comboBox1.SelectedIndex = -1; // Reseteamos el comboBox


                //cerramos el formulario
                this.Close();
            }

        }
    }
}
