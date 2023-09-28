using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2._2
{
    class Program
    {
        static void Main()
        {
            // Створюємо матрицю розміром 3x3
            int[,] matrix = new int[3, 3];

            // Запитуємо користувача ввести значення елементів матриці
            Console.WriteLine("Введіть значення елементів матриці:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Елемент [{i + 1},{j + 1}]: ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        Console.WriteLine("Неправильний формат числа. Будь ласка, спробуйте ще раз.");
                        j--; // Повторити введення для цього елемента
                    }
                }
            }

            // Знаходимо суму елементів головної діагоналі
            int diagonalSum = 0;
            for (int i = 0; i < 3; i++)
            {
                diagonalSum += matrix[i, i];
            }

            // Виводимо результат
            Console.WriteLine($"Сума елементів головної діагоналі: {diagonalSum}");
        }
    }
}
