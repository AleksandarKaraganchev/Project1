using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //the task with number of students written by the user
            //Console.Write("Въведи брой ученици: ");
            //int n = int.Parse(Console.ReadLine());
            //int excelentGrades = 0;
            //int poorGrades = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Въведете успех: ");
            //    double grade = double.Parse(Console.ReadLine());
            //    if (grade >= 5.50 && grade <= 6)
            //    {
            //        excelentGrades++;
            //    }
            //    if (grade < 3 && grade >= 2)
            //    {
            //        poorGrades++;
            //    }
            //}
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.WriteLine("-----------------------------------------------------------------------");
            //Console.WriteLine($"Броят на учениците със слаба оценка е |{poorGrades}|");
            //Console.WriteLine($"Броят на учениците със отлична оценка е |{excelentGrades}|");
            //Console.WriteLine("-----------------------------------------------------------------------");
            //Console.WriteLine();

            //the task with the actual people in our group
            Console.Write("Въведи успеха на учениците от втора група по програмиране разделени със (space): ");
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int poorGrades = arr.Count(num => num < 3 && num >= 2);
            int excelentGrades = arr.Count(num => num >= 5.50 && num <= 6);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"Броят на учениците със слаб успех е |{poorGrades}|");
            Console.WriteLine($"Броят на учениците със отличен успех е |{excelentGrades}|");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
