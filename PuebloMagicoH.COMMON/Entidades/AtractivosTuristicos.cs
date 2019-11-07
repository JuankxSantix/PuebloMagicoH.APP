using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class AtractivosTuristicos
    {
        public int IDAtractivosTuristicos { get; set; }
        public string NombreAtractivo { get; set; }
        public string Direccion { get; set; }
        public string TipoAtractivo { get; set; }
        public string Descripcion { get; set; }
        public string URL { get; set; }
        public int IDUsuarioModificador { get; set; }
        public int IDUsuarioValidador { get; set; }
    }
}
