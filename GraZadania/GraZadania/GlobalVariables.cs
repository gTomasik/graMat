using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraZadania
{
    class GlobalVariables
    { 


       /* class GraczeList
        {
            private static GraczeList _GraczeList = new GraczeList();
            public static GraczeList Gracze
            {
                get { return _GraczeList; }
            }
            private List<string> gracze = new List<string>();
            private GraczeList()
            {
                // Initialize here
            }

        }*/
  
        public struct Gracze
        {
            public string Imie;
            public string Punkty;
        }

        List<Gracze> ListaGraczy = new List<Gracze>();
    }
}
