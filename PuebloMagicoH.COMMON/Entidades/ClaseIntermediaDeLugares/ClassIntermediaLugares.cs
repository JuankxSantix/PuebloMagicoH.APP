using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares
{
    public abstract class ClassIntermediaLugares:BaseDTO
    {
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte[] Fotografia { get; set; }
    }
}
