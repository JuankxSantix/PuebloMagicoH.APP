using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares.SubClaseIntermediaLugares;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorDeGuias : IManejadorDeGuias
    {
        IRepositorio<Guias> repositorio;
        public ManejadorDeGuias(IRepositorio<Guias> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<Guias> Listar => repositorio.Read;

        public bool AGREGAR(Guias entidad)
        {
            return repositorio.Create(entidad);
        }

        public Guias BuscarPorID(ObjectId Id)
        {
            return repositorio.Read.Where(e=> e.id==Id).SingleOrDefault();
        }
        
        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Guias entidad)
        {
            return repositorio.Update(entidad);
        }
        
    }
}
