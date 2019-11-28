//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using Xamarin.Forms.Xaml;
using Position = Xamarin.Forms.Maps.Position;
using PuebloMagicoH.Movil.GUI.Viws.Models;
using Newtonsoft.Json;

namespace PuebloMagicoH.Movil.GUI.Viws
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageGeolocalizador : ContentPage
	{
		public PageGeolocalizador ()
		{
			InitializeComponent ();

            InitializePlugin(); 

            Task.Delay(2000);
            UpdateMap();
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
            //lblLatitud.Text = posision.Result.Latitude.ToString();
            //lblLongitut.Text = posision.Result.Longitude.ToString();
            //lblAltura.Text = posision.Result.Altitude.ToString();
        }
         


        List<Place> placesList = new List<Place>();

        private void UpdateMap()
        {
            try
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(PageGeolocalizador)).Assembly;
                Stream stream = assembly.GetManifestResourceStream("PuebloMagicoH.Movil.GUI.Places.json");
                string text = string.Empty;
                using (var reader = new StreamReader(stream))
                {
                    text = reader.ReadToEnd();
                }

                var resultObject = JsonConvert.DeserializeObject<Places>(text);

                foreach (var place in resultObject.results)
                {
                    placesList.Add(new Place
                    {
                        PlaceName = place.name,
                        Address = place.vicinity,
                        Location = place.geometry.location,
                        Position = new Position(place.geometry.location.lat, place.geometry.location.lng),
                        //Icon = place.icon,
                        //Distance = $"{GetDistance(lat1, lon1, place.geometry.location.lat, place.geometry.location.lng, DistanceUnit.Kiliometers).ToString("N2")}km",
                        //OpenNow = GetOpenHours(place?.opening_hours?.open_now)
                    });
                }

                MyMapp.ItemsSource = placesList;
                //PlacesListView.ItemsSource = placesList;
                //var loc = await Xamarin.Essentials.Geolocation.GetLocationAsync();

                var posision = CrossGeolocator.Current.GetPositionAsync();
                MyMapp.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(posision.Result.Latitude, posision.Result.Longitude), Distance.FromMeters(0.30)));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }


        }
    }
}