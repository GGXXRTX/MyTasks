using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TasksMyRepetition._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Няшка, введи свое только положительное число позязя :) = ");
            string NumberFirst = Console.ReadLine();

            if (long.TryParse(NumberFirst, out long NumberTwo))
            {
                if (NumberTwo > 0)
                {
                    long factorial = 1;
                    for (long i = 1; i <= NumberTwo; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"Факториал {NumberTwo} равен: {factorial}");
                }
                else
                {
                    Console.WriteLine("Ах ты! Это отрицательное число! Незя!");
                }
            }
            else
            {
                Console.WriteLine("Няшка, это не число :(");
            }
            Console.Read();

        }
    }
}
