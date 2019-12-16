//using Android.Graphics;
using MongoDB.Bson;
using MongoDB.Driver.GridFS;
using Org.W3c.Dom;
using Plugin.Media;
using PuebloMagicoH.BIZ;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares.SubClaseIntermediaLugares;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares.SubClaseIntermediaLugares.SubClaseUsuaiosValidadores;
using PuebloMagicoH.COMMON.Entidades.EntidadBase;
using PuebloMagicoH.COMMON.Interfaces;
using PuebloMagicoH.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace PuebloMagicoH.Movil.GUI.Viws
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AgregarEventos : ContentPage
	{
        //IManejadorDeEventos manejadorDeEventos;
        IManejadorDeComercios manejadorDeComercios;
        //IManejadorDeMonumentos manejadorDeMonumentos;
        //IManejadorDeHoteles manejadorDeHoteles;
        //IManejadorDeBalnearios manejadorDeBalnearios;
        //IManejadorDeAtractivosTuristicos manejadorDeAtractivosTuristicos;
        IManejadorDeCategoriaEstablecimientos manejadorDeCategoriaEstablecimientos;


        //GridFSBucket contenerdor;
        List<RedSocial> redSocials;
        RedSocial RedSocial;
        Comercio comercio;
        //Monumentos monumento;
        //Hoteles hoteles;
        //Balnearios balnearios;
        //AtractivosTuristicos atractivosTuristicos;
        public AgregarEventos ()
		{
			InitializeComponent ();
            manejadorDeCategoriaEstablecimientos = new ManejadorCategoriaEstablecimientos(new RepositorioGenerico<CategoriaEstablecimiento>());
            Categoria.ItemsSource = manejadorDeCategoriaEstablecimientos.Listar;
            redSocials = new List<RedSocial>();
            //manejadorDeEventos = new ManejadorEventos(new RepositorioGenerico<Eventos>());
            manejadorDeComercios = new ManejadorComercios(new RepositorioGenerico<Comercio>());
            //manejadorDeMonumentos = new ManejadorMonumentos(new RepositorioGenerico<Monumentos>());
            //manejadorDeHoteles = new ManejadorDeHoteles(new RepositorioGenerico<Hoteles>());
            //manejadorDeBalnearios = new ManejadorDeBalnearios(new RepositorioGenerico<Balnearios>());
            //manejadorDeAtractivosTuristicos = new ManejadorAtractivosTuristicos(new RepositorioGenerico<AtractivosTuristicos>());
        }

        private void Agregar_Clicked(object sender, EventArgs e)
        {
            //eventos = new Eventos()
            //{
            //    Descripcion = txtdescriociono.Text,
            //    FechaInicio = DateInicio.Date,
            //    FechaFin = DateFin.Date,
            //    Horario = "",
            //    Direccion = txtDireccion.Text,
            //    Nombre = txtnombre.Text,
            //    Costo = float.Parse(txtCosto.Text),

            //};


            comercio = new Comercio()
            {
                CategoriaEstablecimiento = Categoria.SelectedItem.ToString(),
                Descripcion = txtdescriociono.Text,
                Nombre = txtnombre.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                 HorarioDeAtencion=txtHorarioDeAtencion.Text,
                  RedesSociales= redSocials
                  
            };

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

            //atractivosTuristicos = new AtractivosTuristicos()
            //{
            //    Descripcion = txtdescriociono.Text,
            //    Direccion = txtDireccion.Text,
            //    NombreAtractivo = txtnombre.Text
            //};
            //CategoriaEstablecimiento categoriaEstablecimiento = new CategoriaEstablecimiento()
            //{
            //    Nombre = txtnombre.Text
            //};

            if (manejadorDeComercios.AGREGAR(comercio))
                DisplayAlert("Correcto", "SeAgrego correctamente", "ok");
            else
                DisplayAlert("Correcto", "No se agrego", "ok");

        }

        private void BtnSeleccionarUnaImagen_Clicked(object sender, EventArgs e)
        {
        }

        private void AgregarRed_Clicked(object sender, EventArgs e)
        {
            RedSocial = new RedSocial()
            {
                NombreDeUsuario = txtnombre.Text,
                NombreRedSocial = txtDireccion.Text,
                URL = txtdescriociono.Text
            };
            redSocials.Add(RedSocial);
        }


        ////public byte[] ImageToByte(ImageSource image)
        ////{

        ////    //Image image = new Image();
        ////    //Bitmap bitmap = Bitmap.CreateBitmap(200, 100, Bitmap.Config.Argb8888);
        ////    //Canvas canvas = new Canvas(bitmap);

        ////    //var paint = new Paint();
        ////    //paint.Color = Android.Graphics.Color.Red;
        ////    //paint.SetStyle(Paint.Style.Fill);

        ////    //Rect rect = new Rect(0, 0, 200, 100);
        ////    //canvas.DrawRect(rect, paint);
        ////    BitConverter.
        ////    Bitmap bitmap = new Bitmap(1000, 1000);

        ////    if (image != null)
        ////    {
        ////        MemoryStream memoryStream = new MemoryStream();

        ////        image.
        ////        JpegBitmapEncoder encoder = new JpegBitmapEncoder();
        ////        encoder.Frames.Add(BitmapFrame.Create(image as BitmapSource));

        ////        encoder.Save(memoryStream);
        ////        return memoryStream.ToArray();
        ////    }
        ////    else
        ////    {
        ////        return null;
        ////    }
        ////}
        //private async void SoSe()
        //{


        //    if (CrossMedia.Current.IsTakePhotoSupported)
        //    {
        //        var imagen = await CrossMedia.Current.PickPhotoAsync();
        //        if (imagen != null)
        //        {
        //            MiImagen.Source = ImageSource.FromStream(() =>
        //            {
        //                var stream = imagen.GetStream();
        //                imagen.Dispose();
        //                return stream;
        //            });

        //        }
        //        //foto = ImageToByte(MiImagen.Source);
        //        var arreglo=File.ReadAllBytes(MiImagen.Source.ToString());
        //        foto = arreglo;
        //    //string x=System.Text.Encoding.UTF8.GetString(arreglo);
        //        ID=manejadorDeEventos.Upload("EventoX", arreglo);
        //    }
        //}
    }
}