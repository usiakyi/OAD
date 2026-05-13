using System;

namespace Rabaty
{
    interface IRabat
    {
        double Oblicz(double kwota);
    }
    class BrakRabatu : IRabat
    {
        public double Oblicz(double kwota)
        {
            return kwota;
        }
    }
    class RabatProcentowy : IRabat
    {
        public double Oblicz(double kwota)
        {
            return kwota * 0.9;
        }
    }
    class RabatStaly : IRabat
    {
        public double Oblicz(double kwota)
        {
            double wynik = kwota - 20;

            if (wynik < 0)
            {
                return 0;
            }

            return wynik;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double cena = PobierzCene();

            WyswietlMenu();

            int wybor = PobierzWybor();

            IRabat rabat = WybierzRabat(wybor);

            double nowaCena = rabat.Oblicz(cena);

            WyswietlWynik(nowaCena);
        }
        static double PobierzCene()
        {
            Console.Write("Podaj cenę produktu: ");
            return Convert.ToDouble(Console.ReadLine());
        }
        static void WyswietlMenu()
        {
            Console.WriteLine("\nWybierz rodzaj rabatu:");
            Console.WriteLine("1 - Brak rabatu");
            Console.WriteLine("2 - Rabat 10%");
            Console.WriteLine("3 - Rabat 20 zł");
        }
        static int PobierzWybor()
        {
            Console.Write("Twój wybór: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static IRabat WybierzRabat(int wybor)
        {
            switch (wybor)
            {
                case 1:
                    return new BrakRabatu();

                case 2:
                    return new RabatProcentowy();

                case 3:
                    return new RabatStaly();

                default:
                    Console.WriteLine("Niepoprawny wybór.");
                    return new BrakRabatu();
            }
        }
        static void WyswietlWynik(double cena)
        {
            Console.WriteLine($"\nCena po rabacie: {cena} zł");
        }
    }
}