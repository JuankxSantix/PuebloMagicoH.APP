using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares.SubClaseIntermediaLugares;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares.SubClaseIntermediaLugares.SubClaseUsuaiosValidadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuebloMagicoH.Movil.GUI.Viws.ViwsQueDeceasHacerHoy.ViwsGuiasDeTurismo.ViwsDirectorioDondeComer
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageDescripcionDirectorioDondeComer : ContentPage
	{
        List< RedSocial> redSocial;
		public PageDescripcionDirectorioDondeComer (Comercio comercio)
		{
			InitializeComponent ();
            redSocial = comercio.RedesSociales;
            CollectionDeRedesSociales.ItemsSource = redSocial;
            Title = "Restaurante: "+comercio.Nombre;
            lblDescripcion.Text = comercio.Descripcion;
            lblDireccion.Text = comercio.Direccion;
            lblNombreDeDirectorioDeComercio.Text = comercio.Nombre;
            //lblRedes.Text = redSocial.ToString(); ;
		}

        private void CollectionDeRedesSociales_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RedSocial redSocial = CollectionDeRedesSociales.SelectedItem as RedSocial;
            Browser.OpenAsync(redSocial.URL, new BrowserLaunchOptions
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred,
                TitleMode = BrowserTitleMode.Show,
                PreferredToolbarColor = Color.AliceBlue,
                PreferredControlColor = Color.Violet
            });
        }
    }
}