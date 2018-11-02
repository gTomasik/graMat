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
        struct Pytanie
        {
            public string Dzialanie;
            public int Wynik;
        }
  
        public int inc = 1;
        List<Pytanie> ListaPytan = new List<Pytanie>()
        {
            new Pytanie(){Dzialanie="1+1+2", Wynik =3},
            new Pytanie(){Dzialanie="1+5", Wynik =6},
            new Pytanie(){Dzialanie="5-2", Wynik =3},
            new Pytanie(){Dzialanie="4/2", Wynik =3},
            new Pytanie(){Dzialanie="4*1", Wynik =4},

        };
   
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            this.dzialanieBlock.Text = ListaPytan[0].Dzialanie;
            this.button2.Content = "";
            this.button2.Height = 0;
            this.button2.Width = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            if(inc<ListaPytan.Count)
            {
                if(ListaPytan[inc].Wynik == Int32.Parse(this.dzialanieBox.Text))
                {

                }
                this.dzialanieBlock.Text = ListaPytan[inc].Dzialanie;
                this.dzialanieBox.Text = "";
                inc = inc + 1;
            }
            else
            {
                this.NavigationService.Navigate(new WyswietlRanking());
            }
           
        }
       
    }
}
