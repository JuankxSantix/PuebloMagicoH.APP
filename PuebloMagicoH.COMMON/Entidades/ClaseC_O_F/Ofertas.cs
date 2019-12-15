using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades.ClaseC_O_F
{
    public class Ofertas:BaseDTO
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Horario { get; set; }
        public ObjectId IdComercio { get; set; }
    }
}
