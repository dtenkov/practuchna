using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._3
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int secretNumber = random.Next(0, 11); // Комп'ютер загадує число від 0 до 10

            Console.WriteLine("Ласкаво просимо до гри 'Вгадай число'!");
            Console.WriteLine("Комп'ютер загадав число від 0 до 10. Спробуйте вгадати.");

            int attempts = 0;
            bool guessed = false;

            while (!guessed)
            {
                Console.Write("Введіть вашу спробу: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int userGuess))
                {
                    if (userGuess < 0 || userGuess > 10)
                    {
                        Console.WriteLine("Будь ласка, введіть число від 0 до 10.");
                    }
                    else
                    {
                        attempts++;

                        if (userGuess == secretNumber)
                        {
                            guessed = true;
                            Console.WriteLine($"Вітаємо! Ви вгадали число {secretNumber} за {attempts} спроб.");
                        }
                        else if (userGuess < secretNumber)
                        {
                            Console.WriteLine("Загадане число більше.");
                        }
                        else
                        {
                            Console.WriteLine("Загадане число менше.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Неправильний формат введення. Будь ласка, введіть ціле число від 0 до 10.");
                }
            }
        }
    }
}
