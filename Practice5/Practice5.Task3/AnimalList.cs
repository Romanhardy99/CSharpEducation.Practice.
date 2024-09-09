using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    public class AnimalList
    {
        List<Animal> animals = new List<Animal>()
        {
            new Dog("Рэкс", 14, "Овчарка"),
            new Cat("Рыся", 2),
            new Parrot("Кеша",1, "Розовый")
        };
        public void AnimalSound()
        {
            foreach (Animal item in animals)
            {
                item.MakeSound();
            }
        }
    }
}
