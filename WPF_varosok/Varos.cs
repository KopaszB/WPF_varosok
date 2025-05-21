using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_varosok
{
    class Varos
    {
        public int Sorszam { get; set; }
        public string Varosnev { get; set; }
        public string Jaras { get; set; }
        public string Kisterseg { get; set; }
        public int Nepesseg { get; set; }
        public double Terulet { get; set; }

        public Varos(int sorszam, string varosnev, string jaras, string kisterseg, int nepesseg, double terulet)
        {
            Sorszam = sorszam;
            Varosnev = varosnev;
            Jaras = jaras;
            Kisterseg = kisterseg;
            Nepesseg = nepesseg;
            Terulet = terulet;
        }
    }
}
