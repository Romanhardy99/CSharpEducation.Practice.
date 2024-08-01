namespace Practice2.Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            int[] array = CreateEmptyArray(n);

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 100);
            }

            Console.WriteLine("Массив: ");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            
        }
        static int[] CreateEmptyArray(int size)
        {
            return new int[size];
        }
    }
}
