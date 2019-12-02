using PuebloMagicoH.BIZ;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using PuebloMagicoH.DAL;
using PuebloMagicoH.Movil.GUI.Viws.ViwsQueDeceasHacerHoy.ViwsGuiasDeTurismo.ViwsDirectorioDondeComer;
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
	public partial class PageDirectorioComerciantes : ContentPage
	{
        IManejadorDeComercios manejadorDeComercios;
		public PageDirectorioComerciantes ()
		{

			InitializeComponent ();

            manejadorDeComercios = new ManejadorComercios(new RepositorioGenerico<Comercio>());
            PickerCategorias.ItemsSource = manejadorDeComercios.ListarPCategoria;
		}

        private void PickerCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PickerCategorias.SelectedItem != null)
            {

                CollectionDeComercios.ItemsSource = manejadorDeComercios.ListarPCategoria.Where(j => j.CategoriaEstablecimiento == PickerCategorias.SelectedItem.ToString());
            }
            else
            {
                DisplayAlert("Error", "No has seleccionado nada", "ok");
            }
        }

        private void CollectionDeComercios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Comercio comercio = CollectionDeComercios.SelectedItem as Comercio;

            if (comercio != null)
            {
                Navigation.PushAsync(new PageDescripcionDirectorioDondeComer(comercio));
            }
        }
    }
}