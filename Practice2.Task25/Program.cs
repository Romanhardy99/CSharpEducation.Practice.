using System.Data;

namespace Practice2.Task25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите число: ");

            while (true)
            {

                string temp = Console.ReadLine();

                if (int.TryParse(temp, out int result) && result > 0 && result < 8)
                {
                    Console.WriteLine(Print(result));
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
        }

        static string Print(int value)
        {
            switch ((Week)value)
            {

                case Week.Monday:
                    return "Понедельник";
                case Week.Tuesday:
                    return "Вторник";
                case Week.Wednesday:
                    return "Среда";
                case Week.Thursday:
                    return "Четверг";
                case Week.Friday:
                    return "Пятница";
                case Week.Saturday:
                    return "Суббота";
                case Week.Sunday:
                    return "Воскресенье";
            }
            return " ";
        }
        enum Week
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
