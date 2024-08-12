namespace Practice2.Task24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = typeof(Week).GetEnumNames();

            foreach (var name in list)
            {
                Console.WriteLine(Print(name));
            }
        }

        private static string Print(string name)
        {
            var day = Enum.Parse(typeof(Week), name);

            switch (day)
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
            return name;
        }

        enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
