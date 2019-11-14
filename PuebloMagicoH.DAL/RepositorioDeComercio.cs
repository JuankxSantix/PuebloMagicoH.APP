using LiteDB;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.DAL
{

    public class RepositorioDeComercio : IRepositorio<Comercio>
    {
        private string DBName = "HPuebloMagico.db";
        private string TableName = "Comercio";
        public List<Comercio> Read
        {
            get
            {

                List<Comercio> datos = new List<Comercio>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<Comercio>(TableName).FindAll().ToList();
                }
                return datos;
            }
        }

        public bool Create(Comercio entidad)
        {
            entidad.ID = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<Comercio>(TableName);
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

                    var colection = db.GetCollection<Comercio>(TableName);
                    r = colection.Delete(e => e.ID == Id);
                }
                return r > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Comercio entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<Comercio>(TableName);
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
