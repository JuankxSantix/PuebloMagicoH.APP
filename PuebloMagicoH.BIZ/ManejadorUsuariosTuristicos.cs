using MongoDB.Bson;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClasesUsuarios;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorUsuariosTuristicos : IManejadorDeUsuariosTuristicos
    {
        IRepositorio<UsuarioTurista> repositorio;
        public ManejadorUsuariosTuristicos(IRepositorio<UsuarioTurista> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<UsuarioTurista> Listar => repositorio.Read;

        public bool AGREGAR(UsuarioTurista entidad)
        {
            return repositorio.Create(entidad);
        }

        public UsuarioTurista BuscarContrasenia(string Contrasenia)
        {
            return Listar.Where(e => e.Contrasenia == Contrasenia).SingleOrDefault();
        }

        public UsuarioTurista BuscarCorreo(string Correo)
        {
            return Listar.Where(e => e.Correo == Correo).SingleOrDefault();
        }

        public UsuarioTurista BuscarPorID(ObjectId Id)
        {
            return Listar.Where(e => e.id == Id).SingleOrDefault();
        }

        public bool Eliminar(ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(UsuarioTurista entidad)
        {
            return repositorio.Update(entidad);
        }
        
    }
}
