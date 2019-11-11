using PuebloMagicoH.COMMON;
using PuebloMagicoH.COMMON.Entidades;
using PuebloMagicoH.COMMON.Modelos;
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
        Repositorio<Usuarios> repositorio;
        LoginModel model;
        public MainPage()
        {
            InitializeComponent();
            repositorio= new Repositorio<Usuarios>();
            model = BindingContext as LoginModel;

        }

        private void BtnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            Usuarios usuario = repositorio.Query(p => p.Correo == model.Email && p.Contrasenia == model.Password).SingleOrDefault();

            if (usuario != null)
            {
                DisplayAlert("Huichapan Pueblo Magico", "Bienvenido"+usuario.NombreDeUsuario, "ok");
                //ingresa
            }
            else
            {
                DisplayAlert("Error", "E-mail Y/o contraseña incorrecta", "ok");
            }
        }

        private void BtnCrearCuenta_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Error", "E-mail Y/o contraseña incorrecta", "ok");
        }
    }
}
