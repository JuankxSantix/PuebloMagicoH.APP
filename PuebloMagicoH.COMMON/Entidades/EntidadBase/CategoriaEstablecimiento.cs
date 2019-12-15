using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades.EntidadBase
{
    public class CategoriaEstablecimiento:BaseDTO
    {
        public string Nombre { get; set; }
        public override string ToString()
        {
            return string.Format("{0}",Nombre);
        }
    }
}
