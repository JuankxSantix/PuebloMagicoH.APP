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
	public partial class PageEventosEntreLasFechas : ContentPage
	{
        IManejadorDeEventos manejadorDeEventos;
        public PageEventosEntreLasFechas ()
		{
			InitializeComponent ();
            manejadorDeEventos = new ManejadorEventos(new RepositorioGenerico<Eventos>());
        }

        private void BtnBuscar_Clicked(object sender, EventArgs e)
        {
            CollectionDeEventos.ItemsSource = manejadorDeEventos.EventosEntre(DateInicio.Date,DateFin.Date);
        }

        //private void BtnAgregar_Clicked(object sender, EventArgs e)
        //{

        //    Eventos eventos = new Eventos()
        //    {
        //        Costo = 330,
        //        FechaFinal = DateFin.Date,
        //        FechaInicio = DateInicio.Date,
        //        IDLugar = 2213,
        //        LugarEvento = "San jose atlan",
        //        NombreEvento = "los niños el alma de la fiesta"
        //    };
        //    if (manejadorDeEventos.AGREGAR(eventos))
        //    {
        //        DisplayAlert("Operacion", "Se creo Correctamente", "ok");
        //    }
        //    else
        //    {
        //        DisplayAlert("Operacion", "No Se creo", "ok");

        //    }
        //}
    }
}