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
using System.Data;

namespace GraZadania
{
    /// <summary>
    /// Logika interakcji dla klasy WyswietlRanking.xaml
    /// </summary>
    public partial class WyswietlRanking : Page
    {
        public WyswietlRanking()
        {
            InitializeComponent();
        }
        private List<Gracz> List;
        private List<Pytanie> ListaPytanZle;
        public WyswietlRanking(List<Gracz> lista,List<Pytanie> lista2)
        {
            InitializeComponent();
            List = lista;
            ListaPytanZle = lista2;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new DodajGracza(List));
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < List.Count; i++)
            {
                myDataGrid.Items.Add(List[i]);
            }
            this.Button1.Content = "";
            this.Button1.Height = 0;
            this.Button1.Width = 0;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new WyswietlZle(List, ListaPytanZle));
        }
    }
}
