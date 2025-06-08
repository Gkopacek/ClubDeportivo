



using System;
using System.Windows.Forms;
using MenuPrincipalClub;
using MenuPrincipalClub.Entidades;
using MenuPrincipalClub.Servicios;
using static System.Runtime.InteropServices.JavaScript.JSType;

static class Program
{
    /// <summary>
    /// Punto de entrada principal de la aplicación.
    /// </summary>
    [STAThread]
    static void Main()



    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new frmLogin()); // Asegúrate de que `Form1` es el formulario correcto
      

    }
}