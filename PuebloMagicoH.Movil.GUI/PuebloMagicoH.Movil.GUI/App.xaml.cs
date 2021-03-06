﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PuebloMagicoH.Movil.GUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var pagina = new NavigationPage(new MainPage());
            pagina.BarBackgroundColor = (Color)App.Current.Resources["PrimaryColor"];
            MainPage = pagina;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
 