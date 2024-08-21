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
        private Izbornik Izbornik;

        public ObradaOruzje()
        {
            Oruzja = new List<Oruzje>();
            if (Pomocno.DEV) UcitajDEV();
        }

        public ObradaOruzje(Izbornik Izbornik)
        {
            this.Izbornik = Izbornik;
            Oruzja = new List<Oruzje>();
        }

        private void UcitajDEV()
        {
            Oruzja.Add(new() { Naziv = "AK-47" });
            Oruzja.Add(new() { Naziv = "H&K HK416" });
            Oruzja.Add(new() { Naziv = "KRISS Vector" });
            Oruzja.Add(new() { Naziv = "FN Five SeveN" });
        }

        public void PrikaziIzbornik()
        { 

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
                case 1:
                    Console.Clear();
                    PrikaziOruzja();
                    PrikaziIzbornik();
                    break;


                case 2:
                    Console.Clear();
                    UnosNovogOruzja();
                    Console.Clear();
                    Console.WriteLine("* +1 Oružje dodano *");
                    PrikaziIzbornik();
                    break;

                case 3:
                    Console.Clear();
                    PromjeniOruzje();
                    break;

                case 4:
                    Console.Clear();
                    IzbrisiOruzje();
                    break;

                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void IzbrisiOruzje()
        {
            if (Oruzja.Count != 0)
            {
                PrikaziOruzja();
                var odabrani = Oruzja[Pomocno.UcitajRasponBroja("Odaberi redni broj oružja: ", 1, Oruzja.Count) - 1];
                if (Pomocno.UcitajBool("Potvrdi brisanje oružja " + odabrani.Naziv + " (DA/NE): ", "da"))
                {
                    Oruzja.Remove(odabrani);
                    Console.Clear();
                    Console.WriteLine("* 1+ Oružje izbrisano *");
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
                Console.WriteLine("* Nema oružja za obrisati! *");
                PrikaziIzbornik();
            }
        }

        private void PromjeniOruzje()
        {
            if(Oruzja.Count != 0)
            {
                PrikaziOruzja();
                var odabrani = Oruzja[Pomocno.UcitajRasponBroja("Odaberi redni broj oružja: ", 1, Oruzja.Count) - 1];
                odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru oružja: ", 1, int.MaxValue);
                odabrani.Naziv = Pomocno.UcitajString("Unesi naziv oružja: ", 40, true);
                odabrani.Cijena = Pomocno.UcitajDecimalni("Unesi cijenu oružja ($): ", 0, 50000);
                odabrani.Tezina = Pomocno.UcitajRasponBroja("Unesi težinu oružja (g): ", 1, 10000);
                odabrani.GodinaProizvodnje = Pomocno.UcitajRasponBroja("Unesi godinu proizvodnje oružja: ", 1000, 2100);
                Izbornik.ObradaProizvodac.PrikaziProizvodace();
                odabrani.Proizvodac = Izbornik.ObradaProizvodac.Proizvodaci[Pomocno.UcitajRasponBroja("Odaberi redni broj proizvođaća: ", 1, Izbornik.ObradaProizvodac.Proizvodaci.Count) - 1];
                Console.Clear();
                Console.WriteLine("* +1 oružje promjenjeno *");
                PrikaziIzbornik();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("* Nema oružja za promjeniti! *");
                PrikaziIzbornik();
            }

        }

        private void PrikaziOruzja()
        {
            Console.WriteLine("========--");
            Console.WriteLine("Oružja u bazi podataka");
            int redni = 0;
            foreach (var o in Oruzja)
            {
                Console.WriteLine(++redni + ". ("+o.Proizvodac.Naziv+") "+o.Naziv
                    );
            }
        }

        private void UnosNovogOruzja()
        {
            PromjenaPodataka();
        }


        private void PromjenaPodataka()
        {
            Oruzje o = new Oruzje();

            o.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru oružja: ", 1, int.MaxValue);
            o.Naziv = Pomocno.UcitajString("Unesi naziv oružja: ", 40, true);
            o.Cijena = Pomocno.UcitajDecimalni("Unesi cijenu oružja ($): ", 0, 50000);
            o.Tezina = Pomocno.UcitajRasponBroja("Unesi težinu oružja (g): ", 1, 10000);
            o.GodinaProizvodnje = Pomocno.UcitajRasponBroja("Unesi godinu proizvodnje oružja: ", 1000, 2100);
            Izbornik.ObradaProizvodac.PrikaziProizvodace();
            o.Proizvodac = Izbornik.ObradaProizvodac.Proizvodaci[Pomocno.UcitajRasponBroja("Odaberi redni broj proizvođaća: ", 1, Izbornik.ObradaProizvodac.Proizvodaci.Count) - 1];
            Oruzja.Add(o);
        }
    }
}
