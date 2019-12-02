using PuebloMagicoH.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuebloMagicoH.Movil.GUI.Viws.ViwsQueDeceasHacerHoy.ViwsGuiasDeTurismo.ViwsDirectorioDondeComer
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageDescripcionDirectorioDondeComer : ContentPage
	{
		public PageDescripcionDirectorioDondeComer (Comercio comercio)
		{
			InitializeComponent ();

            Title = "Restaurante: "+comercio.NombreComercio;
            lblDescripcion.Text = comercio.Descripcion;
            lblDireccion.Text = comercio.Direccion;
            lblNombreDeDirectorioDeComercio.Text = comercio.NombreComercio;
		}
	}
}