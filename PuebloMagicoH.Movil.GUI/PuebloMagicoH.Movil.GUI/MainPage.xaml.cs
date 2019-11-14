using PuebloMagicoH.BIZ;
using PuebloMagicoH.COMMON;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Interfaces;
using PuebloMagicoH.COMMON.Modelos;
using PuebloMagicoH.DAL;
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
            manejadorDeUsuarios = new ManejadorUsuarios(new RepositorioDeUsuarios());
            model = BindingContext as LoginModel;

        }

        private void BtnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            //Usuarios usuarios= manejadorDeUsuarios.Listar.Where(e=>e.Correo==)
            //Usuarios usuario = manejadorDeUsuarios.Query(p => p.Correo == model.Email && p.Contrasenia == model.Password).SingleOrDefault();

            //if (usuario != null)
            //{
            //    DisplayAlert("Huichapan Pueblo Magico", "Bienvenido"+usuario.NombreDeUsuario, "ok");
            //    //ingresa
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
