// See https://aka.ms/new-console-template for more information




Console.WriteLine("Unesite 2 broja za stvaranje tablice: ");

while (true)
{
    try
    {
        int broj1 = int.Parse(Console.ReadLine());
        int broj2 = int.Parse(Console.ReadLine());
        if (broj1 > 0 && broj1 < 100)
        {
            if (broj2 > 0 && broj2 < 100)
            {
                for (int j = 1; j <= broj2; j++)
                {
                    for (int i = 1; i <= broj1; i++)
                    {
                        Console.Write("[" + i + "] ");
                    }
                    Console.WriteLine("");
                }
                break;
            }
        }
        Console.WriteLine("Uneseni broj je veći od 100 ili je manji od 0. Pokušajte ponovo:");
    }

    catch (Exception e)
    {
        Console.WriteLine("Nije unesen cijeli pozitivan broj. Pokušajte ponovo: ");
    }
}