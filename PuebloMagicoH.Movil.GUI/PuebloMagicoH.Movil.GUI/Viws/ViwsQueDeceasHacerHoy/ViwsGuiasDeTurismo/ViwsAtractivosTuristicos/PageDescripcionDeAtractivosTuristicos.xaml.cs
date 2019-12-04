using PuebloMagicoH.COMMON.Entidades;
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

            lblNombreDeAtractivoTuristico.Text = atractivosTuristicos.NombreAtractivo;
            Title = "¡"+atractivosTuristicos.NombreAtractivo+"!";
            lblDescripcion.Text = atractivosTuristicos.Descripcion;
            lblDireccion.Text = atractivosTuristicos.Direccion;
		}
	}
}