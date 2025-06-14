using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MenuPrincipalClub.Datos
{
    public static class Conexion
    {
        private static string? nombreDB, svDB, puertoDB, usuario, contrasenia;
        private static bool estaConfigurado = false;

        public static void Configurar(string servidor, string puerto, string usuarioBD, string contrasenaBD, string baseDeDatos)
        {
            svDB = servidor;
            puertoDB = puerto;
            usuario = usuarioBD;
            contrasenia = contrasenaBD;
            nombreDB = baseDeDatos;
            estaConfigurado = true;
        }

        public static MySqlConnection CrearConexion()
        {
            if (!estaConfigurado)
                throw new InvalidOperationException("La conexión no fue configurada. Usá Conexion.Configurar(...) antes.");

            var cadena = new MySqlConnection();

            cadena.ConnectionString = $"datasource={svDB};port={puertoDB};username={usuario};password={contrasenia};Database={nombreDB}";

            return cadena;
        }
    }


}

