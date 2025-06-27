using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            int c = 20;

            Console.WriteLine($"Sum :   a+b+c = {a + b + c}");
            Console.WriteLine($"Subtraction : c-a-b = {c-a-b}");
            Console.WriteLine($"Multiplication : a*b*c = {a * b * c}");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int i = 0; i < 100; i+=5)
            {
                Console.WriteLine($"value i = {i}");
            }
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine($"value i = {i}");
            }

            for (int i = 100; i >= 1; i -= 5)
            {
                Console.WriteLine($"value i = {i}");
            }
            Console.ReadKey();

            Console.Write("Please enter value of a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter value of c: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sum :   a+b+c = {a + b + c}");
            Console.WriteLine($"Subtraction : c-a-b = {c - a - b}");
            Console.WriteLine($"Multiplication : a*b*c = {a * b * c}");


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"a > b : {a>b}");
            Console.WriteLine($"a < b : {a<b}");
            Console.WriteLine($"a == b : {a==b}");
            Console.WriteLine($"a >= b : {a>=b}");
            Console.WriteLine($"a <= b : {a<=b}");
            Console.WriteLine($"a != b : {a!=b}");


            Console.ReadKey();

        }
    }
}
