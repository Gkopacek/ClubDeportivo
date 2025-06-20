//using MySql.Data.MySqlClient;


//namespace MenuPrincipalClub.Datos
//{
//    public class Conecto
//    {
//        private readonly string _cadenaConexion;

//        public Conecto(string cadenaConexion)
//        {
//            _cadenaConexion = cadenaConexion;
//        }

//        public MySqlConnection ObtenerConexion()

//        {
//            try
//            {
//            var conexion = new MySqlConnection(_cadenaConexion);
//            conexion.Open();
//            return conexion;

//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return null; // Devuelve null si la conexión falla
//            }

//        }
//    }
//}

