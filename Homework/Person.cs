using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Person
    {
        public string Name { get; set; }    
        public int Age { get; set; }
        public string City { get; set; }
        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old and I am from {City}.");
        }
    }
}
