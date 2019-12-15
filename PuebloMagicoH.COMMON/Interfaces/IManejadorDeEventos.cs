using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Interfaces
{
    public interface IManejadorDeEventos: IManejadorGenerico<Eventos>
    {
        List<Eventos> EventosEntre(DateTime FechaInicio, DateTime FechaFin);
        List<Eventos> EvendoDelDia(DateTime Fecha);
    }
}
