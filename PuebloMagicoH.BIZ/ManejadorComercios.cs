using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares.SubClaseIntermediaLugares.SubClaseUsuaiosValidadores;
using PuebloMagicoH.COMMON.Entidades.EntidadBase;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorComercios : IManejadorDeComercios
    {
        IRepositorio<Comercio> repositorio;
        public ManejadorComercios(IRepositorio<Comercio> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<Comercio> Listar => repositorio.Read;


        public bool AGREGAR(Comercio entidad)
        {
            return repositorio.Create(entidad);
        }

        public Comercio BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.id == Id).SingleOrDefault();
        }

        public List<Comercio> CategoriaDeComercio(CategoriaEstablecimiento categoriaEstablecimiento)
        {
            return Listar.Where(e => e.CategoriaEstablecimiento == categoriaEstablecimiento).ToList();
        }

        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Comercio entidad)
        {
            return repositorio.Update(entidad);
        }
        
    }
}
