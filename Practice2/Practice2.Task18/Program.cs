namespace Practice2.Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { -1, 2, -3, 4, 5, -6 };

            int removedCount;

            int[] changeArray = RemoveNegativeNumbers(Array, out removedCount);

            Console.WriteLine("Массив до изменения: " + string.Join(", ", Array));

            Console.WriteLine("Массив после изменения: " + string.Join(", ", changeArray));

            Console.WriteLine("Количество удаленных символов: " + removedCount);
        }

        public static int[] RemoveNegativeNumbers(int[] inputArray, out int removedCount)
        {
            int count = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] >= 0)
                {
                    count++;
                }
            }

            int[] resultArray = new int[count];

            int index = 0;

            for (int i = 0; i < inputArray.Length; i ++)
            {
                if(inputArray[i] >= 0)
                {
                    resultArray[index] = inputArray[i];
                    index++;
                }
            }
            removedCount = inputArray.Length - resultArray.Length;

            return resultArray;
        }
    }
}
