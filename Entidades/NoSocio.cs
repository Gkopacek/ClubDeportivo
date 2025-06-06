using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuPrincipalClub.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MenuPrincipalClub.Entidades
{

    //enum tipo No Socio
    

    public class NoSocio:Persona
    {

        //definimos atributo tipo ccomo constante "No Socio"


        
        public NoSocio()
        {

        }



        public string Tipo { get; set; } = "no socio";
        public NoSocio(string nombre, string apellido, string documento, Estado estado, DateTime fechaInscripcion, bool apto_fisico)
        {
            Nombre = nombre;
            Documento = documento;
            Estado = estado;
            Fecha_Inscripcion = fechaInscripcion;
            // Asignamos el tipo de No Socio
            Apto_Fisico = apto_fisico; // Asignamos si presentó apto físico
        }




    }
}


