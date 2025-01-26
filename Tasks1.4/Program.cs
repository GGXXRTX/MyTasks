using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tasks1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            do
            {
                Console.WriteLine("Это предложение должно воспроизвестись 3 раза! ");
                a++;

            }
            while (a < 3);
            Console.Read();
        }
    }
}
