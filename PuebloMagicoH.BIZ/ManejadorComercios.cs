using PuebloMagicoH.COMMON.Entidades;
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

        public Comercio BuscarPorID(string Id)
        {
            return Listar.Where(e => e.ID == Id).SingleOrDefault();
        }

        public bool Eliminar(string id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Comercio entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
