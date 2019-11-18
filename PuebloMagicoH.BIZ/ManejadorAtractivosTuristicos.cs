using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorAtractivosTuristicos : IManejadorDeAtractivosTuristicos
    {
        IRepositorio<AtractivosTuristicos> repositorio1;
        public ManejadorAtractivosTuristicos(IRepositorio<AtractivosTuristicos> repositorio)
        {
            this.repositorio1 = repositorio;
        }
        public List<AtractivosTuristicos> Listar => repositorio1.Read;

        public bool AGREGAR(AtractivosTuristicos entidad)
        {
            return repositorio1.Create(entidad);
        }

        public AtractivosTuristicos BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.ID == Id).SingleOrDefault();
        }

        public bool Eliminar(ObjectId id)
        {
            return repositorio1.Delete(id);
        }

        public bool Modificar(AtractivosTuristicos entidad)
        {
            return repositorio1.Update(entidad);
        }
    }
}
