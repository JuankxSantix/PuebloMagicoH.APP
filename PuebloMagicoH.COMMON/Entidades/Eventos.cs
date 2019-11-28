using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class Eventos:ClassIntermediaDto
    {
        public string LugarEvento { get; set; }
        public string NombreEvento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public float Costo { get; set; }
        public int IDLugar { get; set; }
        //public byte[] Fotografia { get; set; }
    }
}
