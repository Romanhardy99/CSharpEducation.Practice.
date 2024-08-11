namespace Practice3.Part2.Task1
{
    public class MathHelper
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Делить на ноль нельзя");
            }
            return a / b;
        }

    }
}
