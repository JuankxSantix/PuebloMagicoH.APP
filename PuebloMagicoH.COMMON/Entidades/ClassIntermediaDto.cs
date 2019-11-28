﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class ClassIntermediaDto:BaseDTO
    {
        public DateTime? FechaYHora { get; set; }
        public string Notas { get; set; }
        public string IDUsuarioModificador { get; set; }
        public string IDUsuarioValidador { get; set; }
        public string Descripcion { get; set; }
    }
}