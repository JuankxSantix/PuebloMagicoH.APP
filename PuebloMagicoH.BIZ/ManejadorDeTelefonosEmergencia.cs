
using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares.SubClaseIntermediaLugares;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorDeTelefonosEmergencia : IManejadorDeTelefonosEmergencia
    {
        IRepositorio<TelefonosEmergencia> repositorio;
        public ManejadorDeTelefonosEmergencia(IRepositorio<TelefonosEmergencia> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<TelefonosEmergencia> Listar => repositorio.Read;

        public bool AGREGAR(TelefonosEmergencia entidad)
        {
            return repositorio.Create(entidad);
        }

        public TelefonosEmergencia BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.id == Id).SingleOrDefault();
        }
        
        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(TelefonosEmergencia entidad)
        {
            return repositorio.Update(entidad);
        }
        
    }
}
