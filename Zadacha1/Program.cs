using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Въведете числа разделени със (space): ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Reverse(arr);
            //logic number 1
            //int min = int.MinValue;
            //int max = int.MaxValue;
            //foreach (var item in array)
            //{
            //    if (item < min)
            //    {
            //        min = item;
            //    }
            //    if (item > max)
            //    {
            //        max = item;
            //    }
            //}
            //logic number 2
            int min = arr.Min();
            int max = arr.Max();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Числата от масива в обърнат ред: ");
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine($"Минимален Елемент: {min}");
            Console.WriteLine($"Максимален Елемент: {max}");
        }
    }
}
