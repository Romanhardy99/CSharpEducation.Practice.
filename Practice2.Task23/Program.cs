namespace Practice2.Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            while (true)
            {


                Console.WriteLine("Введите год: ");

                if (int.TryParse(Console.ReadLine(), out year))
                {
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        Console.WriteLine($"{year} год является високосным");
                    }
                    else
                    {
                        Console.WriteLine($"{year} год не является високосным");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }




        }
    }
}
