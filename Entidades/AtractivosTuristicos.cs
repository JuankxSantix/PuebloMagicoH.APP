using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class AtractivosTuristicos
    {
        public int IDAtractivosTuristicos { get; set; }
        public int NombreAtractivo { get; set; }
        public int Direccion { get; set; }
        public int TipoAtractivo { get; set; }
        public int Descripcion { get; set; }
        public int URL { get; set; }
        public int IDUsuarioModificador { get; set; }
        public int IDUsuarioValidador { get; set; }
    }
}
