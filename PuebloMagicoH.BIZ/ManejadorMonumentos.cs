using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorMonumentos : IManejadorDeMonumentos
    {
        IRepositorio<Monumentos> repositorio;
        public ManejadorMonumentos(IRepositorio<Monumentos> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<Monumentos> Listar => repositorio.Read;

        public bool AGREGAR(Monumentos entidad)
        {
            return repositorio.Create(entidad);
        }

        public Monumentos BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.ID == Id).SingleOrDefault();
        }

        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Monumentos entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
