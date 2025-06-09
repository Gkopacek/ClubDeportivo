using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipalClub.Entidades
{

    /*
      `idActividad` int NOT NULL,
  `Nombre_de_actividad` varchar(50) NOT NULL,
  `Precio_por_dia` decimal(10,0) DEFAULT NULL,
     */
    public class Actividad
    {
        public int IdActividad { get; set; }

        public string NombreDeActividad { get; set; } = null!;

        public decimal? PrecioPorDia { get; set; }

        // Constructor con parámetros (incluye valor por defecto para el campo opcional)
        public Actividad(int id, string nombre, decimal? precioPorDia = null)
        {
            IdActividad = id;
            NombreDeActividad = nombre;
            PrecioPorDia = precioPorDia;
        }
    }

}
