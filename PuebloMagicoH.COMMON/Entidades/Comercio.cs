﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades
{
    public class Comercio
    {
        public int IDComercio { get; set; }
        public string NombreComercio { get; set; }
        public string Direccion { get; set; }
        public string Telefonos { get; set; }
        public float Latitud { get; set; }
        public float Longitut { get; set; }
        public DateTime HorariosAtencion { get; set; }
        public string URL { get; set; }
        public string Correo { get; set; }
        public string IDGoogle { get; set; }
        public DateTime FechaYHora { get; set; }
        public string Notas { get; set; }
        public int IDPropietario { get; set; } //Revisar esta propiedad
        public int IDCategoriaEstablecimiento { get; set; }
        public int IDUsuarioModificador { get; set; }
        public int IDUsuarioValidador { get; set; }
    }
}
