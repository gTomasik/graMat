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
        public WyswietlRanking(List<Gracz> lista)
        {
            InitializeComponent();
            List = lista;

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
            
        }
    }
}
