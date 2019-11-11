using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class AtractivosTuristicos:BaseDTO
    {
        public string NombreAtractivo { get; set; }
        public string Direccion { get; set; }
        public string TipoAtractivo { get; set; }
        public string URL { get; set; }
    }
}
