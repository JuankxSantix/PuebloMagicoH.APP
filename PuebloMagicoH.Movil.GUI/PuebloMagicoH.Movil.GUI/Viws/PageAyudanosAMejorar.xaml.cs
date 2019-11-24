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
	public partial class PageAyudanosAMejorar : ContentPage
	{
		public PageAyudanosAMejorar ()
		{
			InitializeComponent ();
            CosasAInicializar();
		}

        private void CosasAInicializar()
        {
            lblTexto.Text = "Ayúdanos a mejor dejando un comentario si encuentras por ejemplo: \n* Mala atención por parte de algún servidor publico. \n* Tienes una queja sobre algún guía turístico. \n* Algún desperfecto con la vía publica (baches, falta de alumbrado, etc...). \n* Tienes alguna idea o mejora para esta aplicación. * Tienes algun comentario sobre algún lugar publico.";
            SouceDeImagen.Source = "BotonParaImagen.png";

        }
    }
}