using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades.ClasesUsuarios
{
    public class UsuarioAdministrador:ClassIntermediaUsuarios
    {
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Puesto { get; set; }
        public byte[] Foto { get; set; }
    }
}
