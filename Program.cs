



using System;
using System.Windows.Forms;
using MenuPrincipalClub;
using MenuPrincipalClub.Datos;

static class Program
{
    /// <summary>
    /// Punto de entrada principal de la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {

        // Después de que el usuario complete el form de configuración:
        Conexion.Configurar("127.0.0.1", "3306", "root", "", "Club_Deportivo_2");

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new frmLogin()); // Asegúrate de que `Form1` es el formulario correcto
    }
}