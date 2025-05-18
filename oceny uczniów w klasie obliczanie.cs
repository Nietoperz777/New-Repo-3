using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[,] oceny = new int[4, 8]
        {
            { 4, 5, 3, 4, 2, 5, 3, 4 }, // Uczeń 1 - Arthur
            { 3, 3, 4, 2, 3, 3, 4, 3 }, // Uczeń 2 - Cole
            { 5, 4, 5, 5, 4, 5, 4, 5 }, // Uczeń 3 - Zane
            { 2, 3, 2, 2, 3, 2, 3, 2 }  // Uczeń 4 - Sylphia
        };

        List<int> wszystkieOceny = new List<int>();

        //podsumowanie wszystkich ocen
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 8; j++)
                wszystkieOceny.Add(oceny[i, j]);

        //średnia
        double srednia = wszystkieOceny.Average();

        //mediana
        var posortowane = wszystkieOceny.OrderBy(x => x).ToList();
        double mediana = (posortowane.Count % 2 == 0) ?
            (posortowane[posortowane.Count / 2 - 1] + posortowane[posortowane.Count / 2]) / 2.0
            : posortowane[posortowane.Count / 2];

        //dominanta
        var grupa = wszystkieOceny.GroupBy(x => x)
                                  .OrderByDescending(g => g.Count())
                                  .First();
        int dominanta = grupa.Key;

        Console.WriteLine("Średnia ocen: " + srednia);
        Console.WriteLine("Mediana ocen: " + mediana);
        Console.WriteLine("Dominanta ocen: " + dominanta);
        Console.WriteLine();

        Console.WriteLine("Wykres kolumnowy:");
        var grupy = wszystkieOceny.GroupBy(x => x).OrderBy(g => g.Key);
        foreach (var g in grupy)
        {
            Console.Write($"{g.Key}: ");
            for (int i = 0; i < g.Count(); i++)
                Console.Write("█");
            Console.WriteLine($" ({g.Count()})");
        }
    }
}
