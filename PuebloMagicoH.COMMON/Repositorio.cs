using MongoDB.Bson;
using MongoDB.Driver;
using PuebloMagicoH.COMMON.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace PuebloMagicoH.COMMON
{
    public class Repositorio<T> where T : BaseDTO
    {
        MongoClient client;
        IMongoDatabase db;
        bool Resulatado;
        public string Error { get; private set; }
        public Repositorio()
        {
            //User1
            //ControlPuebloMagico
            //huichapanuser
            
            //User2
            //User=NewUser_H
            //Password=PuebloMagico
            
            client = new MongoClient(@"mongodb://Pueblo:magico19.mlab.com:40948/huichapan");

            //client = new MongoClient(@"mongodb+srv://huichapanuser:ControlPuebloMagico@bdpueblomagicoh-xg6rg.gcp.mongodb.net/test?ssl=true");
            db = client.GetDatabase("huichapan");

        }
        private IMongoCollection<T> Collection() => db.GetCollection<T>(typeof(T).Name);
        public T Create(T entidad)
        {
            entidad.ID = ObjectId.GenerateNewId().ToString();
         //   entidad.FechaYHora = DateTime.Now;
            try
            {
                Collection().InsertOne(entidad);
                Error = "";
                Resulatado = true;
            }
            catch (Exception ex)
            {

                Error = ex.Message;
                Resulatado = false;
            }

            return Resulatado ? entidad : null;
        }

        public IEnumerable<T> Read
        {

            get
            {
                try
                {
                    Error = "";
                    return Collection().AsQueryable();
                }
                catch (Exception ex)
                {

                    Error = ex.Message;
                    return null;
                }
            }
        }
        public T Update(T entidad)
        {
            entidad.FechaYHora = DateTime.Now;
            try
            {
                int r = (int)Collection().ReplaceOne(e => e.ID == entidad.ID, entidad).ModifiedCount;
                Error = r == 1 ? "Elemento modificado" : "No se modifico ningun elemento";
                Resulatado = r == 1;
            }
            catch (Exception ex)
            {

                Error = ex.Message;
                Resulatado = false;
            }
            return Resulatado ? entidad : null;
        }

        public bool Delete(T entidad)
        {
            try
            {
                int r = (int)Collection().DeleteOne(e => e.ID == entidad.ID).DeletedCount;
                Resulatado = r == 1;
                Error = Resulatado ? "Elemento eliminado" : "No se puede eliminar el elemento";
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                Resulatado = false;
            }
            return Resulatado;
        }

        public T SearchbyID(string id)
        {
            return Collection().Find(e => e.ID == id).SingleOrDefault();
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> predicado)
        {
            return Read.Where(predicado.Compile());
        }
    }
}
    