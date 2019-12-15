using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades.ClaseC_O_F
{
    public class Comentarios:BaseDTO
    {
        public int Calificacion { get; set; }
        public bool EsQuejaVisible { get; set; }
        public bool EsQueja { get; set; }
        public bool EsRespuesta { get; set; }
        public ObjectId Usuario { get; set; }
        public bool EsComentarioComercio { get; set; }
    }
}
