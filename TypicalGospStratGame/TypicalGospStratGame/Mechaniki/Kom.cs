using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypicalGospStratGame.Stastystyki;

namespace TypicalGospStratGame.Mechaniki
{
    public static class Kom
    {
        public static void Kupiono()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(">------------------------------<");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pomyslnie zakupiono Gospodarstwo");
            Console.Write("Aktualnie posiadasz:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ParametryGracza.Gospodarstwa);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Zamalo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(">------------------------------<");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Za malo złota mój panie");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Skryba(int zysk)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(">------------------------------<");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Zysk z gospodartst w tym roku wynosi:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(zysk);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Stan skarbca wynosi:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ParametryGracza.Waluta);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
