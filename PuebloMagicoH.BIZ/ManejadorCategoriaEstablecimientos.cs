using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorCategoriaEstablecimientos : IManejadorDeCategoriaEstablecimientos
    {
        IRepositorio<CategoriaEstablecimientos> repositorio;
        public ManejadorCategoriaEstablecimientos(IRepositorio<CategoriaEstablecimientos> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<CategoriaEstablecimientos> Listar => repositorio.Read;

        public bool AGREGAR(CategoriaEstablecimientos entidad)
        {
            return repositorio.Create(entidad);
        }

        public CategoriaEstablecimientos BuscarPorID(string Id)
        {
            return Listar.Where(e => e.ID == Id).SingleOrDefault();
        }

        public bool Eliminar(string id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(CategoriaEstablecimientos entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
