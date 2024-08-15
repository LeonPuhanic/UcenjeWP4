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
        public Kalibar? Kalibar { get; set; }
        public string? Cijena { get; set; }
        public int? Tezina { get; set; }
        public int? DuzinaCijevi { get; set; }
        public int? BrzinaPaljbe { get; set; }
        public int? KapacitetSpremnika { get; set; }
        public int? GodinaProizvodnje { get; set; }
        public string? TipPaljbe { get; set; }
    }
}
