using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalClub.Entidades
{
    public abstract class Cliente
    {


        //definimos persona con nombre, apellido, nuemro de documento
        public string Nombre { get; set; }
      
        public string Documento { get; set; }
        //definimos un constructor para inicializar los valores
        
    }
}
