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

        public Fotos BuscarPorID(string Id)
        {
            return Listar.Where(e => e.ID == Id).SingleOrDefault();
        }

        public bool Eliminar(string id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Fotos entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
