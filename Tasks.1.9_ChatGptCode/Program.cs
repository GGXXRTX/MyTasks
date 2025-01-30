using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks._1._9_ChatGptCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 10 чисел, с которых будем искать среднее значение: ");

            int[] numbers = new int[10];
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i + 1} число:");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    numbers[i] = number;
                    count++;
                }
                else
                {
                    Console.WriteLine("Не число! Попробуйте ещё раз.");
                    i--; // Повторяем ввод для текущего индекса
                }
            }

            double average = count > 0 ? numbers.Average() : 0; // Избегаем деления на ноль

            Console.WriteLine($"Среднее число = {average}");
            Console.ReadLine();

        }
    }
}
