


using System.Data;
using MenuPrincipalClub.Datos;
using MenuPrincipalClub.Entidades;
using MySql.Data.MySqlClient;

namespace MenuPrincipalClub.Servicios
{
    

public class ServicioCliente
    {
        // Primer servicio obtener todos los usuarios
        public List<Socio> ObtenerUsuarios()
        {
            var listaUsuarios = new List<Socio>();

            // Ensure the Conexion class has a static method getInstancia() that returns an instance of Conexion
            // If it doesn't exist, you need to implement it in the Conexion class.
            var conexionInstancia = Conexion.getInstancia(); // Ensure this method exists in Conexion class
            MySqlConnection sqlCon = conexionInstancia.CrearConexion();

            MySqlCommand comando = new MySqlCommand("ObtenerSocios", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };

            sqlCon.Open();
            using (var lector = comando.ExecuteReader())
            {
                while (lector.Read())
                {
                    listaUsuarios.Add(new Socio
                    {
                        Nsocio = lector.GetInt32(0),
                        Nombre = lector.GetString(1),
                        Estado = Enum.TryParse(lector.GetString(4), ignoreCase: true, out Estado estado)
                            ? estado
                            : Estado.Inactivo,
                        Fecha_Inscripcion = lector.GetDateTime(3),
                        Documento = lector.GetString(2)
                    });
                }
            }

            return listaUsuarios;
        }


        // Segundo servicio buscar un usuario por su documento
        public Socio ObtenerUsuarioPorDocumento(string documento)
        {
            Socio usuario = null;
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand("BuscarSocioPorNumeroDeSocio", sqlCon);
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_documento", documento);
                sqlCon.Open();
                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        usuario = new Socio
                        {
                            Nsocio = lector.GetInt32(0),
                            Nombre = lector.GetString(1),
                            Documento = lector.GetString(2),
                            Fecha_Inscripcion = lector.GetDateTime(3),
                            Estado = Enum.TryParse(lector.GetString(4), ignoreCase: true, out Estado estado)
                                ? estado
                                : Estado.Inactivo
                        };
                    }
                }
            }
            return usuario;
        }

        public Socio ObtenerSocioPorNumeroDeSocio(int numeroDeSocio)
        {
            Socio socio = null;
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand("BuscarSocioPorNumero", sqlCon);

            try
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_Nsocio", numeroDeSocio);

                sqlCon.Open();

                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        socio = new Socio(
                            lector.GetString(1),  // Nombre
                            lector.GetString(2),  // Apellido
                            lector.GetString(3),  // Documento
                            string.Empty,         // Email (no se usa en Cliente)
                            string.Empty          // Telefono (no se usa en Cliente)
                        )
                        {
                            Nsocio = lector.GetInt32(0),
                            Fecha_Inscripcion = lector.GetDateTime(4),
                            Estado = Enum.TryParse(
                                lector.GetString(5).ToLower(),
                                ignoreCase: true,
                                out Estado estado
                            ) ? estado : Estado.Inactivo
                        };
                    }
                }
            }
            finally
            {
                sqlCon.Close();
            }

            return socio;
        }


        public Cliente ObtenerClientePorDocumento(string documento)
{
    Cliente cliente = null;
    MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
    MySqlCommand comando = new MySqlCommand("BuscarClientePorDocumento", sqlCon);
    {
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("@p_documento", documento);

        sqlCon.Open();
        using (var lector = comando.ExecuteReader())
        {
            if (lector.Read())
            {
                cliente = new Cliente(
                    lector.GetString(0), // Nombre
                    lector.GetString(1), // Apellido
                    lector.GetString(2), // Documento
                    lector.GetString(3), // Email
                    lector.GetString(4)  // Telefono
                );
            }
        }
    }
    return cliente;
}


        // Tercer servicio insertar un usuario a la db
        // stored prodcedure InsertarSocio
      /* public bool RegistrarSocio(Cliente cliente)
        {
            
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            
            {
                //mostramos un mensaje verificamos nombre y documento que no este vacio
                if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Documento))
                {
                   
                    MessageBox.Show("El nombre y el documento no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string documento = cliente.Documento;
                    Cliente clienteobtenido  =  ObtenerClientePorDocumento(documento);

                   
                    if (clienteobtenido != null)
                    {
                        MessageBox.Show("cliente encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                       // Socio socio = ObtenerSocioPorNumeroDeSocio();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }



            }
            return exito;
        } */

        // registramos pago a la db
        public bool RegistrarPago(Pago pago)
        {
            bool exito = false;
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand("RegistrarPago", sqlCon);
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_documento", pago.Documento);
                //comando.Parameters.AddWithValue("@fecha", pago.Fecha);
                comando.Parameters.AddWithValue("@p_monto", pago.Monto);
                comando.Parameters.AddWithValue("@p_metodo_pago", pago.MetodoPago);
                sqlCon.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                exito = filasAfectadas > 0;
            }
            return exito;
        }


        //Actualizamos lista de deudores en la db haciendo call al procedure
        public bool ActualizarDeudores()
        {
            bool exito = false;
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand("ActualizarDeudores", sqlCon);
            {
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                exito = filasAfectadas > 0;
            }
            return exito;
        }

        public bool RegistrarCliente(Cliente cliente)
        {
            bool exito = false;

            // Validaciones básicas y de correo electrónico
            if (string.IsNullOrWhiteSpace(cliente.Nombre) ||
                string.IsNullOrWhiteSpace(cliente.Apellido) ||
                string.IsNullOrWhiteSpace(cliente.Documento))
            {
                MessageBox.Show("El nombre, apellido y documento son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación de email con expresión regular
            if (!string.IsNullOrEmpty(cliente.Email) && !ValidarEmail(cliente.Email))
            {
                MessageBox.Show("El formato del correo electrónico es inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                using (MySqlCommand comando = new MySqlCommand("InsertarCliente", sqlCon))
                {
                    // Configuración del procedimiento almacenado
                    comando.CommandType = CommandType.StoredProcedure;

                    // Asignar parámetros al stored procedure
                    comando.Parameters.AddWithValue("@pNombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@pApellido", cliente.Apellido);
                    comando.Parameters.AddWithValue("@pDocumento", cliente.Documento);
                    comando.Parameters.AddWithValue("@pEmail", cliente.Email);  // Manejo de null
                    comando.Parameters.AddWithValue("@pTelefono", cliente.Telefono);

                    // Abrir conexión y ejecutar
                    sqlCon.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    exito = filasAfectadas > 0;

                    // Mensajes según el resultado
                    if (exito)
                    {
                        MessageBox.Show("Cliente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return exito;
        }

        // Método para validar formato de correo electrónico
        private bool ValidarEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }




    }

}
