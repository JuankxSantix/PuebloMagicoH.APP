﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class EventoCategoria:BaseDTO
    {
        public int IDCategoria { get; set; }
        public Eventos Evento { get; set; }
    }
}
