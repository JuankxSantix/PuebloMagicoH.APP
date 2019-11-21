using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorFotos : IManejadorDeFotos
    {
        IRepositorio<Fotos> repositorio;
        public ManejadorFotos(IRepositorio<Fotos> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<Fotos> Listar => repositorio.Read;

        public bool AGREGAR(Fotos entidad)
        {
            return repositorio.Create(entidad);
        }

        public Fotos BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.id == Id).SingleOrDefault();
        }

        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Fotos entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
