using System.Data;

namespace MenuPrincipalClub
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;

            //inicializar el formulario con valores default
            txtUsuario.Text = "admin";
            txtPass.Text = "admin123";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPass.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.CUsuarios dato = new Datos.CUsuarios();


            tablaLogin = dato.LogInUsuario(txtUsuario.Text, txtPass.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal Principal = new frmPrincipal();

                Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                Principal.usuario = Convert.ToString(txtUsuario.Text);

                Principal.Show(); // se llama al formulario principal
                this.Hide(); // se oculta el formulario del login

            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrectos");
            }


            /*  string ingresoUsuario = textBox1.Text;
            string ingresoPassword = textBox2.Text;


            //Simulamos ingreso Clave
            if(ingresoPassword == "Admin" && ingresoUsuario == "Admin")
            {
                MessageBox.Show("Bienvenido al sistema");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

            */
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            {
                DataTable tablaLogin = new DataTable();
                Datos.CUsuarios dato = new Datos.CUsuarios();


                tablaLogin = dato.LogInUsuario(txtUsuario.Text, txtPass.Text);

                if (tablaLogin.Rows.Count > 0)
                {
                    MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPrincipal Principal = new frmPrincipal();

                    Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                    Principal.usuario = Convert.ToString(txtUsuario.Text);

                    Principal.Show(); // se llama al formulario principal
                    this.Hide(); // se oculta el formulario del login

                }
                else
                {
                    MessageBox.Show("Usuario y/o password incorrectos");
                }

            }
        }
    }
}
