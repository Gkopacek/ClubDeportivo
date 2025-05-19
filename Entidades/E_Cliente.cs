using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalClub.Entidades
{
    public class E_Cliente
    {
        /*
         En la proxima iteracion se buscara implementar la clase Cuota en el constructor y seimplementara la encapsulazion de los atributos haciendolos accesibles atravez de metodos Set y Get (Por el momentose deja asi porque se busca poder probar de agregar clientes a la DB de manera rápida).
         */

        public int? idCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroDocumento { get; set; } // Telefono, 
        public string estado { get; set; }
       // public E_Cuota cuota;


        public E_Cliente(string nombre, string apellido, string numeroDocumento, string estado) // , string telefono
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            //Telefono = telefono;
            this.NumeroDocumento = numeroDocumento;
            this.estado = estado;
        }

        public string registrar()
        {
            return this.estado;
        }

        public bool pagar()
        {
            return false;
        }


    }
}
