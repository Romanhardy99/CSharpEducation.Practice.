namespace Practice2.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Укажите размер массива");
                return;
            }

            if (!int.TryParse(args[0], out int size))
            {
                Console.WriteLine("Некорректные данные");
                return;
            }

            if (!int.TryParse (args[1], out int fillValue))
            {
                Console.WriteLine("Второй аргумент должен быть целым числом");
                return;
            }

            int[] array = new int[size];



            for (int i = 0; i < size; i++)
            {
                array[i] = i + 1;
            }


            Console.WriteLine("Элементов в массиве:");

            for (int i = 0;i < size; i++)
            {
                array[i] = fillValue;
            }

            Console.WriteLine(String.Join(" , ", array));
        }
    }
}
