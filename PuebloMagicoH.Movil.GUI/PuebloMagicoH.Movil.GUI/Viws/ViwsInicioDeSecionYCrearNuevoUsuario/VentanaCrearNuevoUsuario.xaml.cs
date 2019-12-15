using PuebloMagicoH.BIZ;
using PuebloMagicoH.COMMON;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Entidades.ClasesUsuarios;
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
        //Repositorio<Usuarios> repositorio;
        List<string> genero;
        List<string> Estado;
        List<string> Ciudad;
        List<string> Ocupacion;
        List<string> VienesPor;
        List<string> TeEnterastePor;
        IManejadorDeUsuariosTuristicos manejadorDeUsuarios;

        public VentanaCrearNuevoUsuario ()
		{
			InitializeComponent();
            //repositorio = new Repositorio<Usuarios>();
            manejadorDeUsuarios = new ManejadorUsuariosTuristicos(new RepositorioGenerico<UsuarioTurista>());
            ElementosInicalizar();
            
            
            
        }

        public void ElementosInicalizar()
        {

            lblErrorDeEmail.IsVisible = false;
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


            pickerGenero.ItemsSource = genero;
            pickerCiudad.ItemsSource = Ciudad;
            pickerEstado.ItemsSource = Estado;
            pickerOcupacion.ItemsSource = Ocupacion;
            pickerTeEnterastePor.ItemsSource = TeEnterastePor;
            pickerVienesAHuichapanPor.ItemsSource = VienesPor;

        }
        
        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtContrasenia.Text)&& !string.IsNullOrWhiteSpace(txtEMail.Text)&& !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtRepetirContrasenia.Text))
            {
                if (txtContrasenia.Text == txtContrasenia.Text)
                {
                   UsuarioTurista usuario = new UsuarioTurista()
                    {
                        Ciudad = pickerCiudad.SelectedItem.ToString(),
                        Contrasenia = txtContrasenia.Text,
                        Correo = txtEMail.Text,
                        EnteradoPor = pickerTeEnterastePor.SelectedItem.ToString(),
                        Estado = pickerEstado.SelectedItem.ToString(),
                        MotivoDeVisita = pickerVienesAHuichapanPor.SelectedItem.ToString(),
                        Nombre = txtNombre.Text,
                        Genero = pickerGenero.SelectedItem.ToString(),
                        Ocupacion = pickerOcupacion.SelectedItem.ToString(),
                        FechaDeNacimiento = datepickerNAcimiento.Date,
                         

                    };
                    if(manejadorDeUsuarios.AGREGAR(usuario))
                    {

                        DisplayAlert("Huichapan Pueblo Magico", "Usuario "+usuario.Nombre+"\n creado correctamente", "Aceptar", "Canselar");
                    }
                    else
                    {
                        DisplayAlert("Huichapan Pueblo Magico", "No se ha podido registrar su usuario \npor favor intente mas tarde", "Aceptar");
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

            int intentos = 0;
        private void TxtEMail_TextChanged(object sender, TextChangedEventArgs e)
        {
            string x = e.NewTextValue;
            foreach (var item in x)
            {
                if (item != '@' && intentos==0)
                {
                    lblErrorDeEmail.IsVisible = true;

                }
                else
                {
                    intentos++;
                    if(intentos != 0)
                    {
                    lblErrorDeEmail.IsVisible = false;
                    }

                }

            }
        }
    }
    
}