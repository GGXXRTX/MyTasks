using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                      Console.WriteLine("Введите свой любимый цвет с маленькой буквы! ");
                var color = Console.ReadLine();
                switch (color)
                {
                    case "красный":
                        Console.WriteLine("Ваш любимый цвет красный! ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                    break;                                                                                    а
                    case "синий":

                        Console.WriteLine("Ваш любимый цвет синий! ");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "жёлтый":
                        Console.WriteLine("Ваш любимый цвет жёлтый! ");
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;

                        default:
                        Console.WriteLine("Ой, это какой то другой цвет! Такой я не знаю))) ");
                        break;

                }
                Console.ReadLine();
            }
        }
    }
}
