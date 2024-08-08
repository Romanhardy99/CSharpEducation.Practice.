namespace Practice3.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book book1 = new Book("The Shining");
            Console.WriteLine($"Название книги: {book1.Name}\n");
            Console.WriteLine();

            Book book2 = new Book("The Shining","Stephen Edwin King");
            Console.WriteLine($"Название книги: {book2.Name}\nАвтор книги: {book2.Autor}");
            Console.WriteLine();

            Book book3 = new Book("The Shining", "Stephen Edwin King",1977);
            Console.WriteLine($"Название книги: {book3.Name}\nАвтор книги: {book3.Autor}\nГод издания: {book3.Year}");

        }
    }
    public class Book
    {
        public string Name { get; set; }
        public string Autor { get; set; }
        public int? Year { get; set; }


        public Book(string name, string autor, int year)
        {
            Name = name;
            Autor = autor;
            Year = year;
        }

        public Book()
        {
            Name = "The Shining";
            Autor = "Stephen Edwin King";
            Year = 1977;
        }

        public Book(string name)
        {
            Name = "The Shining";
            Autor = "Неизвестно";
            Year = null;
        }
        public Book(string name, string autor)
        {
            Name = "The Shining";
            Autor = "Stephen Edwin King";
            Year = null;
        }


    }
}
