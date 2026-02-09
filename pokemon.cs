using System;
using System.Collections.Generic;

namespace LegoPokemonApp
{
    public enum Rodzaj
    {
        Ognisty,
        Wodny,
        Trawiasty,
        Elektryczny,
        Psychiczny,
        Normalny
    }

    public class ZestawPokemon
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public Rodzaj Rodzaj { get; set; }
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }

        public ZestawPokemon(int id, string nazwa, Rodzaj rodzaj, string skill1, string skill2)
        {
            ID = id;
            Nazwa = nazwa;
            Rodzaj = rodzaj;
            Skill1 = skill1;
            Skill2 = skill2;
        }

        public override string ToString()
        {
            return $"[ID: {ID}] Nazwa: {Nazwa.PadRight(10)} | Typ: {Rodzaj.ToString().PadRight(12)} | Skille: {Skill1}, {Skill2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<ZestawPokemon> listaPokemonow = new List<ZestawPokemon>()
            {
                new ZestawPokemon(1, "Bulbasaur", Rodzaj.Trawiasty, "Overgrow", "Chlorophyll"),
                new ZestawPokemon(4, "Charmander", Rodzaj.Ognisty, "Blaze", "Solar Power"),
                new ZestawPokemon(7, "Squirtle", Rodzaj.Wodny, "Torrent", "Rain Dish")
            };

            bool programDziala = true;

            while (programDziala)
            {
                Console.Clear();
                Console.WriteLine("[>-_+<] LEGO POKEMON MANAGER [>+_-<]");
                Console.WriteLine("lista:");
                foreach (var p in listaPokemonow)
                {
                    Console.WriteLine(p.ToString());
                }

                Console.WriteLine("\nMENU:");
                Console.WriteLine("1 - Dopisz nowego Pokemona do menu jedzenia");
                Console.WriteLine("0 - Wyjdź");
                Console.Write("\nWybierz opcję: ");

                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        DodajNowegoPokemona(listaPokemonow);
                        break;
                    case "0":
                        programDziala = false;
                        Console.WriteLine("Zamykanie... o ...");
                        break;
                    default:
                        Console.WriteLine("Błąd == klawisz");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void DodajNowegoPokemona(List<ZestawPokemon> lista)
        {
            Console.Clear();
            Console.WriteLine("[>-_+<] DODAWANIE NOWEGO ZESTAWU [>+_-<]");

            try
            {
                Console.Write("Podaj ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Podaj nazwę Pokemona: ");
                string nazwa = Console.ReadLine();

                Console.WriteLine("Wybierz rodzaj:");
                string[] rodzaje = Enum.GetNames(typeof(Rodzaj));
                for (int i = 0; i < rodzaje.Length; i++)
                {
                    Console.WriteLine($"{i} - {rodzaje[i]}");
                }
                int rodzajIndex = int.Parse(Console.ReadLine());
                Rodzaj wybranyRodzaj = (Rodzaj)rodzajIndex;

                Console.Write("skill 1: ");
                string s1 = Console.ReadLine();

                Console.Write("skill 2: ");
                string s2 = Console.ReadLine();

                lista.Add(new ZestawPokemon(id, nazwa, wybranyRodzaj, s1, s2));
                Console.WriteLine("\nPokemon dodany pomyślnie!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas dodawania: {ex.Message}");
                Console.WriteLine("spradź ponownie");
            }
            Console.ReadKey();
        }
    }
}