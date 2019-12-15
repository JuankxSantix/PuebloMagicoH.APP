using PuebloMagicoH.BIZ;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares;
using PuebloMagicoH.COMMON.Interfaces;
using PuebloMagicoH.DAL;
using PuebloMagicoH.Movil.GUI.Viws.ViwsGuiasDeTurismo.ViwsEventosDeHoy;
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
	public partial class PageEventosDeHoy : ContentPage
	{
        IManejadorDeEventos manejadorDeEventos;
        public PageEventosDeHoy ()
		{
			InitializeComponent ();
            manejadorDeEventos = new ManejadorEventos(new RepositorioGenerico<Eventos>());
            lblFecha.Text =DateTime.Now.ToLongDateString();
            CollectionDeEventos.ItemsSource = manejadorDeEventos.EvendoDelDia(DateTime.Now);
        }
        private void CollectionDeEventos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Eventos eventos = CollectionDeEventos.SelectedItem as Eventos;
            Navigation.PushAsync(new PageDescripcionDeEvento(eventos));
        }
    }
}