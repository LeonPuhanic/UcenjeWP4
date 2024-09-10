
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Channels;
using System.Threading.Tasks;
using LjetnaAplikacija.Model;
using Newtonsoft.Json.Linq;

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
            ObradaOptika = new ObradaOptika(this);
            ObradaOruzje = new ObradaOruzje(this);
            UcitajPodatke();
            PrikaziIzbornik();
        }

        private void UcitajPodatke()
        {
            string oruzjePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(Path.Combine(oruzjePath, "Oruzja.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(oruzjePath, "Oruzja.json"));
                ObradaOruzje.Oruzja = JsonConvert.DeserializeObject<List<Oruzje>>(file.ReadToEnd());

            }

            string optikaPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(Path.Combine(optikaPath, "Optike.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(optikaPath, "Optike.json"));
                ObradaOptika.Optike = JsonConvert.DeserializeObject<List<Optika>>(file.ReadToEnd());

            }

            string proizvodacPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(Path.Combine(proizvodacPath, "Proizvodaci.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(proizvodacPath, "Proizvodaci.json"));
                ObradaProizvodac.Proizvodaci = JsonConvert.DeserializeObject<List<Proizvodac>>(file.ReadToEnd());

            }
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
            switch (Pomocno.UcitajRasponBroja("Vas odabir: ", 1, 4))
            {
                case 1:
                    Console.Clear();
                    ObradaOruzje.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;

                case 2:
                    Console.Clear();
                    ObradaOptika.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;

                case 3:
                    Console.Clear();
                    ObradaProizvodac.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;

                case 4:
                    Console.WriteLine("Doviđenja!");
                    SpremiPodatke();
                    break;
            }
        }

        private void SpremiPodatke()
        {
            string oruzjePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamWriter outputFile = new StreamWriter(Path.Combine(oruzjePath, "Oruzja.json"));
            outputFile.WriteLine(JsonConvert.SerializeObject(ObradaOruzje.Oruzja));
            outputFile.Close();

            string optikaPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamWriter outputFile2 = new StreamWriter(Path.Combine(optikaPath, "Optike.json"));
            outputFile.WriteLine(JsonConvert.SerializeObject(ObradaOptika.Optike));
            outputFile2.Close();

            string proizvodacPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamWriter outputFile3 = new StreamWriter(Path.Combine(proizvodacPath, "Proizvodaci.json"));
            outputFile.WriteLine(JsonConvert.SerializeObject(ObradaProizvodac.Proizvodaci));
            outputFile3.Close();
        }
    }
}

