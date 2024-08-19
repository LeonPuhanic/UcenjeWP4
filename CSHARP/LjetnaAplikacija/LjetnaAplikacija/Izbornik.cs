using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetnaAplikacija
{
    internal class Izbornik
    {
        public ObradaOruzje ObradaOruzje { get; set; }
        public ObradaOptika ObradaOptika { get; set; }

        public ObradaProizvodac ObradaProizvodac { get; set; }


        public Izbornik()
        {
            Pomocno.DEV = true;
            ObradaProizvodac = new ObradaProizvodac();
            ObradaOptika = new ObradaOptika();
            ObradaOruzje = new ObradaOruzje(this);
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
                    Console.Clear();
                    ObradaOruzje.PrikaziIzbornik();
                    Menu();
                    PrikaziIzbornik();
                    break;

                case 2:
                    Console.Clear();
                    ObradaOptika.PrikaziIzbornik();
                    Menu();
                    PrikaziIzbornik();
                    break;

                case 3:
                    Console.Clear();
                    ObradaProizvodac.PrikaziIzbornik();
                    Menu();
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
