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
        private Izbornik Izbornik;

        public ObradaOptika()
        {
            Optike = new List<Optika>();
        }

        public ObradaOptika(Izbornik Izbornik)
        {
            this.Izbornik = Izbornik;
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

                case 3:
                    Console.Clear();
                    PromjeniOptiku();
                    break;

                case 4:
                    Console.Clear();
                    IzbrisiOptiku();
                    break;

                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void PromjeniOptiku()
        {
            if(Optike.Count != 0)
            {
                PrikaziOptike();
                var odabran = Optike[Pomocno.UcitajRasponBroja("Odaberi redni broj optike: ", 1, Optike.Count) - 1];
                odabran.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru optike: ", 1, int.MaxValue);
                odabran.Naziv = Pomocno.UcitajString("Unesi naziv optike: ", 40, true);
                odabran.Cijena = Pomocno.UcitajDecimalni("Unesi cijenu ooptike ($): ", 0, 50000);
                odabran.Tezina = Pomocno.UcitajRasponBroja("Unesi težinu optike (g): ", 1, 10000);
                odabran.Magnifikacija = Pomocno.UcitajString("Unesi magnifikaciju optike: ", 12, false);
                Console.Clear();
                Console.WriteLine("* +1 optika promjenjena *");
                PrikaziIzbornik();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("* Nema optike za promjeniti! *");
                PrikaziIzbornik();
            }
        }

        private void IzbrisiOptiku()
        {
            if (Optike.Count != 0)
            {
                PrikaziOptike();
                var odabrani = Optike[Pomocno.UcitajRasponBroja("Odaberi redni broj optike: ", 1, Optike.Count) - 1];
                if (Pomocno.UcitajBool("Potvrdi brisanje oružja " + odabrani.Naziv + " (DA/NE): ", "da"))
                {
                    Optike.Remove(odabrani);
                    Console.Clear();
                    Console.WriteLine("* 1+ Optika izbrisana *");
                    PrikaziIzbornik();
                }
                else
                {
                    Console.Clear();
                    PrikaziIzbornik();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("* Nema optike za obrisati! *");
                PrikaziIzbornik();
            }
        }

        private void PrikaziOptike()
        {
            Console.WriteLine("========--");
            Console.WriteLine("Optike u bazi podataka");
            int redni = 0;
            foreach (var o in Optike)
            {
                Console.WriteLine(++redni+". ("+o.Proizvodac.Naziv+") "+o.Naziv+"  "+o.Magnifikacija+"x");
            }
        }

        private void UnosNoveOptike()
        {
            Optika o = new Optika();

            o.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru optike: ", 1, int.MaxValue);
            o.Naziv = Pomocno.UcitajString("Unesi naziv optike: ", 40, true);
            o.Cijena = Pomocno.UcitajDecimalni("Unesi cijenu ooptike ($): ", 0, 50000);
            o.Tezina = Pomocno.UcitajRasponBroja("Unesi težinu optike (g): ", 1, 10000);
            o.Magnifikacija = Pomocno.UcitajString("Unesi magnifikaciju optike (x): ", 12, false);
            Izbornik.ObradaProizvodac.PrikaziProizvodace();
            o.Proizvodac = Izbornik.ObradaProizvodac.Proizvodaci[Pomocno.UcitajRasponBroja("Odaberi redni broj proizvođaća: ", 1, Izbornik.ObradaProizvodac.Proizvodaci.Count) - 1];
            Optike.Add(o);
        }
    }
}
