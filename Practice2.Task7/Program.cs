namespace Practice2.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string message = Console.ReadLine();

            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Перевести строку в верхний регистр");
            Console.WriteLine("2 - Перевести строку в нижний регистр");
            Console.WriteLine("3 - Сделать первую букву заглавной");
            

            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case '1':
                    Console.WriteLine("Строка переведенная в верхний регистр: " + message.ToUpper());
                    break;
                case '2':
                    Console.WriteLine("Строка переведенна в нижний регистр: " + message.ToLower());
                    break;
                case '3':
                    Console.WriteLine("Заглавная буква в первом слове: " + GetUpper(message));
                    break;
                default:
                    Console.WriteLine("Неправильный выбор. Выберете 1, 2 или 3");
                    break;
            }

            
            static string GetUpper(string input)
            {
                if (string.IsNullOrEmpty(input))
                {
                    return input;
                }
                return char.ToUpper(input[0]) + input.Substring(1);
            }
                  
        }
    }
}
