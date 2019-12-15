using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades.ClasesUsuarios
{
    public abstract class ClassIntermediaUsuarios: BaseDTO
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
    }
}
