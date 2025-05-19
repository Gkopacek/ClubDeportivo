


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
                    string nombreCompleto = cliente.GetString(1);
                    int espacio = nombreCompleto.IndexOf(' ');

                    string nombre = espacio > 0 ? nombreCompleto.Substring(0, espacio) : nombreCompleto;
                    string apellido = espacio > 0 ? nombreCompleto.Substring(espacio + 1) : "";

                    clienteNuevo = new E_Cliente(
                            
                        nombre,
                        apellido,                        
                        //Estado = (Estado)Enum.Parse(typeof(Estado), lector.GetString(4), ignoreCase: true)
                        cliente.GetString(2),
                        cliente.GetString(4)

                    );
                    clienteNuevo.idCliente = cliente.GetInt32(0);
                    listaUsuarios.Add(clienteNuevo);
                        
                }
                    
            }
        }

        return listaUsuarios; 
    }
}

}
