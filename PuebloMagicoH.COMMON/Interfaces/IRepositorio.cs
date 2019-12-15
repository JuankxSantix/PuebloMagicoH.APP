using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Interfaces
{
    public interface IRepositorio<T> where T:BaseDTO
    {
        bool Create(T entidad);
        List<T> Read { get; }
        bool Update(T entidadModificada);
        bool Delete(ObjectId Id);
        
    }
}
