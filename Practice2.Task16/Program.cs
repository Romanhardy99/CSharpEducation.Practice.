namespace Practice2.Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 15;
            Console.WriteLine($"Число по ссылке до метода: {num}");
            Increment(ref num);
            Console.WriteLine($"Число по ссылке после метода: {num}");
        }

        static void Increment(ref int n)
        {
            n = -n;
        }

    }
}
