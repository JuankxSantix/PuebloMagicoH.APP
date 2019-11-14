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
        List<string> Estado;
        List<string> Ciudad;
        List<string> Ocupacion;
        List<string> VienesPor;
        List<string> TeEnterastePor;

        public VentanaCrearNuevoUsuario ()
		{
			InitializeComponent();
            ElementosInicalizar();
            pickerGenero.ItemsSource = genero;
            pickerCiudad.ItemsSource = Ciudad;
            pickerEstado.ItemsSource = Estado;
            pickerOcupacion.ItemsSource = Ocupacion;
            pickerTeEnterastePor.ItemsSource = TeEnterastePor;
            pickerVienesAHuichapanPor.ItemsSource = VienesPor;
            
        }

        public void ElementosInicalizar()
        {
            genero = new List<string>() {

                "Masculino",
                "Femenino"
            };
            Estado = new List<string>()
            {
                "Hidalgo",
                "Mexico"
            };
            Ciudad = new List<string>()
            {
                "Pachuca",
                "Mexico"
            };
            Ocupacion = new List<string>()
            {
                "Estudiante",
                "Maestro",
                "Campesino",
                "Otro"
            };

            VienesPor = new List<string>()
            {
                "Negocios",
                "Cambio de residencia",
                "Divercion",
                "Trabajo"
            };
            TeEnterastePor = new List<string>()
            {
                "Internet",
                "Amigos",
                "Propaganda",
                "Informacion"
            };

        }

     
    }
    
}