using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LjetnaAplikacija.Model;

namespace LjetnaAplikacija
{
    internal class ObradaOruzje
    {
        public List<Oruzje> Oruzja { get; set; }

        public ObradaOruzje()
        {
            Oruzja = new List<Oruzje>();
        }


        public void PrikaziIzbornik()
        { 
            Console.Clear();
            Console.WriteLine("-----Izbornik Oružja-----");
            Console.WriteLine("1. Pregled oružja");
            Console.WriteLine("2. Unos novih oružja");
            Console.WriteLine("3. Promjena postojećeg oružja");
            Console.WriteLine("4. Brisanje oružja");
            Console.WriteLine("5. Povratak");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Vaš odabir: ", 1, 5))
            {
                case 5:
                    Console.Clear();
                    break;
            }
        }
    }
}
