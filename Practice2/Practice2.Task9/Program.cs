namespace Practice2.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите размер массива: ");

            int size;

            if (int.TryParse(Console.ReadLine(), out size) && size > 0)
            {
                int[] array = CreateArray(size);

                PrintArray(array);
            }

            static int[] CreateArray(int size)
            {
                int[] array = new int[size];

                for (int i = 0; i < size; i++)
                {
                    array[i] = i + 1;
                }
                return array;

            }


            

           
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("Размер массива: ");

            foreach (int number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}
