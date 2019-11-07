using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class Comentarios
    {
        public int IDComentarios { get; set; }
        public string Comentario { get; set; }
        public int Calificacion { get; set; }
        public int QuejaVisible { get; set; }
        public int EsQueja { get; set; }
        public string Respuesta { get; set; }
        public DateTime FechaYHora { get; set; }
        public string Notas { get; set; }
        public int IDUsuario { get; set; }
        public int Establecimiento { get; set; }
        public int IDUsuarioModificador { get; set; }
        public int IDUsuarioValidador { get; set; }
    }
}
}
