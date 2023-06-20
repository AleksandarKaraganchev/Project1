using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Въведи число (а): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Въведи число (b): ");
            int b = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (a < b)
            {
                Console.Write($"Всички нечетни числа в диапазона от |{a}| до |{b}| са: ");
                for (int i = a; i <= b; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            }
            if (b < a)
            {
                Console.Write($"Всички нечетни числа в диапазона от |{a}| до |{b}| са: ");
                for (int i = b; i <= a; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
