using PuebloMagicoH.COMMON.Entidades.ClasesUsuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Interfaces
{
    public interface IManejadorDeUsuarioAdministrador:IManejadorGenerico<UsuarioAdministrador>
    {
        UsuarioTurista BuscarCorreo(string Correo);
        UsuarioTurista BuscarContrasenia(string Contrasenia);
    }
}
