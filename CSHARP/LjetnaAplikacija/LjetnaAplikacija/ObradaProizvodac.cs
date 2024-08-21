using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LjetnaAplikacija.Model;

namespace LjetnaAplikacija
{
    internal class ObradaProizvodac
    {
        public List<Proizvodac> Proizvodaci { get; set; }

        public ObradaProizvodac()
        {
            Proizvodaci = new List<Proizvodac>();
            if (Pomocno.DEV) UcitajDEV();
        }

        private void UcitajDEV()
        {
            Proizvodaci.Add(new() { Naziv = "Heckler & Koch", GodinaOsnovanja = 1949});
            Proizvodaci.Add(new() { Naziv = "KRISS", GodinaOsnovanja = 2002});
            Proizvodaci.Add(new() { Naziv = "FN Herstal", GodinaOsnovanja = 1889});
            Proizvodaci.Add(new() { Naziv = "Izmash", GodinaOsnovanja = 1975});
        }

        public void PrikaziIzbornik()
        {

            Console.WriteLine("-----Proizvođaći-----");
            Console.WriteLine("1. Pregled proizvođaća");
            Console.WriteLine("2. Unos novih proizvođivaća");
            Console.WriteLine("3. Promjena postojećih proizvođivaća");
            Console.WriteLine("4. Brisanje proizvođivaća");
            Console.WriteLine("5. Povratak");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Vaš odabir: ", 1, 5))
            {
                case 1:
                    Console.Clear();
                    PrikaziProizvodace();
                    PrikaziIzbornik();
                    break;

                case 2:
                    Console.Clear();
                    UnosNovogProizvodaca();
                    Console.Clear();
                    Console.WriteLine("* +1 Proizvođač dodan");
                    PrikaziIzbornik();
                    break;

                case 3:
                    Console.Clear();
                    PromjenaProizvodaca();
                    break;

                case 4:
                    Console.Clear();
                    IzbrisiProizvodaca();
                    break;

                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void IzbrisiProizvodaca()
        {
            if (Proizvodaci.Count != 0)
            {
                PrikaziProizvodace();
                var odabrani = Proizvodaci[Pomocno.UcitajRasponBroja("Odaberi redni broj proizvođaća: ", 1, Proizvodaci.Count) - 1];
                if (Pomocno.UcitajBool("Potvrdi brisanje proizvođaća " + odabrani.Naziv + " (DA/NE): ", "da"))
                {
                    Proizvodaci.Remove(odabrani);
                    Console.Clear();
                    Console.WriteLine("* 1+ Proizvođać izbrisan *");
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
                Console.WriteLine("* Nema proizvođaća za obrisati! *");
                PrikaziIzbornik();
            }
        }


        private void PromjenaProizvodaca()
        {
            if (Proizvodaci.Count != 0)
            {
                PrikaziProizvodace();
                var odabrani = Proizvodaci[Pomocno.UcitajRasponBroja("Unesi redni broj proizvođaća: ", 1, Proizvodaci.Count) - 1];
                odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru proizvođaća: ", 1, int.MaxValue);
                odabrani.Naziv = Pomocno.UcitajString("Unesi naziv proizvođaća: ", 40, true);
                odabrani.GodinaOsnovanja = Pomocno.UcitajRasponBroja("Unesi godinu osnovanja proizvođaća: ", 1, 2100);
                Console.Clear();
                Console.WriteLine("* +1 proizvođać promjenjen *");
                PrikaziIzbornik();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("* Nema proizvođaća za promjeniti! *");
                PrikaziIzbornik();
            }
        }

        public void PrikaziProizvodace()
        {
            Console.WriteLine("========--");
            Console.WriteLine("Proizvođaći u bazi podataka");
            int redni = 0;
            foreach (var p in Proizvodaci)
            {
                Console.WriteLine(++redni+". ("+p.GodinaOsnovanja+") "+p.Naziv);
            }
            Console.WriteLine("========--");
        }

        private void UnosNovogProizvodaca()
        {
            Proizvodaci.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru proizvođaća: ", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv proizvođaća: ", 40, true),
                GodinaOsnovanja = Pomocno.UcitajRasponBroja("Unesi godinu osnovanja proizvođaća: ", 1, 2100)
            });
        }
    }
}
