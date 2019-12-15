using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades.EntidadBase
{
    public class CategoriaEventos:BaseDTO
    {
        public string Nombre { get; set; }
        public bool EsComoTeSientesHoy { get; set; }
    }
}
