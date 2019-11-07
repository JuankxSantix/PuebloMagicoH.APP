using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class CategoriaEventos
    {
        public int IDCategoriaEventos { get; set; }
        public int Nombre { get; set; }
        public int Descripcion { get; set; }
        public int Lugar { get; set; }
        public DateTime FechaYHora { get; set; }
        public int Notas { get; set; }
        public int IDUsuarioModificador { get; set; }
        public int IDUsuarioValidador { get; set; }
    }
}
