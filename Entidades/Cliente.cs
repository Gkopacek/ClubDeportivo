using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MenuPrincipalClub.Entidades
{
    public abstract class Cliente
    {


        //definimos persona con nombre, apellido, nuemro de documento
       
        public string NCliente {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public Date FechaRegistro { get; set; }

        // Constructor que inicializa todos los campos
        public Cliente(string nCliente, string nombre, string apellido,
                       string documento, string email, string telefono,
                       Date fechaRegistro)
        {
            NCliente = nCliente;
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Email = email;
            Telefono = telefono;
            FechaRegistro = fechaRegistro;
        }

        //definimos un constructor para inicializar los valores

    }
}
