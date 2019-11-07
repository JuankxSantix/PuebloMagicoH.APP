using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class Eventos
    {
        public int IDEvento { get; set; }
        public string LugarEvento { get; set; }
        public string NombreEvento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string DescripcionEvento { get; set; }
        public float Costo { get; set; }
        public string Notas { get; set; }
        public int IDLugar { get; set; }
        public int IDUsuarioModificador { get; set; }
        public int IDUsuarioValidador { get; set; }
    }
}
