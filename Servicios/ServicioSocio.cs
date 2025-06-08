using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuPrincipalClub.Datos;
using MenuPrincipalClub.Entidades;
using System.Data;
using MenuPrincipalClub.Datos;
using MenuPrincipalClub.Entidades;
using MySql.Data.MySqlClient;

namespace MenuPrincipalClub.Servicios
{
    internal class ServicioSocio
    {
        // Primer servicio obtener todos los Socios
        public List<Socio> ObtenerSocios()
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

        //Cambiar

        public Socio ObtenerUsuarioPorDocumento(string documento)
        {
            ServicioCliente servicioCliente = new ServicioCliente();
            Cliente infoCliente = servicioCliente.ObtenerClientePorDocumento(documento);
            Socio usuario = null;
            try
            {
                MessageBox.Show("El Cliente ya existe en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"El Cliente no existe en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                
                if (infoCliente!=null)
            {
                ;
                MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("BuscarSocioPorNumeroDeSocio", sqlCon);
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_documento", documento);
                    sqlCon.Open();
                    try
                    {
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }


                return usuario;
        }

        // Tercer servicio insertar un usuario a la db
        // stored prodcedure InsertarSocio
        public bool InsertarUsuario(Socio usuario)
        {
            bool exito = false;
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand("InsertarSocio", sqlCon);
            {
                //mostramos un mensaje verificamos nombre y documento que no este vacio
                if (string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Documento))
                {
                    MessageBox.Show("El nombre y el documento no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@documento", usuario.Documento);
                    comando.Parameters.AddWithValue("@fecha", usuario.Fecha_Inscripcion);
                    comando.Parameters.AddWithValue("@estado", usuario.Estado.ToString());

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

        // registramos pago a la db
        public bool RegistrarPago(PagoCuota pago)
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


    }
}
