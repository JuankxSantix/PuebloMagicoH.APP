using MongoDB.Bson;
using MongoDB.Driver;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.DAL
{
    public class RepositorioGenerico<T> : IRepositorio<T> where T:BaseDTO
    {
        private MongoClient client;
        private IMongoDatabase db;
        public RepositorioGenerico()
        {

            //Base de datos creada//

            //huichapan
            //juankx1
            //client = new MongoClient(new MongoUrl("mongodb://huchauser:admin1234@ds063449.mlab.com:63449/huichapandb:retryWrites=false"));
            //db = client.GetDatabase("huichapandb");


            //Base de datos prueba (utilizada de un proyecto anterior)//
            client = new MongoClient(new MongoUrl("mongodb://JuanCarlosO:17021020@ds133360.mlab.com:33360/lapapeleriadamore"));
            db = client.GetDatabase("lapapeleriadamore");
        }
        private IMongoCollection<T> Collection()
        {
            return db.GetCollection<T>(typeof(T).Name);
        }
        public List<T> Read => Collection().AsQueryable().ToList();

        public bool Create(T entidad)
        {
            string resul="";
            try
            {
                Collection().InsertOne(entidad);
                resul = "";
                return true;
            }
            catch (Exception ex)
            {
                resul = ex.Message;
                return false;
            }
        }

        public bool Delete(ObjectId Id)
        {
            try
            {
                return Collection().DeleteOne(e=>e.ID== Id).DeletedCount==1;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(T entidadModificada)
        {
            try
            {
                return Collection().ReplaceOne(e => e.ID == entidadModificada.ID,entidadModificada).ModifiedCount== 1;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
