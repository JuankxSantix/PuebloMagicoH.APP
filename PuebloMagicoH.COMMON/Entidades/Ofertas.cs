using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class Ofertas:BaseDTO
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public int Horarios { get; set; }
        public int IDEstablecimientos { get; set; }
    }
}
