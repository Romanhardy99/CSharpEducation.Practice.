using System.ComponentModel;

namespace Practice2.Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();

            int[,] Array = new int[100,100];

            for (int i = 0; i < 100; i++)
            {
                {
                    for (int j = 0; j < 100; j++)
                    {
                        Array[i, j] = random.Next(0, 101);
                    }
                }
                
            }

            int max = Array[0,0];

            int min = Array[0,0];

            for (int i = 0; i < 100; i++)
            {
                for (int j =0; j < 100; j++)
                {
                    if (Array[i,j] > max)
                    {
                        max = Array[i,j];
                    }
                    if (Array[i,j] < min)
                    {
                        min = Array[i,j];
                    }
                }
            }

            int difference = max - min;

            Console.WriteLine("Массив: ");

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < 100; i++)
            {
                for(int j = 0;j < 100; j++)
                {
                    Console.Write(Array[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.WriteLine($"Максимальное значение: {max}");
            Console.WriteLine($"Минимальное значение: {min}");
            Console.WriteLine($"Разница между max и min: {difference}");
        }
    }
}
