using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MenuPrincipalClub.Datos
{
    public class Conexion
    {
        private String nombreDB, svDB, puertoDB, usuario, contrasenia;
        private static Conexion? con = null;

        public Conexion()
        {
            this.nombreDB = "Club_Deportivo_2";
            this.svDB = "127.0.0.1";
            this.puertoDB = "3306";
            this.usuario = "root";
            this.contrasenia = "";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.svDB +
                                          ";port=" + this.puertoDB +
                                          ";username=" + this.usuario +
                                          ";password=" + this.contrasenia +
                                          ";Database=" + this.nombreDB;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }

        public Conexion GetConexion()
        {
            return this;
        }

    }

    
}

