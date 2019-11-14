using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuebloMagicoH.Movil.GUI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VentanaCrearNuevoUsuario : ContentPage
	{
        List<string> genero;

        public VentanaCrearNuevoUsuario ()
		{
			InitializeComponent();
            ElementosInicalizar();
            pickerGenero.ItemsSource = genero;
            
        }

        public void ElementosInicalizar()
        {
            genero = new List<string>();
            genero.Add("Masculino");
            genero.Add("Femenino");
        }

     
    }
    
}