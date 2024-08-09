namespace Practice3.Task7
{
    public class Program
    {

        static void Main(string[] args)
        {
            Year currentYear1 = Year.Январь;
            string message = PrintYear(currentYear1);
            Console.WriteLine(message);

            currentYear1 = Year.Декабрь;
            message = PrintYear(currentYear1);
            Console.WriteLine(message);

            currentYear1 = Year.Февраль;
            message = PrintYear(currentYear1);
            Console.WriteLine(message);


        }

        static string PrintYear(Year year)
        {
            switch (year)
            {
                case Year.Январь:
                    return "В январе 31 день";
                case Year.Февраль:
                    return "В феврале 28 дней";
                case Year.Март:
                    return "В марте 31 день";
                case Year.Апрель:
                    return "В апреле 30 день";
                case Year.Май:
                    return "В мае 31 день";
                case Year.Июнь:
                    return "В июне 30 дней";
                case Year.Июль:
                    return "В июле 31 день";
                case Year.Август:
                    return "В августе 31 день";
                case Year.Сентябрь:
                    return "В сентябре 30 дней";
                case Year.Октябрь:
                    return "В октябре 31 день";
                case Year.Ноябрь:
                    return "В ноябре 30 дней";
                case Year.Декабрь:
                    return "В декабре 31 день";
                default:
                    return "Неизвестный год";
            }

        }
    }

    enum Year
    {
        Январь,
        Февраль,
        Март,
        Апрель,
        Май,
        Июнь,
        Июль,
        Август,
        Сентябрь,
        Октябрь,
        Ноябрь,
        Декабрь
    }
}
