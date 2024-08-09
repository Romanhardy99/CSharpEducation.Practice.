using System.Runtime.CompilerServices;

namespace Practice3.Task9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Рома", 30);

            Console.WriteLine($"Имя при рождении: {student1.Name} и возраст {student1.Age}");

            string Std = student1.Rename("Аноним");

            Console.WriteLine($"Имя измененно: {Std}");


        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;

            Age = age;
        }

        public string Rename(string name)
        {
            return name = "Аноним";
        }
    }
}
