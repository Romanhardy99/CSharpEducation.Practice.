using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    public class Eagle : IFlyable
    {
        private string name { get; set; }
        private int age {  get; set; }
        public Eagle(string name, int age) { this.name=name; this.age = age;}
        void Fly()
        {
            Console.WriteLine("Орел летает высоко");
        }
    }
}
