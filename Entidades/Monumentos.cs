using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class Monumentos
    {
        public int IDMonumentos { get; set; }
        public int NombreMonumentos { get; set; }
        public int Direccion { get; set; }
        public int TipoDeMonumentos { get; set; }
        public int URL { get; set; }
        public int Notas { get; set; }
        public int IDUsuarioModificador { get; set; }
        public int IDUsuarioValidador { get; set; }
    }
}
