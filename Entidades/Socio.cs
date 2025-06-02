using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MenuPrincipalClub.Entidades.NewFolder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MenuPrincipalClub.Entidades
{

    public enum Estado
    {
        //[Description("activo")]
        Activo = 0,
        //[Description("inactivo")]
        Inactivo = 1,

    }

    public class Socio : Cliente
    {
        public int Nsocio { get; set; }
        public Estado Estado { get; set; }
        public DateTime Fecha_Inscripcion { get; set; }

        // Constructor con todos los parámetros necesarios para la clase base y las propiedades específicas de Socio
        public Socio(string nombre, string apellido, string documento,
                     string email, string telefono, int nsocio, Estado estado, DateTime fechaInscripcion) :
            base(nombre, apellido, documento, email, telefono)
        {
            Nsocio = nsocio;
            Estado = estado;
            Fecha_Inscripcion = fechaInscripcion;
        }

        // Constructor por defecto que inicializa propiedades con valores predeterminados
        public Socio() : base(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty)
        {

            Nombre = string.Empty;
            Documento = string.Empty;
            Nsocio = 0;
            Estado = Estado.Activo;
            Fecha_Inscripcion = DateTime.Now;
        }

        public Socio(string nombre, string apellido, string documento, string email, string telefono) : base(nombre, apellido, documento, email, telefono)
        {
        }
    }

}
