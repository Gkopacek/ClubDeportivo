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

        public int? Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public E_Cliente(int id, string nombre, bool estado)
        {
            Id = id;
            Nombre = nombre;
            Estado = estado;
        }

        public bool registrar()
        {
            return true; //this.estado;
        }

        public bool pagar()
        {
            return false;
        }


    }
}
