using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetnaAplikacija.Model
{
    internal class Oruzje:Entitet
    {
        public string? Naziv { get; set; }
        public string? Kalibar { get; set; }
        public string? Cijena { get; set; }
        public int? Tezina { get; set; }
        public int? KapacitetSpremnika { get; set; }
        public int? GodinaProizvodnje { get; set; }
        public Proizvodac? Proizvodac { get; set; }

        public override string ToString()
        {
            return "Naziv: " + Naziv + ", Težina (g): " + Tezina + ", Kalibar: " + Kalibar + ", Cijena ($): " + Cijena + ", God. Proizvodnje: " + GodinaProizvodnje+", Proizvodac: "+Proizvodac.Naziv;
        }
    }
}
