using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorTiposDeUsuario : IManejadorDeTiposDeUsuario
    {
        IRepositorio<TipoDeUsuario> repositorio;
        public ManejadorTiposDeUsuario(IRepositorio<TipoDeUsuario> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<TipoDeUsuario> Listar => throw new NotImplementedException();

        public bool AGREGAR(TipoDeUsuario entidad)
        {
            return repositorio.Create(entidad);
        }

        public TipoDeUsuario BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.ID == Id).SingleOrDefault();
        }

        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(TipoDeUsuario entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
