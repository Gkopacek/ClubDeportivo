


using System.Data;
using MenuPrincipalClub.Datos;
using MenuPrincipalClub.Entidades;
using MySql.Data.MySqlClient;

namespace pruebas_club_deportivo
{
    

public class ServicioCliente
    {
        
        

        // Primer servio obtener todos los usuarios
        public List<E_Cliente> ObtenerUsuarios() 
        {
            var listaUsuarios = new List<E_Cliente>();
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand("ObtenerSocios", sqlCon);
            {
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                using (var cliente = comando.ExecuteReader())
                {
                    E_Cliente clienteNuevo;
                    while (cliente.Read())
                    {   
                         clienteNuevo = new E_Cliente(
                            
                            cliente.GetString(1),
                            "asd",                        
                            //Estado = (Estado)Enum.Parse(typeof(Estado), lector.GetString(4), ignoreCase: true)
                            cliente.GetString(2),
                            true

                        );
                        listaUsuarios.Add(clienteNuevo);

                        clienteNuevo.idCliente = cliente.GetInt32(0);
                    }
                    
                }
            }

            return listaUsuarios; 
        }
    }

}
