using Plugin.Media;
using Plugin.Media.Abstractions;
using PuebloMagicoH.Movil.GUI.Viws.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuebloMagicoH.Movil.GUI.Viws
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageCompartirUnaFoto : ContentPage
	{
        ObservableCollection<MediaModel> Photos = new ObservableCollection<MediaModel>();
		public PageCompartirUnaFoto ()
		{
			InitializeComponent ();
		}


        private async void BtnHacerUnaFoto_Clicked(object sender, EventArgs e)
        {
            var newPhotoId = Guid.NewGuid();

            var opciones_Almacenamiento = new StoreCameraMediaOptions()
            {
                SaveToAlbum = true,
                Name = newPhotoId.ToString()+".jpg",
                DefaultCamera = CameraDevice.Rear,
                Directory = "Huichapan Pueblo Magico",
                SaveMetaData = true,
                AllowCropping = true,

            };
            var foto = await CrossMedia.Current.TakePhotoAsync(opciones_Almacenamiento);
            MiImagen.Source = ImageSource.FromStream(() =>
            {
                var stream = foto.GetStream();
                foto.Dispose();
                return stream;
            });
        }

        private async void BtnSeleccionarUnaImagen_Clicked(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsTakePhotoSupported)
            {
                var imagen = await CrossMedia.Current.PickPhotoAsync();
                if (imagen != null)
                {
                    MiImagen.Source = ImageSource.FromStream(() =>
                    {
                        var stream = imagen.GetStream();
                        imagen.Dispose();
                        return stream;
                    });

                }
            }
        }
    }
}