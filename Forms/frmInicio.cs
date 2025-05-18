namespace MenuPrincipalClub
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;


            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ingresoUsuario = textBox1.Text;
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
        }
    }
}
