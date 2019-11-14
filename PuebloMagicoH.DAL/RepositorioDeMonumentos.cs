using LiteDB;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.DAL
{
    public class RepositorioDeMonumentos : IRepositorio<Monumentos>
    {
        private string DBName = "HPuebloMagico.db";
        private string TableName = "Monumentos";
        public List<Monumentos> Read
        {
            get
            {

                List<Monumentos> datos = new List<Monumentos>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<Monumentos>(TableName).FindAll().ToList();
                }
                return datos;
            }
        }

        public bool Create(Monumentos entidad)
        {
            entidad.ID = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<Monumentos>(TableName);
                    colection.Insert(entidad);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(string Id)
        {
            try
            {
                int r;
                using (var db = new LiteDatabase(DBName))
                {

                    var colection = db.GetCollection<Monumentos>(TableName);
                    r = colection.Delete(e => e.ID == Id);
                }
                return r > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Monumentos entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<Monumentos>(TableName);
                    colection.Update(entidadModificada);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
