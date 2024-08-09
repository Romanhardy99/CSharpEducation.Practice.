// Создай класс "Книга" с полями "Название" и "Автор". Напиши метод, который будет
//принимать объект класса "Книга" и возвращать информацию о книге в виде строки.



namespace Practice3.Task11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Очумелые ручки", "Стивен Кинг");

            string book1 = book.GetName();

            string book2 = book.GetAutor();

            Console.WriteLine($"Ну тут какой то текст нужно написать и в скобочках: {book1}\nИ типа король стивинг: {book2}");
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

        public string GetName()
        {
            return Name;
        }

        public string GetAutor()
        {
            return Autor;
        }

    }
}
