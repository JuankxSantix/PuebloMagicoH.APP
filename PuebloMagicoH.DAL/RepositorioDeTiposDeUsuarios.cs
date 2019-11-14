using LiteDB;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.DAL
{
    public class RepositorioDeTiposDeUsuarios : IRepositorio<TipoDeUsuario>
    {
        private string DBName = "HPuebloMagico.db";
        private string TableName = "TipoDeUsuario";
        public List<TipoDeUsuario> Read
        {
            get
            {

                List<TipoDeUsuario> datos = new List<TipoDeUsuario>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<TipoDeUsuario>(TableName).FindAll().ToList();
                }
                return datos;
            }
        }

        public bool Create(TipoDeUsuario entidad)
        {
            entidad.ID = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<TipoDeUsuario>(TableName);
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

                    var colection = db.GetCollection<TipoDeUsuario>(TableName);
                    r = colection.Delete(e => e.ID == Id);
                }
                return r > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(TipoDeUsuario entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<TipoDeUsuario>(TableName);
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
