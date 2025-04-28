using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=== MENU APLIKACJI ===");
            Console.WriteLine("1. Wyświetl komunikat");
            Console.WriteLine("2. Oblicz prostokąt");
            Console.WriteLine("3. Wyświetl powtarzanie się słów");
            Console.WriteLine("0. Wyjście");
            Console.Write("Wybierz opcję: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowThanksMessage();
                    break;
                case "2":
                    RectangleCalculator();
                    break;
                case "3":
                    LoopExpression();
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie lub poczekaj minute a sam się rozwiąże problem.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu...");
                Console.ReadKey();
            }
        }
    }

    static void ShowThanksMessage()
    {
        Console.WriteLine("\nDziękuję za odpowiedź!");
    }

    static void RectangleCalculator()
    {
        Console.Write("\nPodaj długość prostokąta: ");
        double length = GetPositiveDouble();
        Console.Write("Podaj szerokość prostokąta: ");
        double width = GetPositiveDouble();

        double area = CalculateArea(length, width);
        double perimeter = CalculatePerimeter(length, width);

        Console.WriteLine($"\nPole prostokąta: {area}");
        Console.WriteLine($"Obwód prostokąta: {perimeter}");
    }

    static double GetPositiveDouble()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double result) && result > 0)
                return result;
            else
                Console.Write("Błędna wartość! Podaj liczbę dodatnią: ");
        }
    }

    static double CalculateArea(double length, double width)
    {
        return length * width;
    }

    static double CalculatePerimeter(double length, double width)
    {
        return 2 * (length + width);
    }

    static void LoopExpression()
    {
        Console.WriteLine();
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine($"{i}: Sword Art Online 🎮");
            else
                Console.WriteLine($"{i}: Sword Art Online 🗡️");
        }
    }
}
