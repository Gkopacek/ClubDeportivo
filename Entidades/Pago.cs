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
        //public string MetodoPago { get; set; }

        //definimos el concepto de pago, solo puede tomar valor "actividad" "mensualidad"
        private string _concepto;
        public string Concepto
        {
            get { return _concepto; }
            set
            {
                if (value == "actividad" || value == "mensualidad" || value == string.Empty)
                {
                    _concepto = value;
                }
                else
                {
                    throw new ArgumentException("Concepto debe ser 'actividad' o 'mensualidad'.");
                }
            }
        }


        //definimos constructores
        public Pago(string documento, DateTime fecha, decimal monto, string concepto)
        {
            Documento = documento;
            Fecha = fecha;
            Monto = monto;
            Concepto = concepto;
        }
        // definimos constructor vacio
        public Pago() // Constructor por defecto
        {
            Documento = string.Empty;
            Fecha = DateTime.Now;
            Monto = 0.0m;
            Concepto = string.Empty; // Inicializamos concepto como cadena vacía
        }



        //public Pago(string documento, DateTime fecha, decimal monto, string metodoPago, string concepto)
        //{
        //    Documento = documento;
        //    Fecha = fecha;
        //    Monto = monto;
        //    MetodoPago = metodoPago;
        //    Concepto = concepto;
        //}

        //public Pago(string documento, DateTime fecha, decimal monto, string metodoPago)
        //{
        //    Documento = documento;
        //    Fecha = fecha;
        //    Monto = monto;
        //    MetodoPago = metodoPago;
        //}
        //public Pago() // Constructor por defecto
        //{
        //    Documento = string.Empty;
        //    Fecha = DateTime.Now;
        //    Monto = 0.0m;
        //    MetodoPago = string.Empty;
    }
    
}
