using System;

class Rycerz
{
    public string Imie { get; set; }
    public int Sila { get; set; }
    public int Zrecznosc { get; set; }
    public int IQ { get; set; }

    public Rycerz(string imie, int sila, int zrecznosc, int iq)
    {
        Imie = imie;
        Sila = sila;
        Zrecznosc = zrecznosc;
        IQ = iq;
    }
}

class Program
{
    static void Main()
    {
        Random rand = new Random();

        Rycerz[] rycerze = {
            new Rycerz("Artur", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Lancelot", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Gawain", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Tristan", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Percival", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Bors", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Galahad", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Bedivere", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100))
        };

        for (int i = 0; i < rycerze.Length; i++)
        {
            int losowaPozycja = rand.Next(rycerze.Length);
            Rycerz temp = rycerze[i];
            rycerze[i] = rycerze[losowaPozycja];
            rycerze[losowaPozycja] = temp;
        }

        Console.WriteLine("=== Turniej Rycerski ===\n");

        for (int i = 0; i < rycerze.Length; i += 2)
        {
            if (i + 1 >= rycerze.Length)
            {
                Console.WriteLine($"{rycerze[i].Imie} nie ma przeciwnika, przechodzi do następnej rundy!\n");
                continue;
            }

            Rycerz r1 = rycerze[i];
            Rycerz r2 = rycerze[i + 1];

            int statystyka = rand.Next(3);
            string nazwaStatystyki = statystyka == 0 ? "Siła" : statystyka == 1 ? "Zręczność" : "IQ";

            int wartoscR1 = statystyka == 0 ? r1.Sila : statystyka == 1 ? r1.Zrecznosc : r1.IQ;
            int wartoscR2 = statystyka == 0 ? r2.Sila : statystyka == 1 ? r2.Zrecznosc : r2.IQ;

            Console.WriteLine($"Pojedynek: {r1.Imie} vs {r2.Imie}");
            Console.WriteLine($"Wylosowana statystyka: {nazwaStatystyki}");
            Console.WriteLine($"{r1.Imie}: {wartoscR1} vs {r2.Imie}: {wartoscR2}");

            if (wartoscR1 > wartoscR2)
            {
                Console.WriteLine($"Zwycięzca: {r1.Imie}!\n");
            }
            else if (wartoscR2 > wartoscR1)
            {
                Console.WriteLine($"Zwycięzca: {r2.Imie}!\n");
            }
            else
            {
                Console.WriteLine("Remis! Dogrywka nie przewidziana, obaj odpadają!\n");
            }
        }

        Console.WriteLine("=== Koniec rundy! ===");
        Console.ReadLine();
    }
}