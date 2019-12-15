
using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.EntidadBase;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorCategoriaEstablecimientos : IManejadorDeCategoriaEstablecimientos
    {
        IRepositorio<CategoriaEstablecimiento> repositorio;
        public ManejadorCategoriaEstablecimientos(IRepositorio<CategoriaEstablecimiento> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<CategoriaEstablecimiento> Listar => repositorio.Read;


        public bool AGREGAR(CategoriaEstablecimiento entidad)
        {
            return repositorio.Create(entidad);
        }

        public CategoriaEstablecimiento BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.id == Id).SingleOrDefault();
        }
        
        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(CategoriaEstablecimiento entidad)
        {
            return repositorio.Update(entidad);
        }
        
    }
}
