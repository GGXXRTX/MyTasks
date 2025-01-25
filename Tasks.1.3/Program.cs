using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свой любимый цвет с маленькой буквы ");
            var Color = Console.ReadLine();
            if (Color == "красный")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Твой цвет Красный! Ура!");

            }
            else if (Color == "зеленый")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Твой цвет зеленый!");

            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Цвет Голубой!!");
            }

            Console.ReadLine();
        }
    }
}
