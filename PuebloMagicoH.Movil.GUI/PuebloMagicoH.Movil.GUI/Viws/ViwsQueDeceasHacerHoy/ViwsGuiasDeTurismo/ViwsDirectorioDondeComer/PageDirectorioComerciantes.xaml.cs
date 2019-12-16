using PuebloMagicoH.BIZ;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares.SubClaseIntermediaLugares.SubClaseUsuaiosValidadores;
using PuebloMagicoH.COMMON.Entidades.EntidadBase;
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
        IManejadorDeCategoriaEstablecimientos manejadorDeCategoriaEstablecimientos;
		public PageDirectorioComerciantes ()
		{

			InitializeComponent ();
            manejadorDeCategoriaEstablecimientos = new ManejadorCategoriaEstablecimientos(new RepositorioGenerico<CategoriaEstablecimiento>());
            manejadorDeComercios = new ManejadorComercios(new RepositorioGenerico<Comercio>());
            PickerCategorias.ItemsSource = manejadorDeCategoriaEstablecimientos.Listar;
            //CollectionDeComercios.ItemsSource = manejadorDeComercios.Listar;
		}

        private void PickerCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PickerCategorias.SelectedItem != null)
            {
                CategoriaEstablecimiento categoriaEstablecimiento = PickerCategorias.SelectedItem as CategoriaEstablecimiento;
                CollectionDeComercios.ItemsSource = manejadorDeComercios.CategoriaDeComercio(PickerCategorias.SelectedItem as CategoriaEstablecimiento);
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