namespace Practice2.Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] Array = new int[100];

            for (int i = 0; i < 100; i++)
            {
                Array[i] = random.Next(0, 100);
            }
           
            foreach (int i in Array)
            {
                Console.Write(i);
            }
        }
    }
}
