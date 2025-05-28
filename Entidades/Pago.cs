using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalClub.Entidades
{
    public class Pago

    {

        //implementamos la clase pago con los atributos: documento, fecha, monto y metodo de pago
        public string Documento { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public Pago(string documento, DateTime fecha, decimal monto, string metodoPago)
        {
            Documento = documento;
            Fecha = fecha;
            Monto = monto;
            MetodoPago = metodoPago;
        }
        public Pago() // Constructor por defecto
        {
            Documento = string.Empty;
            Fecha = DateTime.Now;
            Monto = 0.0m;
            MetodoPago = string.Empty;
        }
    }
}
