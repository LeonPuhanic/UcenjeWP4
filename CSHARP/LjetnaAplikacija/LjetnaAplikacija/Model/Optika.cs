using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetnaAplikacija.Model
{
    internal class Optika:Entitet
    {
        public string? Naziv { get; set; }
        public string? Cijena { get; set; }
        public string? Magnifikacija { get; set; }
        public int? Tezina { get; set; }
        public Proizvodac? Proizvodac { get; set; }

    }
}
