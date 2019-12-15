using PuebloMagicoH.BIZ;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares.SubClaseIntermediaLugares;
using PuebloMagicoH.COMMON.Interfaces;
using PuebloMagicoH.DAL;
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
	public partial class PageServiciosDeEmergencia : ContentPage
	{
        IManejadorDeTelefonosEmergencia manejadorDeTelefonosEmergencia;
		public PageServiciosDeEmergencia ()
		{
			InitializeComponent ();
            manejadorDeTelefonosEmergencia = new ManejadorDeTelefonosEmergencia(new RepositorioGenerico<TelefonosEmergencia>());
            CollectionDeTelefonosEmergencia.ItemsSource = manejadorDeTelefonosEmergencia.Listar;
		}

        //private void CollectionDeTelefonosEmergencia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //}
    }
}