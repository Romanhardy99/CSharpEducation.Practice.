using System.Drawing;

namespace Practice2.Task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
                        
            ColorMethod("Игра Угадай число ", ConsoleColor.Green);

            ColorMethod("Игра будет загадывать число от 1 до 100, вам необходимо угадать это число...", ConsoleColor.Blue);

            Random random = new Random();

            int randomNumber = random.Next(1, 101);

            int chislo = 0;

            while (chislo != randomNumber)
            {
                Console.Write("Введите число: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out chislo))
                {
                    if (chislo < randomNumber)
                    {
                        ColorMethod("Ваше число меньше загаданного!", ConsoleColor.Yellow);
                    }
                    else if (chislo > randomNumber)
                    {
                        ColorMethod("Ваше число больше загаданного!", ConsoleColor.Yellow);
                    }
                    else
                    {
                        ColorMethod("Вы угадали!", ConsoleColor.Yellow);
                    }
                }
                else 
                {
                    ColorMethod("Введите корректное число!", ConsoleColor.Yellow);
                }
            }
        }

        static void ColorMethod(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
