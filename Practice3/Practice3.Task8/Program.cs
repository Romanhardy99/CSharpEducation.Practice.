namespace Practice3.Task8
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите ширинку: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высотку: ");
            double height = Convert.ToDouble(Console.ReadLine());
            

            Rectangle rect = new Rectangle(width, height);

            double area = rect.CalculateArea();

            Console.WriteLine($"Площадь прямоугольника: {area}");
        }
    }

    struct Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }



    }
}
