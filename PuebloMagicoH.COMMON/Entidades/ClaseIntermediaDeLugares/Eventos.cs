using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares
{
    public class Eventos:ClassIntermediaLugares
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public float Costo { get; set; }
        public string Horario { get; set; }
    }
}
