using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades.ClasesUsuarios
{
    public class UsuarioTurista:ClassIntermediaUsuarios
    {
        public DateTime FechaDeNacimiento { get; set; }
        public string Genero { get; set; }
        public string Ocupacion { get; set; }
        public bool SoyDeHuichapan { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string MotivoDeVisita { get; set; }
        public string EnteradoPor { get; set; }
        public List<string> InformacionARecivir { get; set; }
    }
}
