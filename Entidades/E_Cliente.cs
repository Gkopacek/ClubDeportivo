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

        public int? idCliente;
        public string Nombre, Apellido, NumeroDocumento; // Telefono, 
        public bool estado;
       // public E_Cuota cuota;


        public E_Cliente(string nombre, string apellido, string numeroDocumento, bool estado) // , string telefono
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            //Telefono = telefono;
            this.NumeroDocumento = numeroDocumento;
            this.estado = estado;
        }

        public bool registrar()
        {
            return this.estado;
        }

        public bool pagar()
        {
            return false;
        }


    }
}
