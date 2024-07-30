namespace Practice2.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
                 
            if (args.Length < 1)
            {
                Console.WriteLine("Укажите размер массива");
                return;
            }

          
            int size;


            if (!int.TryParse(args[0], out size))
            {
                Console.WriteLine("Некорректные данные");
                return;
            }

            int[] myArray = new int[size];



            for (int i = 0; i < size; i++)
            {
                myArray[i] = i + 1;
            }

           
            Console.WriteLine("Элементов в массиве:");

            foreach (int value in myArray)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
