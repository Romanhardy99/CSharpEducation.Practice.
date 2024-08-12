namespace Ptactice2.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 переменные: ");

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();

            double number1, number2, number3;

            bool value1 = double.TryParse(input1, out number1);
            bool value2 = double.TryParse(input2, out number2);
            bool value3 = double.TryParse(input3, out number3);


            if (!value1 && !value2 && !value3)
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            
            if (number1 == number2 || number1 == number3 || number2 == number3)
            {
                number1 += 5;
                number2 += 5;
                number3 += 5;

                Console.WriteLine($"Числа увеличились на 5: {number1},{number2},{number3}");
            }
            else
            {
                Console.WriteLine("Равных числе нет!");
            }
            
        }
    }
}
