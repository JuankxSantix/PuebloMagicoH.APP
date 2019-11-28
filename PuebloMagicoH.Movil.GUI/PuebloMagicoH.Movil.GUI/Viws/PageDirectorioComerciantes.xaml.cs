using PuebloMagicoH.BIZ;
using PuebloMagicoH.COMMON.Entidades;
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
    }
}