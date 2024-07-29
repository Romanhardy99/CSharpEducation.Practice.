using System;

namespace Practice2.Task1
{
    public class Program : Prost
    {
        static void Main(string[] args)
        {
            var Fun = new Program();

            Prost prost = new Prost();

            Console.WriteLine($"Задание a: ");

            Fun.СycleFor();

            Console.WriteLine("Задание b: ");

            Fun.CycleWhile();

            Console.WriteLine("Задание c: ");

            Fun.CycleDoWhile();

            Console.WriteLine("Задание d: ");

            string getFor = prost.ForMessage();
            Console.WriteLine(getFor);
            Console.WriteLine("\t");

            Console.WriteLine("Задание e: ");

            string getWhile = prost.WhileMessage();
            Console.WriteLine(getWhile);
            Console.WriteLine("\t");

            Console.WriteLine("Задание f: ");

            string getDoWhile = prost.DoWhileMessage();
            Console.WriteLine(getDoWhile);
            Console.WriteLine("\t");


        }

        #region Methods
        public void СycleFor()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
        }

        public void CycleWhile()
        {
            int j = 0;

            while (j <= 5)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine("\n");
        }

        public void CycleDoWhile()
        {
            int j = 0;
            do
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine(j);
                }
            }
            while (j < 5);
            Console.WriteLine("\t");
        }
        #endregion      

    }

    public class Prost
    {
        public string ForMessage()
        {
            Console.Write("Сколько слов вы хотите ввести?");

            int wordCount;

            while (!int.TryParse(Console.ReadLine(), out wordCount) && wordCount <= 0)
            {
                Console.WriteLine("Введите корректное число");
            }

            string[] words = new string[wordCount];

            for (int i = 0; i < words.Length; i++) 
            {
                Console.WriteLine($"Введите слово {i + 1}: ");

                words[i] = Console.ReadLine();
            }

            return string.Join(" ", words);

        }

        public string WhileMessage()
        {
            Console.Write("Сколько слов вы хотите ввести?");

            int wordCount;

            while( !int.TryParse(Console.ReadLine(),out wordCount) && wordCount<= 0)
            {
                Console.WriteLine("Введите корректное число");
            }

            string[] words = new string[wordCount];

            int i = 0;

            while (i < words.Length)
            {
                Console.WriteLine($"Введите слово {i + 1}: ");
                words[i] = Console.ReadLine();
                i++;
            }

            return string.Join(" ", words);
        }

        public string DoWhileMessage()
        {
            Console.Write("Сколько слов вы хотите ввести?");
            int wordCount;
            while ( !int.TryParse(Console.ReadLine(), out wordCount) && wordCount<= 0)
            {
                Console.WriteLine("Введите корректное число");
            }
            string[] words = new string[wordCount];
            int i = 0;
            do
            {
                Console.Write($"Введите число {i + 1}: ");
                words[i] = Console.ReadLine();
                i++;
            }
            while (i < wordCount);
            return string.Join(" ", words);
        }
    }
}
