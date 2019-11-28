using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class Hoteles:ClassIntermediaDto
    {
        public string NombreHotel { get; set; }
        public int HabitacionesDisponibles { get; set; }
        public string Direccion { get; set; }
    }
}
