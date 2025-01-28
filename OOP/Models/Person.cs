using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
   
    internal abstract class Person
    { 
        public string Name { get; set; }
        public int Age { get; set; }
        public void Introduce()
        {
            Console.WriteLine($"Name {Name} Age {Age}");
        }
        //public abstract void MakeSound();
        public abstract void Work();

        public abstract void PrintInfo();

    }
    class MyClass
    {
        public string MyProperty { get; set; }

        public MyClass(string myProperty)
        {
            MyProperty = myProperty;
        }
    }

    class Test : MyClass
    {
        public Test(string myProperty) : base(myProperty)
        {
        }
    }
}
