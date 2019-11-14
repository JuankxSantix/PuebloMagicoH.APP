using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorAtractivosTuristicos : IManejadorDeAtractivosTuristicos
    {
        IRepositorio<AtractivosTuristicos> repositorio;
        public ManejadorAtractivosTuristicos(IRepositorio<AtractivosTuristicos> repositoio)
        {
            this.repositorio = repositorio;
        }
        public List<AtractivosTuristicos> Listar => repositorio.Read;

        public bool AGREGAR(AtractivosTuristicos entidad)
        {
            return repositorio.Create(entidad);
        }

        public AtractivosTuristicos BuscarPorID(string Id)
        {
            return Listar.Where(e => e.ID == Id).SingleOrDefault();
        }

        public bool Eliminar(string id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(AtractivosTuristicos entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
