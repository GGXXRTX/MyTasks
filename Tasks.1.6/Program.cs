using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tasks._1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
           
            while (i < n)
            {
                // Отступы для выравнивания пирамиды, для одной строки
                int j = 0;
                while (j < n - i - 1)
                {
                    Console.Write(" ");
                    j++;
                }

                // Звездочки в текущей строке
                j = 0;
                while (j < 2 * i + 1)
                {
                    Console.Write("*");
                    j++;
                }
                // Переход на новую строку
                Console.WriteLine();
                i++;        
        }
    }


    }
}
