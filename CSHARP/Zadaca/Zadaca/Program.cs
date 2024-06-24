// See https://aka.ms/new-console-template for more information




Console.WriteLine("Unesite 2 broja za stvaranje tablice: ");


int broj1 = int.Parse(Console.ReadLine());
int broj2 = int.Parse(Console.ReadLine());



for (int j = 1; j <= broj2; j++)
{
    for (int i = 1; i <= broj1; i++)
    {
        Console.Write("[" + i + "] ");
    }
    Console.WriteLine("");
}
