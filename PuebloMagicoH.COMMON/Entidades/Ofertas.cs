using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class Ofertas
    {
        public int IDOfertas { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public DateTime FechaHora { get; set; }
        public int Horarios { get; set; }
        public int Descripcion { get; set; }
        public int notas { get; set; }
        public int IDUsuarioModificador { get; set; }
        public int IDUsuarioValidador { get; set; }
        public int IDEstablecimientos { get; set; }
    }
}
