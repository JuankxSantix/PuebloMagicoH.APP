using LiteDB;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.DAL
{
    public class RepositorioDeCategoriaEstablecimientos : IRepositorio<CategoriaEstablecimientos>
    {
        private string DBName = "HPuebloMagico.db";
        private string TableName = "CategoriaEstablecimientos";
        public List<CategoriaEstablecimientos> Read
        {
            get
            {

                List<CategoriaEstablecimientos> datos = new List<CategoriaEstablecimientos>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<CategoriaEstablecimientos>(TableName).FindAll().ToList();
                }
                return datos;
            }

        }

        public bool Create(CategoriaEstablecimientos entidad)
        {
            entidad.ID = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<CategoriaEstablecimientos>(TableName);
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

                    var colection = db.GetCollection<CategoriaEstablecimientos>(TableName);
                    r = colection.Delete(e => e.ID == Id);
                }
                return r > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(CategoriaEstablecimientos entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<CategoriaEstablecimientos>(TableName);
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
