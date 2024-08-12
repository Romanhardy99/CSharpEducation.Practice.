using System.Data;
using System.Drawing;

namespace Practice2.Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            int rows = 30;

            int cols = 15;

            int[,] matrix = CreateMatrix(rows, cols);

            PrintMatrix(matrix);

            Console.ResetColor();
        }
       static int[,] CreateMatrix(int rows, int cols)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
