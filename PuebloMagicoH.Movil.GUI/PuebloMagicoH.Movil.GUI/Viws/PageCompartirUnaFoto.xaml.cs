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

        //private async void BtnTomarFoto_Clicked(object sender, EventArgs e)
        //{
        //    await CrossMedia.Current.Initialize();

        //    if(!CrossMedia.Current.IsTakePhotoSupported && !CrossMedia.Current.IsPickPhotoSupported)
        //    {
        //        await DisplayAlert("Message", "Photo capture and pick not supported", "ok");
        //        return;
        //    }
        //    else
        //    {
        //        var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
        //        {
        //            Directory="Demo Camara",
        //            Name=DateTime.Now+"_test.jpg"
        //        });
        //        if(file == null)
        //        {
        //            return;
        //        }

        //        await DisplayAlert("File path", file.Path, "ok");

        //        MyImage.Source = ImageSource.FromStream(() =>
        //          {
        ////              var stream = file.GetStream();
        ////              return stream;
        ////          });
        ////    }
        ////}

        //private async void BtnTomarFoto_Pressed(object sender, EventArgs e)
        //{
        //    var IsInitiliaze = await CrossMedia.Current.Initialize();

        //    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.IsSupported || !IsInitiliaze)
        //    {
        //        await DisplayAlert("Error", "La camara no se encuentra disponible", "ok");
        //        return;
        //    }

        //    var newPhotoId = Guid.NewGuid();

        //    using (var potho = await CrossMedia.Current.TakePhotoAsync(new StoreVideoOptions()
        //    {
        //        Name = newPhotoId.ToString(),
        //        SaveToAlbum = true,
        //        DefaultCamera = CameraDevice.Rear,
        //        Directory = "Demo",
        //        CustomPhotoSize=50
        //    }))
        //    {
        //        if (string.IsNullOrWhiteSpace(potho?.Path))
        //        {
        //            return;
        //        }

        //        var newPhotoMedia = new MediaModel()
        //        {
        //            MediaId = newPhotoId,
        //            Path = potho.Path,
        //            LocalDateTime = DateTime.Now
        //        };

        //        Photos.Add(newPhotoMedia);


        //        potho.Dispose();


        //    }
            
        //    ListPhotos.ItemsSource = Photos;

        //}


        private async void BtnHacerUnaFoto_Clicked(object sender, EventArgs e)
        {
            var opciones_Almacenamiento = new StoreCameraMediaOptions()
            {
                SaveToAlbum = true,
                Name = "MiFoto.jpg"

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