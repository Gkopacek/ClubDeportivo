


using System.Data;
using MenuPrincipalClub.Datos;
using MySql.Data.MySqlClient;

namespace pruebas_club_deportivo
{
    

public class ServicioCliente
    {
        
        

        // Primer servio obtener todos los usuarios
        public List<Usuario> ObtenerUsuarios() 
        {
            var listaUsuarios = new List<Usuario>();
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand("ObtenerSocios", sqlCon);
            {
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                using (var lector = comando.ExecuteReader())
                {
                    
                    while (lector.Read())
                    {
                        listaUsuarios.Add(new Usuario
                        {

                            Id = lector.GetInt32(0),
                            Nombre = lector.GetString(1),
                            //Estado = (Estado)Enum.Parse(typeof(Estado), lector.GetString(4), ignoreCase: true)
                            Estado = Enum.TryParse(lector.GetString(4), ignoreCase: true, out Estado estado)
                        ? estado
                        : Estado.Inactivo,

                            Fecha_Inscripcion = lector.GetDateTime(3),
                            Documento = lector.GetString(2)

                        });
                        
                    }
                    
                }
            }

            return listaUsuarios; 
        }
    }

}
