using System.Linq.Expressions;

namespace Practice2.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите высоту треугольника: ");
            int height;
            while (!int.TryParse(Console.ReadLine(), out height) && height <= 0)
            {
                Console.Write("Ввести положительное число высоты: ");
            }

            Console.Write("Введите символ для рисования: ");
            char symvol;
            while (!char.TryParse(Console.ReadLine(), out symvol))
            {
                Console.Write("Введите только 1 символ: ");
            }
            DrawTriangle(height, symvol);


        }

        static void DrawTriangle(int height, char symvol)
        {
            for (int i = 1; i <= height; i++)
            {
                string line = new string(symvol, i);
                Console.WriteLine(line);
            }
        }
    }
}
