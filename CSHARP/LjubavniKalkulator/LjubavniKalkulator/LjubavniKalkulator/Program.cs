using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite svoje ime:");
        string mojeIme = Console.ReadLine().ToUpper();

        Console.WriteLine("Unesite ime simpatije:");
        string imeSimpatije = Console.ReadLine().ToUpper();

        string svaImena = mojeIme + imeSimpatije;

        Dictionary<char, int> brojSlova = new Dictionary<char, int>();

        for (int i = 0; i < svaImena.Length; i++)
        {
            if (brojSlova.ContainsKey(svaImena[i]))
            {
                brojSlova[svaImena[i]]++;
            }
            else
            {
                brojSlova[svaImena[i]] = 1;
            }
        }

        List<int> brojevi = new List<int>();

        for (int i = 0; i < mojeIme.Length; i++)
        {
            brojevi.Add(brojSlova[mojeIme[i]]);
        }

        for (int i = 0; i < imeSimpatije.Length; i++)
        {
            brojevi.Add(brojSlova[imeSimpatije[i]]);
        }

        Console.WriteLine(mojeIme + "   " + imeSimpatije);
        for (int i = 0; i < mojeIme.Length; i++)
        {
            Console.Write(brojevi[i] + " ");
        }

        Console.Write("     ");

        for (int i = mojeIme.Length; i < brojevi.Count; i++)
        {
            Console.Write(brojevi[i] + " ");
        }

        Console.WriteLine();

        while (brojevi.Count > 2)
        {
            List<int> noviBrojevi = new List<int>();

            for (int i = 0; i < brojevi.Count / 2; i++)
            {
                int zbroj = brojevi[i] + brojevi[brojevi.Count - 1 - i];
                noviBrojevi.Add(zbroj % 10);
            }

            if (brojevi.Count % 2 == 1)
            {
                noviBrojevi.Add(brojevi[brojevi.Count / 2]);
            }

            brojevi = noviBrojevi;

            for (int i = 0; i < brojevi.Count; i++)
            {
                Console.Write(brojevi[i]);
            }
            Console.WriteLine();
        }

        int postotak = brojevi[0] * 10 + brojevi[1];
        if (postotak > 100) postotak = 100;

        Console.WriteLine("Postotak šanse za ljubav: " + postotak + "%");
    }
}