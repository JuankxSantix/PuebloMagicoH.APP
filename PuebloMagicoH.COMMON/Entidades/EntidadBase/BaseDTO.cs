using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public abstract class BaseDTO
    {
        public ObjectId id { get; set; }
        
    }
}
