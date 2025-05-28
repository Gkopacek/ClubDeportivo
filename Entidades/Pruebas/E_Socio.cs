using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalClub.Entidades.NewFolder
{
    internal class E_Socio : E_Cliente
    {
        public int? NumeroDeSocio { get; set; }
        public bool TieneCarnet { get; set; }

        // Constructor de la subclase Socio
        public E_Socio(string nombre, string apellido, string telefono, string numeroDocumento, bool activo, bool tieneCarnet)
            : base(nombre, apellido, telefono, numeroDocumento, activo) // Llamada al constructor de Cliente
        {
            TieneCarnet = tieneCarnet;
        }

        // Método ToString para imprimir la información del socio
        public override string ToString()
        {
            return base.ToString() + $", Número de Socio: {NumeroDeSocio}, Tiene Carnet: {TieneCarnet}";
        }
    }
}
