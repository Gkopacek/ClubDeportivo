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

    public class Socio : Persona
    {
        //hacemos que heredemos de persona y agregamos los atributos: id, estado, fecha de inscripcion
        public int Id { get; set; }
        public Estado Estado { get; set; }
        public DateTime Fecha_Inscripcion { get; set; }
        //definimos un constructor para inicializar los valores
        public Socio(string nombre, string apellido, string documento, int id, Estado estado, DateTime fechaInscripcion)
        {
            Nombre = nombre;
            
            Documento = documento;
            Id = id;
            Estado = estado;
            Fecha_Inscripcion = fechaInscripcion;
        }
        public Socio() // Constructor por defecto
        {
            Nombre = string.Empty;
            Documento = string.Empty;
            Id = 0;
            Estado = Estado.Activo;
            Fecha_Inscripcion = DateTime.Now;
        }
    }

}
