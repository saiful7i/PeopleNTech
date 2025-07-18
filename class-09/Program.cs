using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "aPPle", "BluBeRRy", "BanAna", "CHerrY", "ManGO" };

            var result = from w in words
                         select new { Upper = w.ToUpper(), Lower = w.ToLower(), Original = w };

            foreach (var word in result)
            {
                Console.WriteLine(word.Upper + "\t" + word.Lower + "\t" + word.Original);
            }

            int[] numberA = { 0, 2, 4, 5, 6, 7, 8, 9 };
            int[] numberB = { 1, 3, 5, 7, 8 };

            var pairs =
                from a in numberA
                from b in numberB
                where a < b
                select new { a, b };

            Console.WriteLine("Paires where a<b:");

            foreach (var p in pairs)
            {
                Console.WriteLine(p);
            }

            //=======================
            var pairs2 =
                from a in numberA
                from b in numberB
                where a < b
                select new Box(){ Xvalue=a, Yvalue=b, Text=a.ToString()+":"+b.ToString()};

            Console.WriteLine("Paires where a<b:");

            foreach (var p in pairs2)
            {
                Console.WriteLine(p.Text+"\t");
            }


            //==============================

            int[] numbers = { 0, 1, 2, 3, 4,5, 6, 7,8, 9 };

            var numberGroups =
                from n in numbers
                group n by n % 5 into g
                select new { Remainder = g.Key, Numbers = g };

            foreach (var g in numberGroups)
            {
                Console.WriteLine($"Remainder = {g.Remainder}");
                foreach(var n in g.Numbers)
                {
                    Console.Write($"{n},");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }

    class Box
    {
        public int Xvalue { get; set; }
        public int Yvalue { get; set; }

        public string Text { get; set; }
    }
}
