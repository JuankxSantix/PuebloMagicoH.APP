using PuebloMagicoH.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Interfaces
{
    public interface IManejadorDeComercios:IManejadorGenerico<Comercio>
    {
        List<Comercio> ListarPCategoria { get; }
    }
}
