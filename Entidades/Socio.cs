using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MenuPrincipalClub.Entidades
{

    

    public class Socio : Persona
    {
        //hacemos que el tipo solo pueda tomar el valor "Socio" no se pueda reemplazar
        // definimos tipo para que solo tomo el valor "Socio" y no pueda tomar otro valor
        //public Tipo Tipo { get; set; } = Tipo.Socio; // Por defecto, el tipo es Socio

        //asignamos a tipo el valor "socio" como constante
        public string Tipo { get; set; } = "socio"; // Por defecto, el tipo es Socio

        public Socio(string nombre, string apellido, string documento, Estado estado, DateTime fechaInscripcion, bool apto_fisico)
        {
            Nombre = nombre;            
            Documento = documento;            
            Estado = estado;
            Fecha_Inscripcion = fechaInscripcion;
            // Asignamos el tipo de socio
            Apto_Fisico = apto_fisico; // Asignamos si presentó apto físico
        }
        public Socio() // Constructor por defecto
        {
            Nombre = string.Empty;
            Documento = string.Empty;            
            Estado = Estado.Activo;
            Fecha_Inscripcion = DateTime.Now;
            Tipo = "socio"; // Por defecto, el tipo es Socio
            Apto_Fisico = false; // Por defecto, no se presenta apto físico
        }
    }

}
