using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorComentarios : ImanejadorDeComentarios
    {
        IRepositorio<Comentarios> repositorio;
        public ManejadorComentarios(IRepositorio<Comentarios> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<Comentarios> Listar => repositorio.Read;

        public bool AGREGAR(Comentarios entidad)
        {
            return repositorio.Create(entidad);
        }

        public Comentarios BuscarPorID(string Id)
        {
            return Listar.Where(e => e.ID == Id).SingleOrDefault();
        }

        public bool Eliminar(string id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Comentarios entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
