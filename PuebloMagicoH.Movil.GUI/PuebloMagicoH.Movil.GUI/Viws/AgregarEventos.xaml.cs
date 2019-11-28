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
        //IManejadorDeEventos manejadorDeEventos;
        //IManejadorDeComercios manejadorDeComercios;
        //IManejadorDeMonumentos manejadorDeMonumentos;
        //IManejadorDeHoteles manejadorDeHoteles;
        IManejadorDeBalnearios manejadorDeBalnearios;
        IManejadorDeAtractivosTuristicos manejadorDeAtractivosTuristicos;




        //Eventos eventos;
        //Comercio comercio;
        //Monumentos monumento;
        //Hoteles hoteles;
        //Balnearios balnearios;
        AtractivosTuristicos atractivosTuristicos;
        public AgregarEventos ()
		{
			InitializeComponent ();
            //manejadorDeEventos = new ManejadorEventos(new RepositorioGenerico<Eventos>());
            //manejadorDeComercios = new ManejadorComercios(new RepositorioGenerico<Comercio>());
            //manejadorDeMonumentos = new ManejadorMonumentos(new RepositorioGenerico<Monumentos>());
            //manejadorDeHoteles = new ManejadorDeHoteles(new RepositorioGenerico<Hoteles>());
            //manejadorDeBalnearios = new ManejadorDeBalnearios(new RepositorioGenerico<Balnearios>());
            manejadorDeAtractivosTuristicos = new ManejadorAtractivosTuristicos(new RepositorioGenerico<AtractivosTuristicos>());
        }

        private void Agregar_Clicked(object sender, EventArgs e)
        {
            //eventos = new Eventos()
            //{
            //    Costo = float.Parse(txtCosto.Text),
            //    Descripcion = txtdescriocionEvento.Text,
            //    FechaInicio = DateInicio.Date,
            //    FechaFinal = DateFin.Date,
            //    FechaYHora = null,
            //    LugarEvento = txtLugarEvento.Text,
            //    NombreEvento = txtNombreEvento.Text,
            //    Notas = txtNotasEvento.Text,

            //};

            //comercio = new Comercio()
            //{
            //    CategoriaEstablecimiento = txtCategoria.Text,
            //    Descripcion = txtdescriocion.Text,
            //    NombreComercio = txtnombre.Text,
            //    Telefonos = txttelefono.Text,
            //    Direccion = txtDireccion.Text
            //};

            //monumento = new Monumentos()
            //{
            //    Descripcion = txtdescriociono.Text,
            //    Direccion = txtDireccion.Text,
            //    NombreMonumentos = txtnombre.Text
            //};
            //hoteles = new Hoteles()
            //{
            //    Descripcion = txtdescriociono.Text,
            //    Direccion = txtDireccion.Text,
            //    HabitacionesDisponibles = int.Parse(txtHabitaciones.Text),
            //    NombreHotel = txtnombre.Text
            //};

            //balnearios = new Balnearios()
            //{
            //    Descripcion = txtdescriociono.Text,
            //    Direccion = txtDireccion.Text,
            //    Nombre = txtnombre.Text
            //};

            atractivosTuristicos = new AtractivosTuristicos()
            {
                Descripcion = txtdescriociono.Text,
                Direccion = txtDireccion.Text,
                NombreAtractivo = txtnombre.Text
            };

            if (manejadorDeAtractivosTuristicos.AGREGAR(atractivosTuristicos))
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