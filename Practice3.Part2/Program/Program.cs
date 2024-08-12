using Practice3.Part2.Task1;

namespace Practice3.Part2.Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            MathHelper mathHelper = new MathHelper();

            int mathHelper1 = mathHelper.Add(5,8); 

            int mathHelper2 = mathHelper.Sub(5,8);

            int mathHelper3 = mathHelper.Mult(5,8);

            double mathHelper4 = mathHelper.Div(5,5);

            Console.WriteLine($"Сложение: {mathHelper1}\nВычитание: {mathHelper2}\nУмножение: {mathHelper3}\nДеление: {mathHelper4}");
        }
    }
}
