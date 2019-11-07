using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public abstract class Usuarios
    {
        public int NombreDeUsuario { get; set; }
        public int IDUsuaurio { get; set; }
        public int Correo { get; set; }
        public int Contrasenia { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Genero { get; set; }
        public int Ocupacion { get; set; }
        public bool SoyDeHuichapan { get; set; }
        public int Estado { get; set; }
        public int Ciudad { get; set; }
        public int MotivoDeVisita { get; set; }
        public int EnteradoPor { get; set; }
        public int InformacionARecivir { get; set; }
        public DateTime FechaYHora { get; set; }
        public int Notas { get; set; }
        public int TipoDeUsuario { get; set; }
    }
}
