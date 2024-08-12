namespace Practice3.Task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(3, 4);
            Point point2 = new Point(8, 1);

            double distance = Point.Calculate(point1, point2);
            Console.WriteLine($"Расстояние между точками: {distance}");
        }
    }

    struct Point
    {
        int X { get; set; }
        int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static double Calculate(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

    }

}
