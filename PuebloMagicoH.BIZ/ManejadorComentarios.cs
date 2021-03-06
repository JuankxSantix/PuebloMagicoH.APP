﻿using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClaseC_O_F;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorComentarios : ImanejadorDeComentarios
    {
        IRepositorio<Comentarios> repositorio;
        public ManejadorComentarios(IRepositorio<Comentarios> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<Comentarios> Listar => repositorio.Read;

        public bool AGREGAR(Comentarios entidad)
        {
            return repositorio.Create(entidad);
        }

        public Comentarios BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.id == Id).SingleOrDefault();
        }

        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Comentarios entidad)
        {
            return repositorio.Update(entidad);
        }

    }
}
