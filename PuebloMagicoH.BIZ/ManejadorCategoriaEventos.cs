using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorCategoriaEventos : IManejadorDeCategoriaEventos

    {
        IRepositorio<CategoriaEventos> repositorio;
        public ManejadorCategoriaEventos(IRepositorio<CategoriaEventos> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<CategoriaEventos> Listar => repositorio.Read;

        public bool AGREGAR(CategoriaEventos entidad)
        {
            return repositorio.Create(entidad);
        }

        public CategoriaEventos BuscarPorID(string Id)
        {
            return Listar.Where(e => e.ID == Id).SingleOrDefault();
        }

        public bool Eliminar(string id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(CategoriaEventos entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
