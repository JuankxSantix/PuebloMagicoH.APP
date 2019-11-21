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
            client = new MongoClient(new MongoUrl(@"mongodb://huichapan:juankx1@ds063449.mlab.com:63449/huichapandb?retryWrites=false&AuthMechanism=SCRAM-SHA-1"));
            db = client.GetDatabase("huichapandb");


           // Base de datos prueba (utilizada de un proyecto anterior)//
            //lient = new MongoClient(new MongoUrl("mongodb://JuanCarlosO:17021020@ds133360.mlab.com:33360/lapapeleriadamore:retryWrites=false"));
            //db = client.GetDatabase("lapapeleriadamore");



            //string user;     // the user name
            //string database; // the name of the database in which the user is defined
            ////char[] password; // the password as a character array
            //string password;
            //user = "JuanCarlosO";
            //database = "lapapeleriadamore";
            //password = "17021020";
            //// ...
            //MongoCredential credential4 = MongoCredential.CreateMongoCRCredential(databaseName: database, username: user, password: password);
            //MongoCredential credential1 = MongoCredential.CreateGssapiCredential(user, password);
            //MongoCredential credential2 = MongoCredential.CreatePlainCredential(database, user, password);
            //MongoCredential credential3 = MongoCredential.CreateMongoX509Credential(user);
            //MongoCredential credential = MongoCredential.CreateCredential(user, database, password);

            //MongoUrl uri = new MongoUrl("mongodb://JuanCarlosO:17021020@ds133360.mlab.com:33360/lapapeleriadamore?authSource=db1");
            //MongoClient mongoClient = new MongoClient(uri);
            //db = mongoClient.GetDatabase("lapapeleriadamore");
        }
        private IMongoCollection<T> Collection()
        {
            return db.GetCollection<T>(typeof(T).Name);
        }
        public List<T> Read => Collection().AsQueryable().ToList();

        public bool Create(T entidad)
        {
            string resul="";

            entidad.id = new ObjectId();
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
                return Collection().DeleteOne(e=>e.id== Id).DeletedCount==1;
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
                return Collection().ReplaceOne(e => e.id == entidadModificada.id,entidadModificada).ModifiedCount== 1;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
