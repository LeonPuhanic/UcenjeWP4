using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetnaAplikacija
{
    internal class Izbornik
    {
        public ObradaOruzje ObradaOruzje { get; set; } = new ObradaOruzje();


        public Izbornik()
        {
            Menu();
            PrikaziIzbornik();
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("-----GLAVNI IZBORNIK-----");
            Console.WriteLine("1. Oruzja");
            Console.WriteLine("2. Optike");
            Console.WriteLine("3. Proizvodaci");
            Console.WriteLine("4. Izlaz");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Vas odabir: ", 1, 4))
            {
                case 1:
                    ObradaOruzje.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;

                case 4:
                    Console.WriteLine("Doviđenja!");
                    break;
            }
        }

        private void Menu()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("------------Welcome------------");
            Console.WriteLine("-------------------------------");
        }
    }



}
