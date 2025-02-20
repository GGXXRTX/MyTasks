using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TasksMyRepetition._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true) 
              {
                double NumberOne, NumberTwo, NumberThree;
                string Choice;
                Console.WriteLine("Выберите способ вычисления: ");
                Console.WriteLine("/ * + - :");
                Choice = Console.ReadLine();
                Console.WriteLine("Укажите числа! Число 1: ");
                NumberOne = double.Parse(Console.ReadLine());
                Console.WriteLine("Укажите числа! Число 2: ");
                NumberTwo = double.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case "/":
                        NumberThree = NumberOne / NumberTwo;
                        Console.WriteLine("Ваш ответ = {0} ", NumberThree);
                        break;
                    case "*":
                        NumberThree = NumberOne * NumberTwo;
                        Console.WriteLine("Ваш ответ = {0} ", NumberThree);
                        break;
                    case "+":
                        NumberThree = NumberOne + NumberTwo;
                        Console.WriteLine("Ваш ответ = {0} ", NumberThree);
                        break;
                    case "-":
                        NumberThree = NumberOne - NumberTwo;
                        Console.WriteLine("Ваш ответ = {0} ", NumberThree);
                        break;
                    default:
                        Console.WriteLine("Значение не верно, повторите! ");
                        break;
                }
                Console.Read();
                Console.Clear();
            }


        }
    }
}
