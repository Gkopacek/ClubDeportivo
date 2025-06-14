



using System;
using System.Windows.Forms;
using MenuPrincipalClub;
using MenuPrincipalClub.Datos;
using MenuPrincipalClub.Forms;

static class Program
{
    /// <summary>
    /// Punto de entrada principal de la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {

        // Después de que el usuario complete el form de configuración:
        //Conexion.Configurar("127.0.0.1", "3306", "root", "", "Club_Deportivo_2");

        // abro el form para configurar la clase conexion




        //
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);


        ///
        // Mostrar primero el form de configuración
        var configForm = new frmConfiguracion();
        if (configForm.ShowDialog() == DialogResult.OK)
        {
            // Solo abrir el form principal si se configuró
            Application.Run(new frmPrincipal());
        }
        else
        {
            MessageBox.Show("La aplicación necesita ser configurada.");
        }
    }
}