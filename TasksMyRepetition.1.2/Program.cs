using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksMyRepetition._1._2
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string inputString = Console.ReadLine().ToLower(); // Преобразуем в нижний регистр сразу

            int vowelCount = 0;
            int consonantCount = 0;

            string vowels = "aeiou"; // Строка с гласными

            foreach (char c in inputString)
            {
                if (char.IsLetter(c)) // Проверяем, является ли символ буквой
                {
                    if (vowels.Contains(c))
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }

            Console.WriteLine($"Гласные: {vowelCount}");
            Console.WriteLine($"Согласные: {consonantCount}");
            Console.ReadLine();
        }
    }
}
