using PuebloMagicoH.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Interfaces
{
    public interface IManejadorDeUsuarios:IManejadorGenerico<Usuarios>
    {
        Usuarios BuscarCorreo(string Correo);
        Usuarios BuscarContrasenia(string Contrasenia);
    }
}
