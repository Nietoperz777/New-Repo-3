using System;

class Program
{
    static void Main()
    {
        string[] rycerze = { "Artur", "Lancelot", "Gawain", "Tristan", "Percival", "Bors", "Galahad", "Bedivere" };

        Random rand = new Random();

        for (int i = 0; i < rycerze.Length; i++)
        {
            int losowaPozycja = rand.Next(rycerze.Length);
            string temp = rycerze[i];
            rycerze[i] = rycerze[losowaPozycja];
            rycerze[losowaPozycja] = temp;
        }

        Console.WriteLine("Wylosowane pojedynki rycerskie:");
        for (int i = 0; i < rycerze.Length; i += 2)
        {
            if (i + 1 < rycerze.Length)
            {
                Console.WriteLine($"{rycerze[i]} vs {rycerze[i + 1]}");
            }
            else
            {
                Console.WriteLine($"{rycerze[i]} nie ma przeciwnika, przechodzi do następnej rundy.");
            }
        }

        Console.ReadLine();
    }
}