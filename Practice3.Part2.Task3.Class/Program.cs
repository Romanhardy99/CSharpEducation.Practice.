using Practice3.Part2.Task3.Lib;

namespace Practice3.Part2.Task3.Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            string person1 = person.GetName();

            int person2 = person.GetAge();

            Console.WriteLine($"Имя: {person1}\nВозраст: {person2}");
        }
    }
}
