using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class Fotos
    {
        public int IDFotos { get; set; }
        public string ProvieneDe { get; set; }
        public string URL { get; set; }
        public DateTime FechaYHora { get; set; }
        public string Notas { get; set; }
        public int IDUsuarioModificador { get; set; }
        public int IDUsuarioValidador { get; set; }
    }
}
