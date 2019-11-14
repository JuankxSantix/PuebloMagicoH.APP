using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using LiteDB;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.DAL
{
    public class RepositorioDeCategoriaEventos : IRepositorio<CategoriaEventos>
    {
        private string DBName = "HPuebloMagico.db";
        private string TableName = "CategoriaEventos";
        public List<CategoriaEventos> Read
        {
            get
            {

                List<CategoriaEventos> datos = new List<CategoriaEventos>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<CategoriaEventos>(TableName).FindAll().ToList();
                }
                return datos;
            }
        }

        public bool Create(CategoriaEventos entidad)
        {
            entidad.ID = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<CategoriaEventos>(TableName);
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

                    var colection = db.GetCollection<CategoriaEventos>(TableName);
                    r = colection.Delete(e => e.ID == Id);
                }
                return r > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(CategoriaEventos entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<CategoriaEventos>(TableName);
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
