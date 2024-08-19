using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetnaAplikacija.Model
{
    internal class Proizvodac:Entitet
    {
        public string? Naziv { get; set; }
        public int? GodinaOsnovanja { get; set; }

        public override string ToString()
        {
            return "Naziv: " + Naziv + ", Godina osnovanja: " + GodinaOsnovanja;
        }
    }
}
