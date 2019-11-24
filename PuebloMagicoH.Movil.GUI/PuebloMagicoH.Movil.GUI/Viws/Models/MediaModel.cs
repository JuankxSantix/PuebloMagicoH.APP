using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PuebloMagicoH.Movil.GUI.Viws.Models
{
    public class MediaModel
    {
        public Guid MediaId { get; set; }
        public string Path { get; set; }
        public DateTime LocalDateTime { get; set; }
        private FileImageSource source = null;
        public FileImageSource Source => source ?? (source = new FileImageSource()
        {
            File = Path
        });
    }
}
