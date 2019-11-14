using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using LiteDB;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.DAL
{
    public class RepositorioDeComentarios : IRepositorio<Comentarios>
    {
        private string DBName = "HPuebloMagico.db";
        private string TableName = "Comentarios";
        public List<Comentarios> Read
        {
            get
            {

                List<Comentarios> datos = new List<Comentarios>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<Comentarios>(TableName).FindAll().ToList();
                }
                return datos;
            }
        }

        public bool Create(Comentarios entidad)
        {
            entidad.ID = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<Comentarios>(TableName);
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

                    var colection = db.GetCollection<Comentarios>(TableName);
                    r = colection.Delete(e => e.ID == Id);
                }
                return r > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Comentarios entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<Comentarios>(TableName);
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
