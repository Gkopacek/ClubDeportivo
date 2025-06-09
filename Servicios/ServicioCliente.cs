


using System.Data;
using MenuPrincipalClub.Datos;
using MenuPrincipalClub.Entidades;
using MySql.Data.MySqlClient;

namespace MenuPrincipalClub.Servicios
{
    

public class ServicioCliente
    {

/*
public List<Cliente> ObtenerClientes()
        {
            var listaUsuarios = new List<Cliente>();

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

*/
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

        public bool RegistrarPagoActividad(PagoActividad pago)
        {

            bool exito = false;
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand(@"INSERT INTO pagos_actividades (idActividad, Ncliente, Metodo_pago, fecha_pago)
                         VALUES (@pago.idActividad, @pago.NCliente, @pago.metodoPago, @pago.fechaPago);", sqlCon);
            {
                
                sqlCon.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                exito = filasAfectadas > 0;
            }
            return exito;
        }



    }

}
