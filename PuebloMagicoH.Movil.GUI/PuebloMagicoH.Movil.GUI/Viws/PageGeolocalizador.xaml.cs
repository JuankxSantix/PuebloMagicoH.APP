using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using Position = Xamarin.Forms.Maps.Position;

namespace PuebloMagicoH.Movil.GUI.Viws
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageGeolocalizador : ContentPage
	{
		public PageGeolocalizador ()
		{
			InitializeComponent ();
            InitializePlugin(); 
		}

        private async void InitializePlugin()
        {


            var map = new Map(MapSpan.FromCenterAndRadius(new Position(36.8961, 10.1865), Distance.FromMiles(0.5))){
                IsShowingUser = true,
                VerticalOptions=LayoutOptions.FillAndExpand
            
            };

            var position1 = new Position(36.893, 10.183);

            var pin = new Pin
            {
                Type=PinType.Place,
                Position=position1,
                Label="Demo1",
                Address="www.intilaq.com"
            };
            if (!CrossGeolocator.IsSupported)
            {
                await DisplayAlert("Error", "Ha ocurrido un error", "ok");
                return;
            }

            if (!CrossGeolocator.Current.IsGeolocationEnabled || !CrossGeolocator.Current.IsGeolocationAvailable)
            {
                await DisplayAlert("Advertencia", "Revise la configuracion", "ok");
                return;
            }



            CrossGeolocator.Current.PositionChanged += Current_PositionChanged;

            await CrossGeolocator.Current.StartListeningAsync( new TimeSpan(0,0,1),0.30);


        }

        private void Current_PositionChanged(object sender, PositionEventArgs e)
        {
            if (!CrossGeolocator.Current.IsListening)
            {
                return;
            }
            var posision = CrossGeolocator.Current.GetPositionAsync();
            lblLatitud.Text = posision.Result.Latitude.ToString();
            lblLongitut.Text = posision.Result.Longitude.ToString();
            lblAltura.Text = posision.Result.Altitude.ToString();
        }
    }
}