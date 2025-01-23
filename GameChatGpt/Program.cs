using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChatGpt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Переменные состояния игрыlll
            int playerPosition = 0;
            bool isGameOver = false;

            // Основной игровой цикл
            while (!isGameOver)
            {
                // Показать текущее состояние игры
                Console.WriteLine($"Ваша позиция: {playerPosition}");

                // Получить ввод игрока
                string input = Console.ReadLine();

                // Обновить состояние игры на основе ввода
                switch (input)
                {
                    case "w":
                        playerPosition++;
                        break;
                    case "s":
                        playerPosition--;
                        break;
                    case "q":
                        isGameOver = true;
                        break;
                }
                Console.Clear();
            }

            // Вывести сообщение об окончании игры
            Console.WriteLine("Игра окончена!");
        }
    }
}
