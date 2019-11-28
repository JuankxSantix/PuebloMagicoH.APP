using Plugin.Media;
using PuebloMagicoH.BIZ;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using PuebloMagicoH.DAL;
using System;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuebloMagicoH.Movil.GUI.Viws
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AgregarEventos : ContentPage
	{
        IManejadorDeEventos manejadorDeEventos;
        Eventos eventos;
        public AgregarEventos ()
		{
			InitializeComponent ();
            manejadorDeEventos = new ManejadorEventos(new RepositorioGenerico<Eventos>());
        }

        private void Agregar_Clicked(object sender, EventArgs e)
        {
            eventos = new Eventos()
            {
                Costo = float.Parse(txtCosto.Text),
                Descripcion = txtdescriocionEvento.Text,
                FechaInicio = DateInicio.Date,
                FechaFinal = DateFin.Date,
                FechaYHora = null,
                LugarEvento = txtLugarEvento.Text,
                NombreEvento = txtNombreEvento.Text,
                Notas = txtNotasEvento.Text,

            };

            if (manejadorDeEventos.AGREGAR(eventos))
                DisplayAlert("Correcto", "SeAgrego correctamente", "ok");
            else
                DisplayAlert("Correcto", "No se agrego", "ok");

        }
        //public byte[] ImageToByte(ImageSource image)
        //{
        //    if (image != null)
        //    {
        //        MemoryStream memoryStream = new MemoryStream();
        //        var encoder = new JpegBitmapEncoder();
        //        encoder.Frames.Add(BitmapFrame.Create(image as BitmapSource));
        //        encoder.Save(memoryStream);
        //        return memoryStream.ToArray();
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
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