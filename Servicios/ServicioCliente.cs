


using System.Data;
using MenuPrincipalClub.Datos;
using MenuPrincipalClub.Entidades;
using MySql.Data.MySqlClient;
using pruebas_club_deportivo;

namespace MenuPrincipalClub.Servicios
{
    

public class ServicioCliente
    {
        // Primer servicio obtener todos los usuarios
        public List<Usuario> ObtenerUsuarios()
        {
            var listaUsuarios = new List<Usuario>();

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
                    listaUsuarios.Add(new Usuario
                    {
                        Id = lector.GetInt32(0),
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
    }

}
