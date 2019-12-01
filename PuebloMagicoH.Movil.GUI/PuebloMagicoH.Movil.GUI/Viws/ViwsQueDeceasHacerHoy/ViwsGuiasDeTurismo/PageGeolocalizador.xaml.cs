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
using Xamarin.Essentials;
using Xamarin.Forms.Maps;

//using Plugin.Geolocator;
//using Plugin.Geolocator.Abstractions;
using Xamarin.Forms.Xaml;
using Position = Xamarin.Forms.Maps.Position;
using PuebloMagicoH.Movil.GUI.Viws.Models;
using Newtonsoft.Json;
using Map = Xamarin.Essentials.Map;

namespace PuebloMagicoH.Movil.GUI.Viws
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageGeolocalizador : ContentPage
	{
		public PageGeolocalizador ()
		{
			InitializeComponent ();
            juan();
        }

        public async void juan()
        {
            var request = new GeolocationRequest(GeolocationAccuracy.Medium);
            var location = await Geolocation.GetLocationAsync(request);

            if (location != null)
            {

                string Id = new Guid().ToString();

                await Map.OpenAsync(location, new MapLaunchOptions
                {
                    NavigationMode = NavigationMode.None
                });
                await Navigation.PushAsync(new PageMenuQueDeceasHAcer());
            }

            
        }

        
    }
}