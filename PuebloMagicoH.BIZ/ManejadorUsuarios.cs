using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuebloMagicoH.BIZ
{
    public class ManejadorUsuarios : IManejadorDeUsuarios
    {
        IRepositorio<Usuarios> repositorio;
        public ManejadorUsuarios(IRepositorio<Usuarios> repositorio)
        {
            this.repositorio = repositorio;
        }
        public List<Usuarios> Listar => repositorio.Read;

        public bool AGREGAR(Usuarios entidad)
        {
            return repositorio.Create(entidad);
        }

        public Usuarios BuscarContrasenia(string Contrasenia)
        {
            return Listar.Where(e => e.Contrasenia == Contrasenia).SingleOrDefault();
        }

        public Usuarios BuscarCorreo(string Correo)
        {
            return Listar.Where(e => e.Correo == Correo).SingleOrDefault();
        }

        public Usuarios BuscarPorID(string Id)
        {
            return Listar.Where(e => e.ID == Id).SingleOrDefault();
        }

        public bool Eliminar(string id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Usuarios entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
