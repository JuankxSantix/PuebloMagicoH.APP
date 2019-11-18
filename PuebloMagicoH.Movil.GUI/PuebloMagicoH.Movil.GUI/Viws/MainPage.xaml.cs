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
        //Repositorio<Usuarios> repositorio;
        IManejadorDeUsuarios manejadorDeUsuarios;
        LoginModel model;
        public MainPage()
        {
            InitializeComponent();
            //repositorio= new Repositorio<Usuarios>();
            manejadorDeUsuarios = new ManejadorUsuarios(new RepositorioGenerico<Usuarios>());
            model = BindingContext as LoginModel;

        }

        private void BtnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            

            //Usuarios usuarios = manejadorDeUsuarios.Listar.Where(e => e.Correo ==)
            //Usuarios usuario = manejadorDeUsuarios.Listar(p => p.Correo == model.Email && p.Contrasenia == model.Password).SingleOrDefault();
            //if (usuario != null)
            //{
            //    DisplayAlert("Huichapan Pueblo Magico", "No Nulo", "ok");
            //}
            //else
            //{
            //    DisplayAlert("Huichapan Pueblo Magico", "Nulo", "ok");
            //}

            //Usuarios usuario = manejadorDeUsuarios.BuscarContrasenia(model.Password);
            //Usuarios usuario1 = manejadorDeUsuarios.BuscarCorreo(model.Email);
            //
            //
            //if (usuario.ID == usuario1.ID)
            //{
            //    DisplayAlert("Huichapan Pueblo Magico", "Bienvenido" + usuario.NombreDeUsuario, "ok");
            //
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
