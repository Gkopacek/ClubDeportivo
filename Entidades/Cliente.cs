using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MenuPrincipalClub.Entidades
{
    public class Cliente
    {


        //definimos persona con nombre, apellido, nuemro de documento
       
        //public string NCliente {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        //public DateTime FechaRegistro { get; set; }

        // Constructor que inicializa todos los campos
        public Cliente( string nombre, string apellido,
                       string documento, string email, string telefono
                       )
        {
            
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Email = email;
            Telefono = telefono;
            
        }

        //definimos un constructor para inicializar los valores

    }
}
