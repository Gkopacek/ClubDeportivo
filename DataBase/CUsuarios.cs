using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MenuPrincipalClub.Datos
{
    internal class CUsuarios
    {
        public DataTable LogInUsuario(string usuario, string contrasenia)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.CrearConexion();
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = contrasenia;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);

                return tabla;

            }
            catch (Exception ex)
            {
                throw;
            }

            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}

//prueba modificacion