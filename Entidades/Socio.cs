using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MenuPrincipalClub.Entidades
{

    public enum Estado
    {
        //[Description("activo")]
        Activo = 0,
        //[Description("inactivo")]
        Inactivo = 1,

    }

    // definimos para que tipo solo puede ser "Socio" o "No Socio"
    public enum Tipo
    {
        Socio
        
    }

    public class Socio : Persona
    {
        //hacemos que heredemos de persona y agregamos los atributos: id, estado, fecha de inscripcion
        
        public Estado Estado { get; set; }
        public DateTime Fecha_Inscripcion { get; set; }
        // definimos tipo para que solo tomo el valor "Socio" y no pueda tomar otro valor
        public Tipo Tipo { get; set; } = Tipo.Socio; // Por defecto, el tipo es Socio

        // creamos atirbuto presento apto_fisico que solo puede tomar valor si o no
        public bool Apto_Fisico { get; set; } = false; // Por defecto, no se presenta apto físico



        // Nueva propiedad solo lectura
        public string Apto_Fisico_Descripcion => Apto_Fisico ? "Sí" : "No";

        public Socio(string nombre, string apellido, string documento, Estado estado, DateTime fechaInscripcion, Tipo tipo, bool apto_fisico)
        {
            Nombre = nombre;            
            Documento = documento;            
            Estado = estado;
            Fecha_Inscripcion = fechaInscripcion;
            Tipo = tipo; // Asignamos el tipo de socio
            Apto_Fisico = apto_fisico; // Asignamos si presentó apto físico
        }
        public Socio() // Constructor por defecto
        {
            Nombre = string.Empty;
            Documento = string.Empty;            
            Estado = Estado.Activo;
            Fecha_Inscripcion = DateTime.Now;
            Tipo = Tipo.Socio; // Por defecto, el tipo es Socio
            Apto_Fisico = false; // Por defecto, no se presenta apto físico
        }
    }

}
