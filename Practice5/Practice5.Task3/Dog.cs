using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    public class Dog : Animal
    {
        public string breed { get; set; }

        public Dog(string name, int age, string breed) : base(name, age) 
        { 
            this.breed = breed; 
            Console.WriteLine($"Создана собака с именем {name}, возрастом {age}, и породой {breed}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!"); ;
        }
    }
}
