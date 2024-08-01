using System;
using System.Text;

namespace Practice2.Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("челикс кекикс, сколь челиксов вывести на экран (ЦИФРУ БРАТ НАПИШИ): ");

           if (!int.TryParse(Console.ReadLine(), out int input) && input < 1)
            {
                Console.WriteLine("Введите корректное число!");
                return;
            }

            string[] array = new string[input];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Имя нормиса {i + 1}: ");
                array[i] = Console.ReadLine();
            }

            Console.WriteLine("Смари шо накулебасил: ");
            foreach (string name in array)
            {
                Console.WriteLine(name);
            }

        }
    }
}
