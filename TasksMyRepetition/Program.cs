using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksMyRepetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
            Console.Write("Введите число, а мы определим, чётное оно, или нет) = ");
            string NumberRepetition = Console.ReadLine();
            if (int.TryParse(NumberRepetition, out int NumberCheck))
            {
                int Check = NumberCheck % 2;
                if (Check == 0)
                {
                    Console.WriteLine("Число Чётное");
                }

                else
                {
                    Console.WriteLine("Число НеЧётное");
                }
            }
            else
            {
                Console.WriteLine("Введено неверное значение! Будьте добры, повторите запрос! ");
            }
            Console.ReadLine();
                Console.Clear();    
        }
        }
    }
}
