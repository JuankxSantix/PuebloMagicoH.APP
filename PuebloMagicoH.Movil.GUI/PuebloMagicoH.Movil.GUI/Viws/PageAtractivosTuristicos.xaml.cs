﻿using PuebloMagicoH.BIZ;
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

namespace PuebloMagicoH.Movil.GUI.Viws
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageAtractivosTuristicos : ContentPage
	{
        IManejadorDeAtractivosTuristicos manejadorDeAtractivosTuristicos;
        public PageAtractivosTuristicos()
        {
            InitializeComponent();
            manejadorDeAtractivosTuristicos = new ManejadorAtractivosTuristicos(new RepositorioGenerico<AtractivosTuristicos>());
            CollectionDeAtractivosTuristicos.ItemsSource = manejadorDeAtractivosTuristicos.Listar;

        }
	}
}