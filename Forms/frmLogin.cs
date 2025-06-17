using System.Data;

namespace MenuPrincipalClub
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtContrasenia.UseSystemPasswordChar = true;

            //inicializar el formulario con valores default
            txtUsuario.Text = "admin";
            txtContrasenia.Text = "admin123";

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            {
                DataTable tablaLogin = new DataTable();
                Datos.CUsuarios dato = new Datos.CUsuarios();


                tablaLogin = dato.LogInUsuario(txtUsuario.Text, txtContrasenia.Text);

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContrasenia.Clear();
        }
    }
}
