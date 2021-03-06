﻿using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Interfaces
{
    public interface IManejadorGenerico<T> where T:BaseDTO
    {
        bool AGREGAR(T entidad);
        List<T> Listar { get; }
        bool Eliminar(ObjectId id);
        bool Modificar(T entidad);
        T BuscarPorID(ObjectId Id);
        
    }
}
