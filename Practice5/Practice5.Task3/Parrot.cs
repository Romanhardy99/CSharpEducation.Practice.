using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    public class Parrot : Animal, IFlyable
    {
        public string Color { get; set; }
        public Parrot(string name, int age, string color) : base(name, age)
        {
            Color = color;
            Console.WriteLine($"Создан попугай с именем {name}, возраст {age} и цветом {color}");
        }

        public new void MakeSound()
        {
            Console.WriteLine("Попугай разговаривает!");
        }

        public void MakeSound(string words)
        {
            Console.WriteLine($"Попугай повторяет:{words}");
        }

        public void Fly()
        {
            Console.WriteLine();
        }
    }
}
