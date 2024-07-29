namespace Practice2.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите первое число: ");
            int number1;

            while (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.Write("Введите корректное число!");
            }

            Console.Write("Введите второе число: ");
            int number2;

            while (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.Write("Введите корректное число!");
            }

            if (number1 > number2)
            {
                Console.WriteLine($"Число {number1} больше числа {number2}");
            }
            else if (number1 < number2)
            {
                Console.WriteLine($"Число {number2} больше числа {number1}");
            }
            else
            {
                Console.WriteLine($"Числа равны");
            }


        }
    }
}
