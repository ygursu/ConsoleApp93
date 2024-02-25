using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedenkenarlarigirilendikdortgeninalani
{
    class Program
    {
        static void Main(string[] args)
        {

            int kisakenar, uzunkenar, alan;

            Console.WriteLine("Lütfen dikdörtgenin kısa kenarını giriniz");
            kisakenar = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen dikdörtgenin uzun kenarını giriniz");
            uzunkenar = Int32.Parse(Console.ReadLine());

            alan = kisakenar * uzunkenar;

            Console.WriteLine("Dikdörtgenin alanı=" + alan);
            Console.ReadLine();

        }
    }
}