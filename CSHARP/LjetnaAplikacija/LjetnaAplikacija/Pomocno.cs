using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetnaAplikacija
{
    internal class Pomocno
    {
        public static bool DEV = false;

        internal static bool UcitajBool(string poruka, string trueValue)
        {
            Console.Write(poruka);
            return Console.ReadLine().Trim().ToLower() == trueValue;
        }



        internal static string UcitajDecimalni(string poruka, int min, float max)
        {
            float b;
            string a;
            while(true)
            {
                try
                {
                    Console.Write(poruka);
                    b=float.Parse(Console.ReadLine());
                    a=b.ToString();
                    if (b < min || b > max) 
                        throw new Exception();
                    return a;
                }
                catch
                {
                    Console.WriteLine("-Neispravan unos! Mora biti od {0} do {1}-", min, max);
                }
            }
        }

        internal static int UcitajRasponBroja(string poruka, int minBroj, int maxBroj)
        {
            int b;
            while(true)
            {
                try
                {
                    Console.Write(poruka);
                    b = int.Parse(Console.ReadLine());
                    if (b < minBroj || b > maxBroj) throw new Exception();
                    return b;
                }
                catch
                {
                    Console.WriteLine("-Neispravan unos! Mora biti od {0} do {1}-", minBroj, maxBroj);
                }
            }

            return 0;
        }

        internal static string UcitajString(string poruka, int max, bool obv)
        {
            string s;
            while(true)
            {
                Console.Write(poruka);
                s = Console.ReadLine().Trim();
                if((obv && s.Length==0) || s.Length > max)
                {
                    Console.WriteLine("-Neispravan unos! Mora biti do {0} znakova-", max );
                    continue;
                }
                return s;
            } 
        }
    }
}
