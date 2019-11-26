using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        }
    }
}