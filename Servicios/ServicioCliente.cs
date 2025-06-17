


using System.Data;
using MenuPrincipalClub.Datos;
using MenuPrincipalClub.Entidades;
using MySql.Data.MySqlClient;

namespace MenuPrincipalClub.Servicios
{
    

public class ServicioCliente
    {
        // Primer servicio obtener todos los usuarios
        public List<Socio> ObtenerSocios()
        {
            var listaSocios = new List<Socio>();

            // Ensure the Conexion class has a static method getInstancia() that returns an instance of Conexion
            // If it doesn't exist, you need to implement it in the Conexion class.
            var conexionInstancia = Conexion.CrearConexion(); // Ensure this method exists in Conexion class
            MySqlConnection sqlCon = Conexion.CrearConexion();

            MySqlCommand comando = new MySqlCommand("BuscarSocios", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };

            sqlCon.Open();
            using (var lector = comando.ExecuteReader())
            {
                while (lector.Read())
                {
                    listaSocios.Add(new Socio
                    {

                        Nombre = lector.GetString(1),
                        Documento = lector.GetString(2),
                        Estado = Enum.TryParse(lector.GetString(4), ignoreCase: true, out Estado estado)
                            ? estado
                            : Estado.Inactivo,
                        Fecha_Inscripcion = lector.GetDateTime(3),
                        // Fix for CS0029: Cannot implicitly convert type 'string' to 'MenuPrincipalClub.Entidades.Tipo'
                        // Adjusting the code to parse the string into the 'Tipo' enum.
                        Tipo = lector.GetString(5)
                            ,
                        Apto_Fisico = lector.GetBoolean(6) // Uncomment if you have this field in your database


                    });
                }
            }

            return listaSocios;
        }


        // Segundo servicio buscar un usuario por su documento
        public Socio ObtenerPersonaPorDocumento(string documento)
        {
            Socio usuario = null;
            MySqlConnection sqlCon = Conexion.CrearConexion();
            MySqlCommand comando = new MySqlCommand("BuscarPersonaPorDocumento", sqlCon);
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

        // Tercer servicio insertar un usuario a la db
        // stored prodcedure InsertarSocio
       public bool InsertarSocio(Socio usuario)
        {
            bool exito = false;
            MySqlConnection sqlCon = Conexion.CrearConexion();
            MySqlCommand comando = new MySqlCommand("InsertarPersona", sqlCon);
            {
                //mostramos un mensaje verificamos nombre y documento que no este vacio
                if (string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Documento))
                {
                    MessageBox.Show("El nombre y el documento no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@p_documento", usuario.Documento);
                    comando.Parameters.AddWithValue("@p_fecha", usuario.Fecha_Inscripcion);
                    comando.Parameters.AddWithValue("@p_estado", usuario.Estado.ToString());
                    comando.Parameters.AddWithValue("@p_tipo", usuario.Tipo.ToString());
                    comando.Parameters.AddWithValue("@p_apto", usuario.Apto_Fisico); // Asegúrate de que este campo exista en tu base de datos

                    sqlCon.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    exito = filasAfectadas > 0;
                    //emitimos un mensaje de exito
                    if (exito)
                    {
                        MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }



            }
            return exito;
        }


        //hacemos el metodo instertarNoSocio para insertar un usuario no socio a la db
        public bool InsertarNoSocio(NoSocio usuario)
        {
            bool exito = false;
            MySqlConnection sqlCon = Conexion.CrearConexion();
            MySqlCommand comando = new MySqlCommand("InsertarPersona", sqlCon);
            {
                //mostramos un mensaje verificamos nombre y documento que no este vacio
                if (string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Documento))
                {
                    MessageBox.Show("El nombre y el documento no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@p_documento", usuario.Documento);
                    comando.Parameters.AddWithValue("@p_fecha", usuario.Fecha_Inscripcion);
                    comando.Parameters.AddWithValue("@p_estado", usuario.Estado.ToString());
                    comando.Parameters.AddWithValue("@p_tipo", usuario.Tipo);
                    comando.Parameters.AddWithValue("@p_apto", usuario.Apto_Fisico); // Asegúrate de que este campo exista en tu base de datos
                    sqlCon.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    exito = filasAfectadas > 0;
                    //emitimos un mensaje de exito
                    if (exito)
                    {
                        MessageBox.Show("Usuario No Socio registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el usuario No Socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return exito;
        }



        // registramos pago a la db
        public bool RegistrarPago(Pago pago)
        {
            bool exito = false;
            MySqlConnection sqlCon = Conexion.CrearConexion();
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
            MySqlConnection sqlCon = Conexion.CrearConexion();
            MySqlCommand comando = new MySqlCommand("ActualizarDeudores", sqlCon);
            {
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                exito = filasAfectadas > 0;
            }
            return exito;
        }



    }

}
