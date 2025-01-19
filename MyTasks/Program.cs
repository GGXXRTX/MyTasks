using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name, Year, Pet, ShoueSize;
            byte PetChoice;
            Console.WriteLine("Сейчас будем проводить тестирование! Будьте добры, следуйте указаниям! ");
            Console.WriteLine("Какое у вас Имя? ");
            Name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет? ");
            Year = Console.ReadLine();
            Console.WriteLine("Какой у вас размер ноги? ");
            ShoueSize = Console.ReadLine();
            Console.WriteLine("Есть ли у вас питомец? ");
            Console.WriteLine("Выберите 1, если да, любое другое число если нет! ");
            PetChoice = byte.Parse(Console.ReadLine());
            if (PetChoice == 1)
            {
                Console.WriteLine("Как хорошо, что у вас есть питомец! Его имя? ");
                Pet = Console.ReadLine();
                Console.WriteLine("Что же, мы получили такие данные!: " + "\nИмя - " + Name + "\nВаш возраст - " + Year + "\nИмя питомца- " + Pet + "\nРазмер вашей ноги - " + ShoueSize);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ничего страшного, что у вас нет питомца");
                Console.WriteLine("Что же, мы получили такие данные!: " + "\nИмя - " + Name + "\nВаш возраст - " + Year + "\nРазмер вашей ноги - " + ShoueSize);
                Console.ReadLine();
            }
            
        }
    }
}
