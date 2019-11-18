using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class Usuarios:BaseDTO
    {
        public string NombreDeUsuario { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Genero { get; set; }
        public string Ocupacion { get; set; }
        //public bool SoyDeHuichapan { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string MotivoDeVisita { get; set; }
        public string EnteradoPor { get; set; }
        //public string InformacionARecivir { get; set; }
        //public string TipoDeUsuario { get; set; }
    }
}
