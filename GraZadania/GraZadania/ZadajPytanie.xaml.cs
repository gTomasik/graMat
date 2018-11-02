using System;
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
    /// Logika interakcji dla klasy ZadajPytanie.xaml
    /// </summary>
    public partial class ZadajPytanie : Page
    {
        public ZadajPytanie()
        {
            InitializeComponent();

        }
        private List<Gracz> List;
        
        public ZadajPytanie(List<Gracz> lista)
        {
            InitializeComponent();
            List = lista;

        }
        struct Pytanie
        {
            public string Dzialanie;
            public int Wynik;
        }
  
        
        List<Pytanie> ListaPytan = new List<Pytanie>()
        {
            new Pytanie(){Dzialanie="1+1+2", Wynik =4},
            new Pytanie(){Dzialanie="1+5", Wynik =6},
            new Pytanie(){Dzialanie="5-2", Wynik =3},
            new Pytanie(){Dzialanie="4/2", Wynik =2},
            new Pytanie(){Dzialanie="4*1", Wynik =4},

        };
   
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            this.dzialanieBlock.Text = ListaPytan[0].Dzialanie;
            this.button2.Content = "";
            this.button2.Height = 0;
            this.button2.Width = 0;
            this.dzialanieBox.Width = 225;
        }
        public int inc=1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (inc < ListaPytan.Count)
                {
                    if (ListaPytan[inc - 1].Wynik == Int32.Parse(dzialanieBox.Text))
                    {
                        List[List.Count - 1].Punkty = List[List.Count - 1].Punkty + 1;
                        ;
                    }
                    this.dzialanieBlock.Text = ListaPytan[inc].Dzialanie;
                    this.dzialanieBox.Text = "";
                    inc = inc + 1;
                }
                else
                {
                    if (ListaPytan[inc - 1].Wynik == Int32.Parse(dzialanieBox.Text))
                    {
                        List[0].Punkty = List[0].Punkty + 1;

                    }
                    this.NavigationService.Navigate(new WyswietlRanking(List));
                }
            }

            catch
            {
                System.Windows.MessageBoxResult result = MessageBox.Show("Podaj odpowiedź która jest liczbą",
                                                "Error",
                                                MessageBoxButton.OK,
                                                MessageBoxImage.Error);
            }

         
           
        }
       
    }
}
