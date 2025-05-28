using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalClub.Entidades.NewFolder
{
    internal abstract class E_Cliente
    {
        /*
         En la proxima iteracion se buscara implementar la clase Cuota en el constructor y seimplementara la encapsulazion de los atributos haciendolos accesibles atravez de metodos Set y Get (Por el momentose deja asi porque se busca poder probar de agregar clientes a la DB de manera rápida).
         */

        public int? idCliente;
        public string Nombre, Apellido, Telefono, NumeroDocumento;
        public bool Activo;
       // public E_Cuota cuota;


        public E_Cliente(string nombre, string apellido, string telefono, string numeroDocumento, bool activo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            NumeroDocumento = numeroDocumento;
            Activo = activo;
        }

        public bool registrar()
        {
            return Activo;
        }

        public bool pagar()
        {
            return false;
        }


    }
}
