using PuebloMagicoH.BIZ;
using PuebloMagicoH.COMMON;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using PuebloMagicoH.COMMON.Modelos;
using PuebloMagicoH.DAL;
using PuebloMagicoH.Movil.GUI.Viws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PuebloMagicoH.Movil.GUI
{
    public partial class MainPage : ContentPage
    {
        IManejadorDeUsuarios manejadorDeUsuarios;
        LoginModel model;
        public MainPage()
        {
            InitializeComponent();
            manejadorDeUsuarios = new ManejadorUsuarios(new RepositorioGenerico<Usuarios>());
            model = BindingContext as LoginModel;


            
        }

        private void BtnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            
            //Usuarios usuario = manejadorDeUsuarios.BuscarContrasenia(model.Password);
            //Usuarios usuario1 = manejadorDeUsuarios.BuscarCorreo(model.Email);
            
            
            //if (usuario.id.ToString()== usuario1.id.ToString()
            //{
            //    DisplayAlert("Huichapan Pueblo Magico", "Bienvenido" + usuario.NombreDeUsuario, "ok");
            
            Navigation.PushAsync(new PageQueDeceasHacerHoy());
            //}
            //else
            //{
            //    DisplayAlert("Error", "E-mail Y/o contraseña incorrecta", "ok");
            //}
        }

        private void BtnCrearCuenta_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VentanaCrearNuevoUsuario());
        }
    }
}
