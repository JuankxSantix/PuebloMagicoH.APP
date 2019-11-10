using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class Comentarios
    {
        public int Calificacion { get; set; }
        public int QuejaVisible { get; set; }
        public int EsQueja { get; set; }
        public string Respuesta { get; set; }
        public int IDUsuario { get; set; }
        public int Establecimiento { get; set; }
    }
}

