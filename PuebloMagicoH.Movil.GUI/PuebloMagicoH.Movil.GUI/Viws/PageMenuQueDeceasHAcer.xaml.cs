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
	public partial class PageMenuQueDeceasHAcer : ContentPage
	{
		public PageMenuQueDeceasHAcer ()
		{
			InitializeComponent ();
		}

        private void AcercaDe_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageAcercaDe());
        }

        private void ImgBtnEventosDeHoy_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageEventosDeHoy());
        }

        private void ImgBtnCalendaioDeEventos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageEventosEntreLasFechas());
        }

        private void ImgBtnDirectorioDeComerciantes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDirectorioComerciantes());
        }
    }
}