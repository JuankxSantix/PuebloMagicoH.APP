using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace PuebloMagicoH.Movil.GUI.Viws
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageLeerCodigoQR : ContentPage
	{
		public PageLeerCodigoQR ()
		{
			InitializeComponent ();
		}

        private void BtnEscanearQr_Clicked(object sender, EventArgs e)
        {
            Scanner();
        }

        private async void Scanner()
        {
            var scannerPage = new ZXingScannerPage();

            scannerPage.Title = "Lector de QR";
            scannerPage.OnScanResult += (result) =>
            {
                scannerPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopAsync();
                    Browser.OpenAsync(result.Text, new BrowserLaunchOptions
                    {
                        LaunchMode = BrowserLaunchMode.SystemPreferred,
                        TitleMode = BrowserTitleMode.Show,
                        PreferredToolbarColor = Color.AliceBlue,
                        PreferredControlColor = Color.Violet
                    });

                });

                
            };

            await Navigation.PushAsync(scannerPage);


        }
    }
}