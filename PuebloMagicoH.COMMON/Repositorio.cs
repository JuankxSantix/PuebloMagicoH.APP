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
        private MongoClient client;
        private IMongoDatabase db;
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
            //client = new MongoClient(@"mongodb+srv://huichapanuser:ControlPuebloMagico@bdpueblomagicoh-xg6rg.gcp.mongodb.net/test?ssl=true");


            //client = new MongoClient(@"mongodb://Pueblo:magico19.mlab.com:40948/huichapan");
            //db = client.GetDatabase("huichapan");
            //
            //
            //string username = "huchauser";
            //string password = "admin1234";
            //string mongoDbAuthMechanism = "SCRAM-SHA-1";
            //MongoInternalIdentity internalIdentity =
            //          new MongoInternalIdentity("admin", username);
            //PasswordEvidence passwordEvidence = new PasswordEvidence(password);
            //MongoCredential mongoCredential =
            //     new MongoCredential(mongoDbAuthMechanism,
            //             internalIdentity, passwordEvidence);
            //List<MongoCredential> credentials =
            //           new List<MongoCredential>() { mongoCredential };
            //
            //
            //MongoClientSettings settings = new MongoClientSettings();
            //// comment this line below if your mongo doesn't run on secured mode
            //settings.Credentials = credentials;
            //String mongoHost = "127.0.0.1";
            //MongoServerAddress address = new MongoServerAddress(mongoHost);
            //settings.Server = address;
            //
            //MongoClient client = new MongoClient(settings);
            //
            //var mongoServer = client.GetDatabase("myDb");
            //var coll = mongoServer.GetCollection<Employee>("Employees");

            //// any stubbed out class
            //Employee emp = new Employee()
            //{
                //Id = Guid.NewGuid().ToString(),
                //Name = "Employee_" + DateTime.UtcNow.ToString("yyyy_MMMM_dd")
            //};

            //coll.InsertOne(emp);


            client = new MongoClient("mongodb://huchauser:admin1234@ds063449.mlab.com:63449/huichapandb:retryWrites=false");//
            db = client.GetDatabase("huichapandb");

        }
        private IMongoCollection<T> Collection() => db.GetCollection<T>(typeof(T).Name);
        public T Create(T entidad)
        {
            entidad.id = ObjectId.GenerateNewId();
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
            //entidad.FechaYHora = DateTime.Now;
            try
            {
                int r = (int)Collection().ReplaceOne(e => e.id == entidad.id, entidad).ModifiedCount;
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
                int r = (int)Collection().DeleteOne(e => e.id == entidad.id).DeletedCount;
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

        public T SearchbyID(ObjectId id)
        {
            return Collection().Find(e => e.id == id).SingleOrDefault();
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> predicado)
        {
            return Read.Where(predicado.Compile());
        }
    }
}
    