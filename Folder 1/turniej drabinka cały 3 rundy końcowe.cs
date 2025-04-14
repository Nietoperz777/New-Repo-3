using System;
using System.Collections.Generic;

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

    public override string ToString()
    {
        return $"{Imie} (Siła: {Sila}, Zręczność: {Zrecznosc}, IQ: {IQ})";
    }
}

class Program
{
    static Random rand = new Random();

    static void Main()
    {
        List<Rycerz> rycerze = new List<Rycerz>
        {
            new Rycerz("Artur", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Lancelot", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Gawain", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Tristan", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Percival", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Bors", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Galahad", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Bedivere", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("No", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Yes", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Albert", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("OK", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Pinguin", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Mine", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Pencilgon", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
            new Rycerz("Sunraku", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
             new Rycerz("Sunraku2", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
              new Rycerz("Sunraku3", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
              new Rycerz("Sunraku4", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
              new Rycerz("Sunraku5", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
              new Rycerz("Sunraku6", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100)),
              new Rycerz("Sunraku7", rand.Next(50, 100), rand.Next(50, 100), rand.Next(50, 100))

        };

        Console.WriteLine("=== TURNIEJ RYCERSKI ROZPOCZĘTY! ===\n");

        int runda = 1;

        while (rycerze.Count > 3)
        {
            Console.WriteLine($"--- Runda {runda} ---\n");

            TasujListe(rycerze);
            List<Rycerz> zwyciezcy = new List<Rycerz>();

            for (int i = 0; i < rycerze.Count; i += 2)
            {
                if (i + 1 >= rycerze.Count)
                {
                    Console.WriteLine($"{rycerze[i].Imie} nie ma przeciwnika, przechodzi do następnej rundy!\n");
                    zwyciezcy.Add(rycerze[i]);
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
                    zwyciezcy.Add(r1);
                }
                else if (wartoscR2 > wartoscR1)
                {
                    Console.WriteLine($"Zwycięzca: {r2.Imie}!\n");
                    zwyciezcy.Add(r2);
                }
                else
                {
                    Console.WriteLine("Remis! Obaj odpadają!\n");
                }
            }

            rycerze = zwyciezcy;
            runda++;
        }

        if (rycerze.Count == 1)
        {
            Console.WriteLine($"🏆 Zwycięzca turnieju to: {rycerze[0].Imie}!");
        }
        else
        {
            Console.WriteLine("Brak zwycięzcy, wszyscy odpadli w remisach!");
        }

        Console.WriteLine("\n=== KONIEC TURNIEJU ===");
        Console.ReadLine();
    }

    static void TasujListe(List<Rycerz> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            int losowaPozycja = rand.Next(lista.Count);
            Rycerz temp = lista[i];
            lista[i] = lista[losowaPozycja];
            lista[losowaPozycja] = temp;
        }
    }
}