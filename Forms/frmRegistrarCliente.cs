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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MenuPrincipalClub.Forms
{
    public partial class frmRegistrarCliente : Form
    {
        // Tamaño original del formulario (guardado en carga)
        private Size originalSize;

        public frmRegistrarCliente()
        {
            InitializeComponent();

            cboTipo.Items.Add("Efectivo");
            cboTipo.Items.Add("Tarjeta");

            //comboBox1.Items.AddRange(new string[] { "Elemento 1", "Elemento 2", "Elemento 3" });

            cboCantMeses.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "12" });



            // Guardar el tamaño original al inicio para poder restaurarlo después
            originalSize = this.Size;

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            ServicioCliente servicioSocio = new ServicioCliente();

            string Documento = txtDocumento.Text;

            Cliente cliente = servicioSocio.ObtenerClientePorDocumento(Documento);

            if (cliente != null)
            {
                var resultado = MessageBox.Show(
                $"El cliente con Numero de documento {cliente.Documento} ya existe en nuestra base de datos. Deseas convertirlo en Socio?",
                "Éxito",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDocumento.Text = cliente.Documento;
                txtEmail.Text = cliente.Email;
                txtTelefono.Text = cliente.Telefono;


                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    // El usuario hizo clic en "Sí"
                    chkHacerSocio.Checked = true;
                    // Aquí puedes agregar la lógica para guardar como socio
                }
                else if (resultado == System.Windows.Forms.DialogResult.No)
                {
                    // El usuario hizo clic en "No"
                    chkHacerSocio.Checked = false;
                    // Lógica si el botón No fue seleccionado
                }


            }
            else
            {
                // Instanciar un objeto Cliente usando el constructor...
                Cliente nuevoCliente = new Cliente(
                    nombre: txtNombre.Text,
                    apellido: txtApellido.Text,
                    documento: txtDocumento.Text,
                    email: txtEmail.Text,
                    telefono: txtTelefono.Text
                );

                servicioSocio.RegistrarCliente(nuevoCliente);
            }
        }

        private void chkHacerSocio_CheckedChanged(object sender, EventArgs e)
        {
            // Verificar si el checkbox está marcado o no
            if (chkHacerSocio.Checked)
            {

                // Tamaño cuando está seleccionado
                Decimal ValorCuota = Utils.ObtenerValorCuota();
                txtMonto.Text = ValorCuota.ToString();
                this.Size = new Size(416, 475); // Modifica estos valores según tus necesidades


            }
            else
            {
                txtMonto.Clear();
                // Restaurar tamaño original cuando se desmarca
                this.Size = originalSize;


            }
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            if (cboTipo.SelectedItem !=null && cboCantMeses.SelectedItem != null )
            {
                Decimal total = 0;

                Decimal ValorCuota = Utils.ObtenerValorCuota();


                string seleccionado = cboCantMeses.SelectedItem.ToString();

                switch (seleccionado)
                {
                    case "3":
                        if (cboTipo.SelectedItem == "Tarjeta")
                        {
                            MessageBox.Show("Se aplicara descuento del 10%");
                            total = ValorCuota * (Decimal)0.9;

                        }
                        else
                        {
                            total = Decimal.Parse(seleccionado) * ValorCuota;
                        }
                        break;

                    case "6":
                        if (cboTipo.SelectedItem == "Tarjeta")
                        {
                            MessageBox.Show("Se aplicara descuento del 15%");
                            total = ValorCuota * (Decimal)0.85;
                            break;
                        }
                        else
                        {
                            total = Decimal.Parse(seleccionado) * ValorCuota;
                        }
                        break;

                    default:
                        total = Decimal.Parse(seleccionado) * ValorCuota;
                        break;
                }
                MessageBox.Show(
$"Se registro correctamente el nuevo Socio",
"EXITO");
            }
            else
            {
                MessageBox.Show(
                $"debe seleccionar un valor",
                "ERROR");
            }

            
            
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
        }

        private void cboCantMeses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCantMeses_MouseClick(object sender, MouseEventArgs e)
        {
            

        }
    }
}

