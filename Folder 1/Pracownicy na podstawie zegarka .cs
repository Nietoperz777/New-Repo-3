using System;

class Kura
{
    public string Egg { get; set; }
    public string JajkoSlone { get; set; }
    public string Jajkoslodkie { get; set; }
    public string KolorJajka { get; set; }
    public double CenaJajka { get; set; }
    public bool Wodoodporny_Egg { get; set; }
    public double SrednicaWtrzymalosciJajka { get; set; }
    public string MaterialKinderJajek { get; set; }

    public Kura(string egg, string jajkoslone, string jajkoslodkie, string kolorjajka, double cenajajka, bool wodoodporny, double srednicaJajka, string materialkinderjajek)
    {
        Egg = egg;
        JajkoSlone = jajkoslone;
        Jajkoslodkie = jajkoslodkie;
        KolorJajka = kolorjajka;
        CenaJajka = cenajajka;
        Wodoodporny_Egg = wodoodporny;
        SrednicaWtrzymalosciJajka = srednicaJajka;
        MaterialKinderJajek = materialkinderjajek;
    }

    public void PokazInformacje()
    {
        Console.WriteLine($"Zegarek: {Egg} {JajkoSlone}, Typ: {Jajkoslodkie}, Kolor: {KolorJajka}, Cena: {CenaJajka} zł");
    }

    public void Zmiana(string nowyMaterial)
    {
        MaterialKinderJajek = nowyMaterial;
        Console.WriteLine($"Zmieniono na: {MaterialKinderJajek}");
    }

    public void SprawdzWodoodpornosc()
    {
        if (Wodoodporny_Egg)
            Console.WriteLine("To Jajko jest wodoodporne.");
        else
            Console.WriteLine("To Jajko nie jest wodoodporne.");
    }
}

class Program
{
    static void Main()
    {
        Kura Kura1 = new Kura("Egg", "Salt", "Sugar", "LightGreen", 147.93, true, 30.7, "KinderChocolate");

        Kura1.PokazInformacje();
        Kura1.SprawdzWodoodpornosc();
        Kura1.Zmiana("GoodJob");
    }
}
