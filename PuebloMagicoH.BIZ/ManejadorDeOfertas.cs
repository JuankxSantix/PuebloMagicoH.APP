using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorDeOfertas : IManejadorDeOfertas
    {
        IRepositorio<Ofertas> repositorio;
        public ManejadorDeOfertas(IRepositorio<Ofertas> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<Ofertas> Listar => repositorio.Read;

        public bool AGREGAR(Ofertas entidad)
        {
            return repositorio.Create(entidad);
        }

        public Ofertas BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.id == Id).SingleOrDefault();
        }

        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Ofertas entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
