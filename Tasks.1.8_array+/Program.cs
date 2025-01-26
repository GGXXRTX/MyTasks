using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks._1._8_array_
{
    internal class Program
    {
        static void Main(string[] args)
        {           
                //Создаем массив, дальше идут индексы массива
                int[] number = { 1, 2, 5 };
                //Внешне он выглядит так - int number (который равен 5, но дальше его значение поменяется) = 1 + 2
                number[2] = number[0] + number[1];
                //В итоге вывод будет 3, так как это сумма number[0] и number[1]
                Console.WriteLine(number[2]);

                Console.ReadLine();            
        }
    }
}
