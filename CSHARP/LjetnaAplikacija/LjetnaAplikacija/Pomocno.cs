using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetnaAplikacija
{
    internal class Pomocno
    {
        internal static int UcitajRasponBroja(string poruka, int minBroj, int maxBroj)
        {
            int b;
            while(true)
            {
                try
                {
                    Console.Write(poruka);
                    b = int.Parse(Console.ReadLine());
                    if (b < minBroj || b > maxBroj)
                        throw new Exception();
                    return b;
                }
                catch
                {
                    Console.WriteLine("Neispravan unos! Mora biti od {0} do {1}", minBroj, maxBroj);
                }
            }

            return 0;
        }
    }
}
