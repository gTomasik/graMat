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
using System.Windows.Threading;
using System.Timers;


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
        private List<Gracz> List;
        public DodajGracza(List<Gracz> lista)
        {
            InitializeComponent();
            List = lista;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
  

            this.zapiszGracza(imieBox.Text);
            this.NavigationService.Navigate(new ZadajPytanie(List));
           

        }

        private void zapiszGracza(string x)
        {
            Gracz tmpGracz = new Gracz()
            {
                Imie = x,
                Punkty = 0,
                _t = new DispatcherTimer(),
                _tstart = new DateTime(),
                czasPrzejscia = ""
            };

            List.Add(tmpGracz);

        }

    }
}
