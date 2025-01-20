using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name, Year;
            Console.Write("Введи свое имя: ");
            Name = Console.ReadLine();
            Console.Write("Введи, сколько тебе лет: ");
            Year = Console.ReadLine();
            Console.WriteLine("Твое имя {0}, твой возраст {1} ", Name, Year);
            Console.Write("Какой твой любимый день недели? Укажи число от 1 до 7: ");
            WeekDays WeekDay = (WeekDays) byte.Parse(Console.ReadLine());
            Console.WriteLine("Твой любимый день недели: {0} ", WeekDay);
            Console.ReadLine();
        }
        enum WeekDays : byte
        { 
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

    }
}
