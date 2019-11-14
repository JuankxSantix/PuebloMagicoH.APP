using LiteDB;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.DAL
{
    public class RepositorioDeUsuarios : IRepositorio<Usuarios>
    {
        private string DBName = "HPuebloMagico.db";
        private string TableName = "Usuarios";
        public List<Usuarios> Read {
            get {

                List<Usuarios> datos = new List<Usuarios>();
                using (var db=new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<Usuarios>(TableName).FindAll().ToList();
                }
                return datos;
            }
            
        }

        public bool Create(Usuarios entidad)
        {
            entidad.ID = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<Usuarios>(TableName);
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
                int Yr;
                using (var db = new LiteDatabase(DBName))
                {
                    
                    var colection = db.GetCollection<Usuarios>(TableName);
                    colection.Delete(e => e.ID == Id);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Usuarios entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<Usuarios>(TableName);
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
