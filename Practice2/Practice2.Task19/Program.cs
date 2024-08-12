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



            int max = Array[0];

            int min = Array[0];

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > max)
                {
                    max = Array[i];
                }
                if (Array[i] < min)
                {
                    min = Array[i];
                }
            }

            int difference = max - min;

            Console.WriteLine("Массив: ");

            foreach (int i in Array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Разница между максимальным и минимальным значением: " + difference);


        }
    }
}
