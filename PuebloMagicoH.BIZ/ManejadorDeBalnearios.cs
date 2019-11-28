using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorDeBalnearios : IManejadorDeBalnearios
    {
        IRepositorio<Balnearios> repositorio;
        public ManejadorDeBalnearios(IRepositorio<Balnearios> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<Balnearios> Listar => repositorio.Read;

        public bool AGREGAR(Balnearios entidad)
        {
            return repositorio.Create(entidad);
        }

        public Balnearios BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.id == Id).SingleOrDefault();
        }

        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Balnearios entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
