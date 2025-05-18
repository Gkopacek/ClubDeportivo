using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pruebas_club_deportivo;

namespace MenuPrincipalClub
{
    public partial class Form2 : Form
    {
        public Form2()
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
            Conecto conecto = new Conecto("Server=localhost;Database=club_deportivo;User ID=root;Password=root;SslMode=none;");
            ServicioUsuario servicioUsuario = new ServicioUsuario(conecto);


            // Obtener la lista de usuarios
            List<Usuario> usuarios = servicioUsuario.ObtenerUsuarios();
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
    }
}
