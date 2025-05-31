using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TypicalGospStratGame.Stastystyki;

namespace TypicalGospStratGame.Mechaniki
{
    public static class Gospodarka
    {
        static public int zysk;
        static string[] test = {"test","gosp"};

        public static void Kupno()
        {
            if(ParametryGracza.Waluta >= 100)
            {
                ParametryGracza.Waluta = ParametryGracza.Waluta - 100;
                ParametryGracza.Gospodarstwa++;
                Kom.Kupiono();
                Thread.Sleep(1000);
                Program.Main(test);
            }
            else if(ParametryGracza.Waluta < 100)
            {
                Kom.Zamalo();
                Program.Main(test);
            }
        }
        public static void Czynsz()
        {
            zysk = ParametryGracza.Gospodarstwa * 10;
            ParametryGracza.Waluta = ParametryGracza.Waluta + zysk;
            Kom.Skryba(zysk);
            zysk = 0;
        }
    }
}
