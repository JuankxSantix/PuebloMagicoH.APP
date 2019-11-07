using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class EventoCategoria
    {
        public int IDEventoCategoria { get; set; }
        public DateTime FechaYHora { get; set; }
        public int Notas { get; set; }
        public int IDUsuarioModificador { get; set; }
        public int IDUsuarioValidador { get; set; }
        public int IDCategoria { get; set; }
        public Eventos Evento { get; set; }
    }
}
