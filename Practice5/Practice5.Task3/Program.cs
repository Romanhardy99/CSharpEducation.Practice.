namespace Practice5.Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Филимон", 10);
            Dog dog = new Dog("Рэкс", 14, "Овчарка");
            Cat cat = new Cat("Рыся", 3);
            Parrot parrot = new Parrot("Кеша", 2, "Розовый");
            AnimalList animalList = new AnimalList();
            Eagle eagle = new Eagle("Нормис", 5);

           
            Console.WriteLine("Класс Animal: ");
            animal.Eat();
            animal.Sleep();
            animal.MakeSound();
            Console.WriteLine();

            Console.WriteLine("Класс Dog: ");
            dog.Eat();
            dog.Sleep();
            dog.MakeSound();
            Console.WriteLine();

            Console.WriteLine("Класс Cat: ");
            cat.Eat();
            cat.Sleep();
            cat.MakeSound();

            Console.WriteLine("Класс Parrot: ");
            parrot.MakeSound();
            parrot.MakeSound("Привет, меня зовут Кеша!\n");
            parrot.Fly();


            Console.WriteLine("Список животных: ");
            animalList.AnimalSound();

            IFlyable[] flyables = new IFlyable[]
           {
                new Parrot("Кеша", 2, "Розовый"),
                new Eagle("Нормис", 5)
           };

           foreach (IFlyable item in flyables)
           {
                item.Fly();
           }

        }
    }
}
