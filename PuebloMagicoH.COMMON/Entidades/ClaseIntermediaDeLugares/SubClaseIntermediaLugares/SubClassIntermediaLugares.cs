using System;
using System.Collections.Generic;
using System.Text;

namespace PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares.SubClaseIntermediaLugares
{
    public abstract class SubClassIntermediaLugares:ClassIntermediaLugares
    {
        public string HorarioDeAtencion { get; set; }
        public List<RedSocial> RedesSociales { get; set; }
        //public List<string> RedesSociales { get; set; }
        public string Telefono { get; set; }


    }
    public class RedSocial
    {
        public string NombreRedSocial { get; set; }
        public string NombreDeUsuario { get; set; }
        public string URL { get; set; }
    }
}
