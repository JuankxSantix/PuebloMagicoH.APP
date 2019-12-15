using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorEventos : IManejadorDeEventos
    {
        IRepositorio<Eventos> repositorio;
        public ManejadorEventos(IRepositorio<Eventos> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<Eventos> Listar => repositorio.Read;

        public bool AGREGAR(Eventos entidad)
        {
            return repositorio.Create(entidad);
        }

        public Eventos BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.id == Id).SingleOrDefault();
        }
        
        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public List<Eventos> EvendoDelDia(DateTime Fecha)
        {
            return Listar.Where(e =>  Fecha>= e.FechaInicio  || Fecha <= e.FechaFin ).ToList();
        }

        public List<Eventos> EventosEntre(DateTime FechaInicio, DateTime FechaFin)
        {
            return Listar.Where(e => FechaInicio >= e.FechaInicio   && FechaFin <= e.FechaFin).ToList();
        }

        public bool Modificar(Eventos entidad)
        {
            return repositorio.Update(entidad);
        }
        
    }
}
