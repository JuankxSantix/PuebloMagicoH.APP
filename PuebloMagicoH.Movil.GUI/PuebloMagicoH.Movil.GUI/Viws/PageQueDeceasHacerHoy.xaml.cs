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
	public partial class PageQueDeceasHacerHoy : ContentPage
	{
		public PageQueDeceasHacerHoy ()
		{
			InitializeComponent ();
            ElementosAInicializar();
        }

        public void ElementosAInicializar()
        {
            lblExploracionLibre.Text = "Pensando para trayectos a pie, la app te da\ninformacion del lugar donde estas parado\n(Requiere GPS).";
            lblExploracionLibre.HorizontalTextAlignment = TextAlignment.Center;

            lblGruiaDeTutismo.Text = "Menú tradicional de la aplicación desde\ndonde podras buscar un establecimiento,\natracción o evento.";
            lblGruiaDeTutismo.HorizontalTextAlignment = TextAlignment.Center;

            lblDeComoTeSientesHoy.Text = "Menú basado a como te sientes hoy. te brindara\ninformacion sobre lugares relacionados\nal tema seleccionado";
            lblDeComoTeSientesHoy.HorizontalTextAlignment = TextAlignment.Center;
        }

        private void ApartadoExploracionLibre_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Huichapan Pueblo Magico", "Boton Inabilitado", "ok");
            Navigation.PushAsync(new AgregarEventos());
        }

        private void ApartadoGuiaDeTurismo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMenuQueDeceasHAcer());
        }

        private void ApartdaoComoTeSietesHoy_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Huichapan Pueblo Magico", "Boton Inabilitado", "ok");
        }
    }
}