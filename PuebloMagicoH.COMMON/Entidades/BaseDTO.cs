using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public abstract class BaseDTO
    {
        public string ID { get; set; }
        public DateTime FechaYHora { get; set; }
        public int Notas { get; set; }
        public int IDUsuarioModificador { get; set; }
        public int IDUsuarioValidador { get; set; }
        public string Descripcion { get; set; }
    }
}
