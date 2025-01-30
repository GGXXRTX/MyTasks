using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodotName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = 1, c = 1, d = 2;
            a -= 1;    
            b += 1;
            c /= 2;
            d *= 2; 
            Console.WriteLine("Вывод переменной а = {0} \nВывод переменной b = {1} \nВывод переменной c = {2} \nВывод переменной d = {3} ", a, b, c, d);
            Console.ReadLine();
        }
    }
}
