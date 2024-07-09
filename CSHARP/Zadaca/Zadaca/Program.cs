using System;


Console.WriteLine("Unesite 2 broja za stvaranje tablice: ");

while (true)
{
    try
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        if (n > 0 && n < 100)
        {
            if (m > 0 && m < 100)
            {
                int[,] matrix = new int[n, m];

                int value = 1;

                int minRow = 0, maxRow = n - 1;
                int minCol = 0, maxCol = m - 1;

                while (value <= n * m)
                {
                    for (int i = maxCol; i >= minCol && value <= n * m; i--)
                    {
                        matrix[maxRow, i] = value++;
                    }
                    maxRow--;

                    for (int i = maxRow; i >= minRow && value <= n * m; i--)
                    {
                        matrix[i, minCol] = value++;
                    }
                    minCol++;

                    for (int i = minCol; i <= maxCol && value <= n * m; i++)
                    {
                        matrix[minRow, i] = value++;
                    }
                    minRow++;

                    for (int i = minRow; i <= maxRow && value <= n * m; i++)
                    {
                        matrix[i, maxCol] = value++;
                    }
                    maxCol--;
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {

                        Console.Write("[ " + matrix[i, j] + " ] ");
                    }
                    Console.WriteLine();
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