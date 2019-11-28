using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorDeHoteles : IManejadorDeHoteles
    {
        IRepositorio<Hoteles> repositorio;
        public ManejadorDeHoteles(IRepositorio<Hoteles> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<Hoteles> Listar => repositorio.Read;

        public bool AGREGAR(Hoteles entidad)
        {
            return repositorio.Create(entidad);
        }

        public Hoteles BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.id == Id).SingleOrDefault();
        }

        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Hoteles entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
