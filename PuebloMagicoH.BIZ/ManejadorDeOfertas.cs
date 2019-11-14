﻿using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorDeOfertas : IManejadorDeOfertas
    {
        IRepositorio<Ofertas> repositorio;
        public ManejadorDeOfertas(IRepositorio<Ofertas> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<Ofertas> Listar => repositorio.Read;

        public bool AGREGAR(Ofertas entidad)
        {
            return repositorio.Create(entidad);
        }

        public Ofertas BuscarPorID(string Id)
        {
            return Listar.Where(e => e.ID == Id).SingleOrDefault();
        }

        public bool Eliminar(string id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Ofertas entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}