using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class Eventos
    {
        public int IDEvento { get; set; }
        public int LugarEvento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public int DescripcionEvento { get; set; }
        public int Costo { get; set; }
        public int Notas { get; set; }
        public int IDLugar { get; set; }
        public int IDUsuarioModificador { get; set; }
        public int IDUsuarioValidador { get; set; }
    }
}
