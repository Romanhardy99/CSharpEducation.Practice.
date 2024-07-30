namespace Ptactice2.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            char targetChar;

            if (args.Length >= 2)
            {
                
                inputString = args[0];
                targetChar = args[1][0]; 
            }
            else if (args.Length == 0)
            {
                
                Console.Write("Введите строку: ");
                inputString = Console.ReadLine();

                Console.Write("Введите символ: ");
                targetChar = Console.ReadKey().KeyChar;
                Console.WriteLine(); 
            }
            else
            {
                
                inputString = "Пример тестового подсчета";
                targetChar = 'т';
            }

           
            int totalCount = inputString.Length;
            int targetCount = 0;

            foreach (char c in inputString)
            {
                if (c == targetChar)
                {
                    targetCount++;
                }
            }

            double percentage = (double)targetCount / totalCount * 100;
            Console.WriteLine($"Процент вхождения символа '{targetChar}' в строку: {percentage:F2}%");
            Console.ReadKey();
        }
    
    }
}
