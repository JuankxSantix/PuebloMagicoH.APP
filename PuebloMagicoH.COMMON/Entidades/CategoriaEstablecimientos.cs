using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class CategoriaEstablecimientos
    {
        public int IDCategoriaEstablecimientos { get; set; }
        public int EsSectorPublico { get; set; }
        public int EsEmergencia { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaYHora { get; set; }
        public string Notas { get; set; }
        public int IDUsuarioModificador { get; set; }
        public int IDUsuarioValidador { get; set; }
    }
}
