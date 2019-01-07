using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraZadania
{
    public class Pytanie
    {
        public string Dzialanie
        { get; set; }

        public int Wynik
        { get; set; }

        public Pytanie(String a, int b)
        {
            Dzialanie = a;
            Wynik = b;
        }
    }
}
