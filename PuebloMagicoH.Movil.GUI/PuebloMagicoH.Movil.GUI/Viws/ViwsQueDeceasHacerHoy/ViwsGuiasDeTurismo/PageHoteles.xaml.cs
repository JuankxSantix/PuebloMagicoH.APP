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
	public partial class PageHoteles : ContentPage
	{
        IManejadorDeHoteles manejadorDeHoteles;
		public PageHoteles ()
		{
			InitializeComponent ();
            manejadorDeHoteles = new ManejadorDeHoteles(new RepositorioGenerico<Hoteles>());

            CollectionDeHotelesLibres.ItemsSource = manejadorDeHoteles.Listar.Where(e=>e.HabitacionesDisponibles>=8);
            CollectionDeHotelesEnAlerta.ItemsSource=manejadorDeHoteles.Listar.Where(e => e.HabitacionesDisponibles >= 5 && e.HabitacionesDisponibles<8);
            CollectionDeHotelesEnRiesgo.ItemsSource=manejadorDeHoteles.Listar.Where(e => e.HabitacionesDisponibles<5);

        }
	}
}