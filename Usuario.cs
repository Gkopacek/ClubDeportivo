using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace pruebas_club_deportivo
{

    public enum Estado
    {
        //[Description("activo")]
        Activo = 0,
        //[Description("inactivo")]
        Inactivo = 1,

    }

    public class Usuario
    {



        public int Id { get; set; }
        public string Nombre { get; set; }
        
        public Estado Estado { get; set; }

        public DateTime Fecha_Inscripcion { get; set; } // Added this property to fix the error
        public string Documento { get; set; } // Added this property as it is used in the ServicioCliente class
    }

}
