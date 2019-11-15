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
        IManejadorDeUsuarios manejadorDeUsuarios;
        Usuarios usuario;

        public VentanaCrearNuevoUsuario ()
		{
			InitializeComponent();
            manejadorDeUsuarios = new ManejadorUsuarios(new RepositorioDeUsuarios());
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
                "Diversion",
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
        
        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtContrasenia.Text)&& !string.IsNullOrWhiteSpace(txtEMail.Text)&& !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtRepetirContrasenia.Text))
            {
                if (txtContrasenia.Text == txtContrasenia.Text)
                {
                    usuario = new Usuarios()
                    {
                        Ciudad = pickerCiudad.SelectedItem.ToString(),
                        Contrasenia = txtContrasenia.Text,
                        Correo = txtEMail.Text,
                        EnteradoPor = pickerTeEnterastePor.SelectedItem.ToString(),
                        Estado = pickerEstado.SelectedItem.ToString(),
                        MotivoDeVisita = pickerVienesAHuichapanPor.SelectedItem.ToString(),
                        NombreDeUsuario = txtNombre.Text,
                        Genero = pickerGenero.SelectedItem.ToString(),
                        Ocupacion = pickerOcupacion.SelectedItem.ToString(),
                        FechaDeNacimiento = datepickerNAcimiento.Date,


                    };
                    if (manejadorDeUsuarios.AGREGAR(usuario))
                    {
                        DisplayAlert("Huichapan Pueblo Magico", "Tu registro fue exitoso\nInicia sesión", "Aceptar");
                        Navigation.PushAsync(new MainPage());
                    }
                    else
                    {
                        DisplayAlert("Huichapan Pueblo Magico", "Error\nNo se puede realizar tu registro por el momento", "Aceptar", "Canselar");
                    }
                    
                }
                else
                {
                    DisplayAlert("Huichapan Pueblo Magico", "Error\nLa contraseña no coinside", "Aceptar", "Canselar");
                }
            }
            else
            {
                DisplayAlert("Huichapan Pueblo Magico", "Error\nDatos Incompletos", "Aceptar","Canselar");
            }

        }
    }
    
}