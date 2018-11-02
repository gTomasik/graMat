﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GraZadania
{
    /// <summary>
    /// Logika interakcji dla klasy DodajGracza.xaml
    /// </summary>
    public partial class DodajGracza : Page
    {
        public DodajGracza()
        {
            InitializeComponent();
        }
        struct Gracz
        {
            public string Imie;
            public int Punkty;
        }

        
        List<Gracz> ListaGraczy = new List<Gracz>(1);

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.dodajGracza(imieBox.Text);
            this.NavigationService.Navigate(new ZadajPytanie());

        }

        private void dodajGracza(string x)
        {
            Gracz tmpGracz = new Gracz()
            {
                Imie = x,
                Punkty = 0
            };

            ListaGraczy.Add(tmpGracz);

        }

    }
}
