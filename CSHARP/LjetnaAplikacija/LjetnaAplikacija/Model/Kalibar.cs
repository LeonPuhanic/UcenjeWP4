using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetnaAplikacija.Model
{
    internal class Kalibar:Entitet
    {
        public string? Naziv { get; set; }
        public Proizvodac? Proizvodac { get; set; }
    }
}
