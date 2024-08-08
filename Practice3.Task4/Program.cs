namespace Practice3.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //c параметрами
            Book book1 = new Book("The Shining", "Stephen Edwin King");
            Console.WriteLine($"Название книги: {book1.Name}\nАвтор книги: {book1.Autor}");

            Console.WriteLine();
            //без
            Book book2 = new Book();
            Console.WriteLine($"Название книги: {book1.Name}\nАвтор книги: {book1.Autor}");

        }
    }
    public class Book
    {
        public string Name { get; set; }
        public string Autor { get; set; }

        public Book(string name, string autor)
        {
            Name = name;
            Autor = autor;
        }

        public Book()
        {
            Name = "The Shining";

            Autor = "Stephen Edwin King";
        }
    }
}
