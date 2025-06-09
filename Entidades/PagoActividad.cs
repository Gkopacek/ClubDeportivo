using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalClub.Entidades
{

    /*
      `idpago_actividad` int NOT NULL AUTO_INCREMENT,
  `idActividad` int NOT NULL,
  `NCliente` int NOT NULL,
  `Metodo_pago` varchar(45) NOT NULL,
  `fecha_pago` datetime NOT NULL DEFAULT CURRENT_TIMESTA
     */

    public class PagoActividad
    {
        public int? idpago_actividad { get; set; }
        public int idActividad { get; set; }
        public int NCliente { get; set; }
        public string Metodo_pago { get; set; }
        public DateTime fecha_pago { get; set; }


        // Constructor completo parametrizado
        public PagoActividad(int? idpago_actividad, int idActividad, int NCliente, string Metodo_pago, DateTime fecha_pago)
        {
            this.idpago_actividad = idpago_actividad;
            this.idActividad = idActividad;
            this.NCliente = NCliente;
            this.Metodo_pago = Metodo_pago;
            this.fecha_pago = fecha_pago;
        }
    }



}
