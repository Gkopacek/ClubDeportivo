



using System;
using System.Windows.Forms;
using MenuPrincipalClub;

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
        Application.Run(new frmInicio()); // Asegúrate de que `Form1` es el formulario correcto
    }
}