using LiteDB;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.DAL
{
    public class RepositotioDeEventoCategoria : IRepositorio<EventoCategoria>
    {
        private string DBName = "HPuebloMagico.db";
        private string TableName = "EventoCategoria";
        public List<EventoCategoria> Read {
            get
            {

                List<EventoCategoria> datos = new List<EventoCategoria>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<EventoCategoria>(TableName).FindAll().ToList();
                }
                return datos;
            }
        }

        public bool Create(EventoCategoria entidad)
        {
            entidad.ID = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<EventoCategoria>(TableName);
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

                    var colection = db.GetCollection<EventoCategoria>(TableName);
                    r = colection.Delete(e => e.ID == Id);
                }
                return r > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(EventoCategoria entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<EventoCategoria>(TableName);
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
