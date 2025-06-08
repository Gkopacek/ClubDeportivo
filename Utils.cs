using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuPrincipalClub.Datos;
using MenuPrincipalClub.Entidades;
using MySql.Data.MySqlClient;

namespace MenuPrincipalClub
{
    internal class Utils
    {
        public static Decimal ObtenerValorCuota()
        {
            Decimal ValorCuota = 0;
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand("ObtenerValorCuota", sqlCon);
            comando.CommandType = CommandType.StoredProcedure;
            sqlCon.Open();
            using (var lector = comando.ExecuteReader())
            {
                if (lector.Read())
                {
                    ValorCuota = lector.GetDecimal(0);
                }
                return ValorCuota;
            }
        }
    }
}
