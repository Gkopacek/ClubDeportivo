


using System.Data;

using MySql.Data.MySqlClient;

namespace pruebas_club_deportivo
{
    

public class ServicioUsuario
    {
        private readonly Conecto _conecto;

        public ServicioUsuario(Conecto conecto)
        {
            _conecto = conecto;
        }




        // Primer servio obtener todos los usuarios
        public List<Usuario> ObtenerUsuarios() 
        {
            var listaUsuarios = new List<Usuario>();
            using (var conexion = _conecto.ObtenerConexion())
            using (var comando = new MySqlCommand("ObtenerSocios", conexion)) 
            {
                comando.CommandType = CommandType.StoredProcedure;

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
        : Estado.Inactivo

                        });
                    }
                }
            }

            return listaUsuarios; 
        }
    }

}
