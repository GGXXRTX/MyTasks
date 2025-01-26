using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks._1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя ");

            string name = Console.ReadLine();
                           //Lenght используется для нахождения индекса в имени, тоесть, Имя Ваня имеет индексы В - 0, А - 1, Н - 2, Я - 3
            for (int i = name.Length - 1; i >= 0; i--)
            {              //И каждый раз индекс будет идти назад, тоесть, этот цикл будет повторятся до тех пор, пока индекс не станет меньше 0
                Console.Write(name[i] );
            }
            
            Console.ReadKey();
        }
    }
}
