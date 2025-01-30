using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tasks._1._9_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] number = new string[10];
            int[] number3 = new int[10];
            Console.WriteLine("Введите 10 чисел, с которых будем искать среднее значение: ");

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"{i} число");
                number[i] = Console.ReadLine();
                if (int.TryParse(number[i], out int number2))
                {       
                    number3[i] = number2;
                }                                                                                                                                    
                else
                {
                    Console.WriteLine("Не число! ");
                }
            }
            int number4 = (number3[0] + number3[1] + number3[2] + number3[3] + number3[4] + number3[5] + number3[6] + number3[7] + number3[8] + number3[9])/10;
            Console.WriteLine("Среднее число = {0} ", number4);
            Console.ReadLine(); 

        }
    }
}
