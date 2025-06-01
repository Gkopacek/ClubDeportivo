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
using MenuPrincipalClub.Entidades;
using MenuPrincipalClub.Forms;
using MenuPrincipalClub.Servicios;

namespace MenuPrincipalClub
{
    public partial class frmPrincipal : Form
    {

        internal string? rol;
        internal string? usuario;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Conexion conexion = Conexion.getInstancia();
            // Conecto conecto = new Conecto("Server=localhost;Database=club_deportivo;User ID=root;Password=root;SslMode=Required;AllowPublicKeyRetrieval=False");
            ServicioCliente ServicioCliente = new ServicioCliente();


            // Obtener la lista de usuarios
            List<Socio> usuarios = ServicioCliente.ObtenerUsuarios();
            // Verificar si la lista de usuarios no es nula
            if (usuarios != null)
            {
                // Asignar la lista de usuarios al DataGridView
                dataGridView1.DataSource = usuarios;
            }
            else
            {
                // Manejar el caso en que no se encontraron usuarios
                MessageBox.Show("No se encontraron usuarios.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegistrarSocio frmregistrarsocio = new frmRegistrarSocio();
            frmregistrarsocio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //frmBusquedaDNI frmBusquedaDNI = new frmBusquedaDNI();
            //frmBusquedaDNI.Show();

            //funcion en manetenimiento
            MessageBox.Show("Función aún no disponible.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // llamos al service y actualizamos lista de deudores en la db
            ServicioCliente servicioCliente = new ServicioCliente();
            servicioCliente.ActualizarDeudores();
            //avisamos que la lista de deudores fue actualizada
            MessageBox.Show("Lista de deudores actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //traemos los socios a una lista
            List<Socio> usuarios = servicioCliente.ObtenerUsuarios();
            // y mostamos en el datagridview los que tienen estado inactivo 
            if (usuarios != null)
            {
                // Filtramos los usuarios que están inactivos
                var deudores = usuarios.Where(u => u.Estado == Estado.Inactivo).ToList();
                // Asignamos la lista filtrada al DataGridView
                dataGridView1.DataSource = deudores;
            }
            else
            {
                // Manejar el caso en que no se encontraron usuarios
                MessageBox.Show("No se encontraron usuarios.");
            }



            // funcion aun no disponible
            //MessageBox.Show("Función aún no disponible. 2", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //abrimos el form para buscar por dni

            //verificamos si existe el dni en la db

            ServicioCliente servicioCliente = new ServicioCliente();
            //Usuario? usuario = servicioCliente.ObtenerUsuarioPorDocumento();

            //si existe abrimos el formulario para registrar pago
            if (usuario != null)
            {
                frmRegistrarSocio frmRegistrarPago = new frmRegistrarSocio();
                frmRegistrarPago.Show();
            }
            else
            {
                //si no existe mostramos un mensaje de error
                MessageBox.Show("El usuario con el DNI ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente frmRegistrarCliente = new frmRegistrarCliente();
            frmRegistrarCliente.Show();
        }
    }
}
