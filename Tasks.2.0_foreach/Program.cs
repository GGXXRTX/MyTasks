using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks._2._0_foreach
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Пример массива чисел
            int[] numbers = { 10, 20, 30, 40, 50 };

            double sum = 0; //sum нужен для того, что бы делать сложение с массивами данных
            int count = 0;         //count нужен для того, что бы понять, пуст ли массив, или нет, если он равен 0, то последует else 

            foreach (int number in numbers)   //ВАЖНОЕ ПРИМЕЧАНИЕ!!! КОД БЫЛ НАПИСАН CHATGPT!!!
            {
                sum += number;      //здесь в sum мы суем все сложение массива
                count++;             //смотрим, есть ли массив данных, если да, то count + 1 по инкременту
            }

            if (count > 0)  //проверяем, не пустой ли массив
            {
                double average = sum / count;      // ищем среднее значение, деля на переменную count, которая записала, сколько всего чисел было
                Console.WriteLine($"Среднее значение: {average}");
            }
            else
            {
                Console.WriteLine("Массив пуст.");
            }
        }
    }
}
