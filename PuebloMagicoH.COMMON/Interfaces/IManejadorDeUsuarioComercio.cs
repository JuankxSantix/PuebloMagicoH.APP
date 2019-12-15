using PuebloMagicoH.COMMON.Entidades.ClasesUsuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Interfaces
{
    public interface IManejadorDeUsuarioComercio:IManejadorGenerico<UsuarioComercio>
    {
        UsuarioTurista BuscarCorreo(string Correo);
        UsuarioTurista BuscarContrasenia(string Contrasenia);
    }
}
