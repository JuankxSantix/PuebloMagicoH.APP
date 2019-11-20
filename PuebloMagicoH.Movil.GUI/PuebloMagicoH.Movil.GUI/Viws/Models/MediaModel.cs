using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PuebloMagicoH.Movil.GUI.Viws.Models
{
    public class MediaModel
    {
        public Guid MediaId { get; set; }
        public string path { get; set; }
        public DateTime LocalDateTime { get; set; }
        private FileImageSource sourcer = null;
        public FileImageSource Source => sourcer ?? (sourcer = new FileImageSource()
        {
            File = path
        });
    }
}
