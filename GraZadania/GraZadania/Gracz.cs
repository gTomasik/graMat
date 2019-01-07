using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;

namespace GraZadania
{
    public class Gracz
    {
        public string Imie
        { get; set; }

        public decimal Punkty
        { get; set; }

        public DispatcherTimer _t
        { get; set; }

        public DateTime _tstart
        { get; set; }

        public String czasPrzejscia
        { get; set; }
    }
}
