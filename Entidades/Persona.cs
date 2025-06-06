using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mysqlx.Cursor;

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
    //public enum Tipo
    //{
    //    socio,

        
    //    NoSocio

    //}

    public abstract class Persona
    {


        //definimos persona con nombre, apellido, nuemro de documento
        public string Nombre { get; set; }
      
        public string Documento { get; set; }
        //definimos un constructor para inicializar los valores

        public DateTime Fecha_Inscripcion { get; set; }


        public Estado Estado { get; set; }
        
        // definimos tipo para que solo tomo el valor "Socio" y no pueda tomar otro valor
        public String Tipo { get; set; } // Por defecto, el tipo es Socio

        // creamos atirbuto presento apto_fisico que solo puede tomar valor si o no
        public bool Apto_Fisico { get; set; } = false; // Por defecto, no se presenta apto físico



        // Nueva propiedad solo lectura
        public string Apto_Fisico_Descripcion => Apto_Fisico ? "Sí" : "No";

        //public string TipoTexto => Tipo == Tipo.NoSocio ? "no socio" : "socio";


    }
}
