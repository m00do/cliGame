using System;
using System.Threading;
using TypicalGospStratGame.Mechaniki;

namespace TypicalGospStratGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int wybur;

            while (true)
            {
                Console.WriteLine("\nWybierz akcję:");
                Console.WriteLine("1 - Kupno");
                Console.WriteLine("0 - Wyjście");

                if (!int.TryParse(Console.ReadLine(), out wybur))
                {
                    Console.WriteLine("Błąd: Wprowadź poprawną liczbę.");
                    continue;
                }

                if (wybur == 0)
                {
                    break;
                }

                switch (wybur)
                {
                    case 1:
                        Gospodarka.Kupno();
                        break;
                    default:
                        Console.WriteLine("Nieznana opcja.");
                        break;
                }
                Gospodarka.Czynsz();
            }
        }
    }
}
