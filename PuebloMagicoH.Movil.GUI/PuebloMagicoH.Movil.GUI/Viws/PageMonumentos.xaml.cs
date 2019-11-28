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
	public partial class PageMonumentos : ContentPage
	{
        IManejadorDeMonumentos manejadorDeMonumentos;
		public PageMonumentos ()
		{
			InitializeComponent ();
            manejadorDeMonumentos = new ManejadorMonumentos(new RepositorioGenerico<Monumentos>());
            CollectionDeMonumentos.ItemsSource = manejadorDeMonumentos.Listar;
		}
	}
}