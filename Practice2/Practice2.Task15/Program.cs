namespace Practice2.Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Console.Write("Исходный массив: ");
            

            PrintArray(array);

            InvertArray(array);

            Console.WriteLine();

            Console.Write("Инвертированный массив: ");

            PrintArray(array);
        }

        static void PrintArray(int[] array)
        {
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
        }

        static void InvertArray(int[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[length - 1 - i];
                array[length - 1 - i] = temp;
            }
        }
    }
}
