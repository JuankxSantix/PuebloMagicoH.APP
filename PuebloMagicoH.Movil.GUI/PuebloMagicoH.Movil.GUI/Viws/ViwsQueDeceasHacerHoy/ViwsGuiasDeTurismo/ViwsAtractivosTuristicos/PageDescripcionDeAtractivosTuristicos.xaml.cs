using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClaseIntermediaDeLugares.SubClaseIntermediaTuristicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuebloMagicoH.Movil.GUI.Viws.ViwsQueDeceasHacerHoy.ViwsGuiasDeTurismo.ViwsAtractivosTuristicos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageDescripcionDeAtractivosTuristicos : ContentPage
	{
		public PageDescripcionDeAtractivosTuristicos (AtractivosTuristicos atractivosTuristicos)
		{
			InitializeComponent ();

            lblNombreDeAtractivoTuristico.Text = atractivosTuristicos.Nombre;
            Title = "¡"+atractivosTuristicos.Nombre + "!";
            lblDescripcion.Text = atractivosTuristicos.Descripcion;
            lblDireccion.Text = atractivosTuristicos.Direccion;
		}
	}
}