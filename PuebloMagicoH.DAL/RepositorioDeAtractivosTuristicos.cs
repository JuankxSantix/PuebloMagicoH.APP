using LiteDB;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.DAL
{
    public class RepositorioDeAtractivosTuristicos : IRepositorio<AtractivosTuristicos>
    {
        private string DBName = "HPuebloMagico.db";
        private string TableName = "AtractivosTuristicos";
        public List<AtractivosTuristicos> Read {
            get
            {

                List<AtractivosTuristicos> datos = new List<AtractivosTuristicos>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<AtractivosTuristicos>(TableName).FindAll().ToList();
                }
                return datos;
            }

        }

        public bool Create(AtractivosTuristicos entidad)
        {
            entidad.ID = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<AtractivosTuristicos>(TableName);
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

                    var colection = db.GetCollection<AtractivosTuristicos>(TableName);
                    r = colection.Delete(e => e.ID == Id);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(AtractivosTuristicos entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<AtractivosTuristicos>(TableName);
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
