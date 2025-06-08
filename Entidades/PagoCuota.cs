using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalClub.Entidades
{
    public class PagoCuota

    {

        //implementamos la clase pago con los atributos: documento, fecha, monto y metodo de pago
        public string Documento { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public int Cantidad_meses { get; set; }
        public DateTime? Fecha_vencimiento { get; set; }

        public PagoCuota(string documento, DateTime fecha, decimal ValorCuota, int cantidadMeses, decimal monto, string metodoPago)
        {    

            Documento = documento;
            Fecha = fecha;
            Cantidad_meses = cantidadMeses;
            Monto = monto;
            MetodoPago = metodoPago;

        }


        public PagoCuota() // Constructor por defecto
        {
            Documento = string.Empty;
            Fecha = DateTime.Now;
            Monto = 0.0m;
            MetodoPago = string.Empty;
        }
    }
}
