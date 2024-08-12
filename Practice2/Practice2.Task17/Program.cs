namespace Practice2.Task17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 15;
            int b = 30;
            Console.WriteLine($"до метода: a = {a}, b = {b}", a, b);

            Swap(ref a, ref b);

            Console.WriteLine($"после метода: a = {a}, b = {b}", a, b);
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
