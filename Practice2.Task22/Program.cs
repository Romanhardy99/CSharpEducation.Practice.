namespace Practice2.Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);

            ColorMethod("Угадай число ", ConsoleColor.Red);

            ColorMethod("Игра будет загадывать число от 1 до 100, \nвам необходимо угадать это число...", ConsoleColor.Green);

            Random random = new Random();

            int randomNumber = random.Next(1, 101);

            int chislo = 0;

            int temp = 7;

            Console.WriteLine($"Напрягите розочку, у вас {temp} попыток!");

            while (chislo != randomNumber && temp > 0)
            {
                Console.Write("Введите число: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out chislo))
                {
                    if (chislo < randomNumber)
                    {
                        ColorMethod("Ваше число меньше загаданного!", ConsoleColor.Yellow);
                        Console.WriteLine($"У вас осталось {temp} попыток");
                    }
                    else if (chislo > randomNumber)
                    {
                        ColorMethod("Ваше число больше загаданного!", ConsoleColor.Yellow);
                        Console.WriteLine($"У вас осталось {temp} попыток");
                    }
                    else
                    {
                        ColorMethod("Вы угадали!", ConsoleColor.Yellow);
                    }
                    temp--;
                    
                }
                else
                {
                    ColorMethod("Введите корректное число!", ConsoleColor.Yellow);
                }

                if (temp == 0)
                {
                    Console.WriteLine("Попытки закончились!");
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

