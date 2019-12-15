using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClasesUsuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Interfaces
{
    public interface IManejadorDeUsuariosTuristicos:IManejadorGenerico<UsuarioTurista>
    {
        UsuarioTurista BuscarCorreo(string Correo);
        UsuarioTurista BuscarContrasenia(string Contrasenia);
    }
}
