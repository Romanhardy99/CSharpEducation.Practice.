using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    public class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Animal(string name, int age) 
        {
            Name = name;

            Age = age;
            
            Console.WriteLine($"Созданно животное {name}, возраст {age}");
        }

        public void Eat() { Console.WriteLine("Кушает"); }
        public void Sleep() { Console.WriteLine("Спит"); }

        public virtual void MakeSound() { Console.WriteLine("Some generic animal sound"); }
    }
}
