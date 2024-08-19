using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LjetnaAplikacija.Model;

namespace LjetnaAplikacija
{
    internal class ObradaOptika
    {
        public List<Optika> Optike { get; set; }

        public ObradaOptika()
        {
            Optike = new List<Optika>();
        }


        public void PrikaziIzbornik()
        {

            Console.WriteLine("-----Izbornik Optika-----");
            Console.WriteLine("1. Pregled optika");
            Console.WriteLine("2. Unos novih optika");
            Console.WriteLine("3. Promjena postojećih optika");
            Console.WriteLine("4. Brisanje optika");
            Console.WriteLine("5. Povratak");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Vaš odabir: ", 1, 5))
            {
                case 1:
                    Console.Clear();
                    PrikaziOptike();
                    PrikaziIzbornik();
                    break;

                case 2:
                    Console.Clear();
                    UnosNoveOptike();
                    Console.Clear();
                    Console.WriteLine("* +1 Optika dodana");
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void PrikaziOptike()
        {
            Console.WriteLine("========--");
            Console.WriteLine("Optike u bazi podataka");
            foreach (var o in Optike)
            {
                Console.WriteLine(o);
            }
        }

        private void UnosNoveOptike()
        {
            Optike.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru optike: ", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv optike: ", 40, true),
                Cijena = Pomocno.UcitajDecimalni("Unesi cijenu ooptike ($): ", 0, 50000),
                Tezina = Pomocno.UcitajRasponBroja("Unesi težinu optike (g): ", 1, 10000),
                Magnifikacija = Pomocno.UcitajString("Unesi magnifikaciju optike: ", 12, false)
            });
        }
    }
}
