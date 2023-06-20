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
            //the task with for cicle
            Console.Write("Въведи брой ученици: ");
            int n = int.Parse(Console.ReadLine());
            int excelentGrades = 0;
            int poorGrades = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Въведете успех: ");
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5.50 && grade <= 6)
                {
                    excelentGrades++;
                }
                if (grade < 3 && grade >= 2)
                {
                    poorGrades++;
                }
                if (grade < 2 || grade > 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Error!!!");
                    Console.WriteLine("Wrong input.Please enter numbers between 2 and 6!!!");
                    Console.WriteLine("-------------------------------------------------------");
                    return;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"Броят на учениците със слаба оценка е |{poorGrades}|");
            Console.WriteLine($"Броят на учениците със отлична оценка е |{excelentGrades}|");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
