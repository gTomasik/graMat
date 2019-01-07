
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
using System.Windows.Threading;


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
       

        Random rnd = new Random((int)DateTime.Now.Ticks);

        public String LosujLiczbe()
        {
            int liczba = rnd.Next(0, 20);
            return liczba.ToString();
        }
        public String LosujZnak()
        {
            String znak = "";
     
            int liczbaznak = rnd.Next(1, 4);
            switch (liczbaznak)
            {
                case 1:
                    znak = "+";
                    break;
                case 2:
                    znak = "-";
                    break;
                case 3:
                    znak = "*";
                    break;
                case 4:
                    znak = "/";
                    break;

            }
            return znak;
        }
        List<Pytanie> ListaPytan = new List<Pytanie>()
        {
           /* new Pytanie(){Dzialanie="5+3", Wynik =8},
            new Pytanie(){Dzialanie="1+5", Wynik =6},
            new Pytanie(){Dzialanie="5-2", Wynik =3},
            new Pytanie(){Dzialanie="4/2", Wynik =2},
            new Pytanie(){Dzialanie="4*1", Wynik =4},*/

        };

        List<Pytanie> ListaPytanZle = new List<Pytanie>();

        public void LosujPytania()
        {
            for(int i = 0; i < 5; i++)
            {
                string liczba1 = LosujLiczbe();
                string liczba2 = LosujLiczbe();
                string znak = LosujZnak();
                string stringS = liczba1 + znak + liczba2;
                int wynik=0;
                switch (znak)
                {
                    case "+":
                        wynik = Int32.Parse(liczba1) + Int32.Parse(liczba2);
                        break;
                    case "-":
                        wynik = Int32.Parse(liczba1) - Int32.Parse(liczba2);
                        break;
                    case "*":
                        wynik = Int32.Parse(liczba1) * Int32.Parse(liczba2);
                        break;
                    case "/":
                        wynik = Int32.Parse(liczba1) / Int32.Parse(liczba2);
                        break;
                }
                ListaPytan.Add(new Pytanie(stringS, wynik));

            }
            
        }

       private void t_Tick(object sender, EventArgs e)
        {

        }
   
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //DateTime centuryBegin = new DateTime(2001, 1, 1);
            //DateTime currentDate = DateTime.Now;
            //long elapsedTicks = currentDate.Ticks - centuryBegin.Ticks;
            List[List.Count - 1]._t.Interval = TimeSpan.FromSeconds(1);
            List[List.Count - 1]._t.Tick += tickevent;
            List[List.Count - 1]._t.Start();
            List[List.Count - 1]._tstart = DateTime.Now;
            this.LosujPytania();
            this.dzialanieBlock.Text = ListaPytan[0].Dzialanie;
            this.button2.Content = "";
            this.button2.Height = 0;
            this.button2.Width = 0;
            this.dzialanieBox.Width = 225;
        }

        private void tickevent(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            datelbl.Text = DateTime.Now.ToString();
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
                        
                    }
                    else
                    {
                        ListaPytanZle.Add(ListaPytan[inc - 1]);
                    }
                    this.dzialanieBlock.Text = ListaPytan[inc].Dzialanie;
                    this.dzialanieBox.Text = "";
                    inc = inc + 1;
                }
                else
                {
                    if (ListaPytan[inc - 1].Wynik == Int32.Parse(dzialanieBox.Text))
                    {
                        List[List.Count - 1].Punkty = List[List.Count - 1].Punkty + 1;

                    }
                    else
                    {
                        ListaPytanZle.Add(ListaPytan[inc - 1]);
                    }
                    // DateTime centuryBegin = new DateTime(2001, 1, 1);
                    // DateTime currentDate2 = DateTime.Now;
                    //long elapsedTicks2 = currentDate2.Ticks - centuryBegin.Ticks;
                    // List[List.Count - 1].czasPrzejscia =new TimeSpan(elapsedTicks2);
                    //List[List.Count - 1].czasPrzejscia.Subtract(List[List.Count - 1]._tstart);
                    TimeSpan ts = (DateTime.Now - List[List.Count - 1]._tstart);
                    List[List.Count - 1].czasPrzejscia= ts.ToString(@"mm\:ss");
                    this.NavigationService.Navigate(new WyswietlRanking(List, ListaPytanZle));
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
