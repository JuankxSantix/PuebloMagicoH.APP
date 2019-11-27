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

        private void ImgBtnHoteles_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageHoteles());
        }

        private void ImgBtnCompartitFotografia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageCompartirUnaFoto());
        }

        private void ImgBtnDondeComer_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDondeComer());
        }

        private void ImgBtnDireccionDeBalnearios_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDirectorioDeBalnearios());
        }

        private void ImgBtnTurismoReligioso_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageTurismoReligioso());
        }

        private void ImgBtnSeguridadPublica_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageSeguridadPublica());
        }

        private void ImgBtnServiciosDeEmergencia_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageServiciosDeEmergencia());
        }

        private void ImgBtnContactaConUnGuiaTuristico_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageContactarConUnGuiaTuristico());
        }

        private void ImgBtnAtractivosTuristicos_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageAtractivosTuristicos());
        }

        private void ImgBtnMonumentos_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMonumentos());
        }

        private void ImgBtnPromociones_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagePromociones());
        }

        private void ImgBtnAyudanosAMejorar_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageAyudanosAMejorar());
        }

        private void ImgBtnLeerCodigoQr_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageLeerCodigoQR());
        }

        private void ImgBtnGeolocalizador_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageGeolocalizador());
        }
    }
}