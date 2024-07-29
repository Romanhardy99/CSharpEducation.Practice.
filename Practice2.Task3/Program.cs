namespace Practice2.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите число для a: ");
                string inputA = Console.ReadLine();
                Console.Write("Введите число для b: ");
                string inputB = Console.ReadLine();
                Console.Write("Введите число для f: ");
                string inputF = Console.ReadLine();


                if (double.TryParse(inputA, out double a) &&
                    double.TryParse(inputB, out double b) &&
                    double.TryParse(inputF, out double f))
                {
                    if (a == 0)
                    {
                        Console.WriteLine("Ошибка: Делить на ноль нельзя!");
                        continue;
                    }
                    else
                    {
                        double result = (a + b - f / a) + f * a * a - (a + b);

                        Console.WriteLine($"Ответ выражения равен {result}");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректные данные");
                }
                break;
            }
            
                

        }
    }
}
