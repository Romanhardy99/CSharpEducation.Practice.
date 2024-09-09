using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    public class Cat : Animal
    {
        public Cat(string name, int age) : base (name, age) { Console.WriteLine($"Создана кошка с именем {name}, возрастом {age}"); }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!"); ;
        }
    }
}
