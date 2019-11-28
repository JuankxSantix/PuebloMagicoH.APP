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

namespace PuebloMagicoH.Movil.GUI.Viws.ViwsGuiasDeTurismo.ViwsEventosDeHoy
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageDescripcionDeEvento : ContentPage
	{
        IManejadorDeEventos manejadorDeEventos;
		public PageDescripcionDeEvento ()
		{
			InitializeComponent ();

            manejadorDeEventos = new ManejadorEventos(new RepositorioGenerico<Eventos>());


            Title = "mejorado";
		}
	}
}