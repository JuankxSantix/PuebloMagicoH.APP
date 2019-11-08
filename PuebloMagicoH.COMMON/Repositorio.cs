using MongoDB.Driver;
using PuebloMagicoH.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON
{
    public class Repositorio<T>where T:Usuarios
    {
        MongoClient client;
        IMongoDatabase db;
        public Repositorio()
        {

        }
    }
}
    