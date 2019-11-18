using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorEventoCategoria : IManejadorDeEventoCategoria
    {
        IRepositorio<EventoCategoria> repositorio;
        public ManejadorEventoCategoria(IRepositorio<EventoCategoria> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<EventoCategoria> Listar => repositorio.Read;

        public bool AGREGAR(EventoCategoria entidad)
        {
            return repositorio.Create(entidad);
        }

        public EventoCategoria BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.ID == Id).SingleOrDefault();
        }

        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(EventoCategoria entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
